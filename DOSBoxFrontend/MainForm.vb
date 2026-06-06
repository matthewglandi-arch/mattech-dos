Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class MainForm

    ' ── App data paths ────────────────────────────────────────────────────────
    Private ReadOnly AppDataDir As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "DOSBoxFrontend")
    Private ReadOnly SettingsFile As String

    ' ── State ─────────────────────────────────────────────────────────────────
    Private _dosboxProcess As Process = Nothing
    Private _mountedA As String = ""
    Private _mountedB As String = ""
    Private _floppyImages As New List(Of FloppyImage)
    Private _recentImages As New List(Of String)   ' paths, newest first
    Private _libraryFolder As String = ""
    Private _dosboxExe As String = ""
    Private _dosboxConfig As String = ""
    Private _cycles As String = "auto"
    Private _memoryMB As String = "8"
    Private _fullscreen As Boolean = False

    ' ── Floppy image record ───────────────────────────────────────────────────
    Private Class FloppyImage
        Public Property FilePath As String
        Public Property Name As String
        Public Property SizeKB As Long
        Public Property LastUsed As DateTime = DateTime.MinValue

        Public Sub New(path As String)
            FilePath = path
            Name = Path.GetFileName(path)
            Try
                Dim fi As New FileInfo(path)
                SizeKB = fi.Length \ 1024
            Catch
                SizeKB = 0
            End Try
        End Sub
    End Class

    ' =========================================================================
    ' FORM LOAD / CLOSE
    ' =========================================================================
    Public Sub New()
        InitializeComponent()
        SettingsFile = Path.Combine(AppDataDir, "settings.ini")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        RefreshFloppyList()
        RefreshRecentCombo()
        RefreshQuickAccess()
        UpdateMountedDisplay()
        UpdateStatusBar()
        TimerStatus.Start()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveSettings()
    End Sub


    ' =========================================================================
    ' SETTINGS  (simple INI-style key=value)
    ' =========================================================================
    Private Sub LoadSettings()
        If Not Directory.Exists(AppDataDir) Then Directory.CreateDirectory(AppDataDir)

        _dosboxExe = ""
        _dosboxConfig = ""
        _libraryFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        _cycles = "auto"
        _memoryMB = "8"
        _fullscreen = False
        _recentImages.Clear()
        _floppyImages.Clear()

        If File.Exists(SettingsFile) Then
            For Each line As String In File.ReadAllLines(SettingsFile)
                Dim parts = line.Split(New Char() {"="c}, 2)
                If parts.Length < 2 Then Continue For
                Dim key = parts(0).Trim()
                Dim val = parts(1).Trim()
                Select Case key
                    Case "DOSBoxExe" : _dosboxExe = val
                    Case "DOSBoxConfig" : _dosboxConfig = val
                    Case "LibraryFolder" : _libraryFolder = val
                    Case "Cycles" : _cycles = val
                    Case "MemoryMB" : _memoryMB = val
                    Case "Fullscreen" : _fullscreen = (val = "True")
                    Case "Recent"
                        If File.Exists(val) Then _recentImages.Add(val)
                    Case "Image"
                        If File.Exists(val) Then _floppyImages.Add(New FloppyImage(val))
                End Select
            Next
        End If

        ' Push to UI
        TxtDOSBoxPath.Text = _dosboxExe
        TxtSettingsDOSBoxExe.Text = _dosboxExe
        TxtSettingsConfig.Text = _dosboxConfig
        TxtLibraryPath.Text = _libraryFolder
        TxtSettingsLibrary.Text = _libraryFolder
        TxtCycles.Text = _cycles
        ChkFullscreen.Checked = _fullscreen

        Dim memIdx As Integer = CmbMemory.Items.IndexOf(_memoryMB)
        CmbMemory.SelectedIndex = If(memIdx >= 0, memIdx, 3)
    End Sub

    Private Sub SaveSettings()
        If Not Directory.Exists(AppDataDir) Then Directory.CreateDirectory(AppDataDir)
        Dim lines As New List(Of String)
        lines.Add("DOSBoxExe=" & _dosboxExe)
        lines.Add("DOSBoxConfig=" & _dosboxConfig)
        lines.Add("LibraryFolder=" & _libraryFolder)
        lines.Add("Cycles=" & _cycles)
        lines.Add("MemoryMB=" & _memoryMB)
        lines.Add("Fullscreen=" & _fullscreen.ToString())
        For Each r In _recentImages.Take(20)
            lines.Add("Recent=" & r)
        Next
        For Each img In _floppyImages
            lines.Add("Image=" & img.FilePath)
        Next
        File.WriteAllLines(SettingsFile, lines)
    End Sub


    ' =========================================================================
    ' LAUNCH TAB
    ' =========================================================================
    Private Sub BtnLaunchDOSBox_Click(sender As Object, e As EventArgs) Handles BtnLaunchDOSBox.Click
        LaunchDOSBox("")
    End Sub

    Private Sub BtnQuickLaunchFloppy_Click(sender As Object, e As EventArgs) Handles BtnQuickLaunchFloppy.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Floppy Image to Mount as A:"
            ofd.Filter = "Floppy Images (*.img;*.ima;*.vfd;*.flp)|*.img;*.ima;*.vfd;*.flp|All Files (*.*)|*.*"
            ofd.InitialDirectory = _libraryFolder
            If ofd.ShowDialog() = DialogResult.OK Then
                AddToRecent(ofd.FileName)
                LaunchDOSBox(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub BtnLaunchWithRecent_Click(sender As Object, e As EventArgs) Handles BtnLaunchWithRecent.Click
        If CmbRecentFloppy.SelectedIndex < 0 Then
            LaunchDOSBox("")
        Else
            Dim path As String = CmbRecentFloppy.SelectedItem.ToString()
            If File.Exists(path) Then
                AddToRecent(path)
                LaunchDOSBox(path)
            Else
                MessageBox.Show("File not found: " & path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub BtnBrowseDOSBox_Click(sender As Object, e As EventArgs) Handles BtnBrowseDOSBox.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Locate DOSBox Executable"
            ofd.Filter = "Executables (*.exe)|*.exe|All Files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                _dosboxExe = ofd.FileName
                TxtDOSBoxPath.Text = _dosboxExe
                TxtSettingsDOSBoxExe.Text = _dosboxExe
                SaveSettings()
            End If
        End Using
    End Sub

    Private Sub TxtDOSBoxPath_TextChanged(sender As Object, e As EventArgs) Handles TxtDOSBoxPath.TextChanged
        _dosboxExe = TxtDOSBoxPath.Text
        TxtSettingsDOSBoxExe.Text = _dosboxExe
    End Sub

    Private Sub LaunchDOSBox(floppyPath As String)
        If String.IsNullOrWhiteSpace(_dosboxExe) OrElse Not File.Exists(_dosboxExe) Then
            MessageBox.Show("Please set the DOSBox executable path first (Launch tab or Settings tab).",
                            "DOSBox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim args As New System.Text.StringBuilder()

        If Not String.IsNullOrWhiteSpace(_dosboxConfig) AndAlso File.Exists(_dosboxConfig) Then
            args.Append("-conf """ & _dosboxConfig & """ ")
        End If

        If Not String.IsNullOrWhiteSpace(floppyPath) AndAlso File.Exists(floppyPath) Then
            ' Use -c to send imgmount command
            args.Append("-c ""imgmount a '" & floppyPath & "' -t floppy"" ")
            _mountedA = floppyPath
            UpdateMountedDisplay()
        End If

        If _fullscreen Then args.Append("-fullscreen ")

        Try
            Dim psi As New ProcessStartInfo(_dosboxExe, args.ToString().Trim())
            psi.UseShellExecute = True
            _dosboxProcess = Process.Start(psi)
            StatusLabelMain.Text = "DOSBox launched."
            UpdateStatusBar()
        Catch ex As Exception
            MessageBox.Show("Failed to launch DOSBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' =========================================================================
    ' FLOPPY TAB – Library list
    ' =========================================================================
    Private Sub BtnAddImages_Click(sender As Object, e As EventArgs) Handles BtnAddImages.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Add Floppy Image(s) to Library"
            ofd.Filter = "Floppy Images (*.img;*.ima;*.vfd;*.flp)|*.img;*.ima;*.vfd;*.flp|All Files (*.*)|*.*"
            ofd.Multiselect = True
            ofd.InitialDirectory = _libraryFolder
            If ofd.ShowDialog() = DialogResult.OK Then
                For Each f In ofd.FileNames
                    AddImageToLibrary(f)
                Next
                RefreshFloppyList()
                SaveSettings()
            End If
        End Using
    End Sub

    Private Sub BtnRemoveImage_Click(sender As Object, e As EventArgs) Handles BtnRemoveImage.Click
        RemoveSelectedImages()
    End Sub

    Private Sub CtxRemove_Click(sender As Object, e As EventArgs) Handles CtxRemove.Click
        RemoveSelectedImages()
    End Sub

    Private Sub RemoveSelectedImages()
        If LvFloppyImages.SelectedItems.Count = 0 Then Return
        For Each item As ListViewItem In LvFloppyImages.SelectedItems
            Dim path = item.SubItems(2).Text
            _floppyImages.RemoveAll(Function(x) x.FilePath = path)
        Next
        RefreshFloppyList()
        SaveSettings()
    End Sub

    Private Sub BtnMountA_Click(sender As Object, e As EventArgs) Handles BtnMountA.Click
        MountSelected("A")
    End Sub

    Private Sub BtnMountB_Click(sender As Object, e As EventArgs) Handles BtnMountB.Click
        MountSelected("B")
    End Sub

    Private Sub CtxMountA_Click(sender As Object, e As EventArgs) Handles CtxMountA.Click
        MountSelected("A")
    End Sub

    Private Sub CtxMountB_Click(sender As Object, e As EventArgs) Handles CtxMountB.Click
        MountSelected("B")
    End Sub

    Private Sub MountSelected(drive As String)
        If LvFloppyImages.SelectedItems.Count = 0 Then
            MessageBox.Show("Select a floppy image first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim path = LvFloppyImages.SelectedItems(0).SubItems(2).Text
        If Not File.Exists(path) Then
            MessageBox.Show("File not found: " & path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If drive = "A" Then
            _mountedA = path
        Else
            _mountedB = path
        End If

        ' Update last-used
        Dim img = _floppyImages.Find(Function(x) x.FilePath = path)
        If img IsNot Nothing Then img.LastUsed = DateTime.Now
        AddToRecent(path)
        RefreshFloppyList()
        RefreshRecentCombo()
        RefreshQuickAccess()
        UpdateMountedDisplay()
        UpdateStatusBar()
        SaveSettings()

        StatusLabelMain.Text = "Mounted " & Path.GetFileName(path) & " as " & drive & ":"

        ' If DOSBox is running, send imgmount via stdin is not reliable;
        ' inform user instead.
        If _dosboxProcess IsNot Nothing AndAlso Not _dosboxProcess.HasExited Then
            MessageBox.Show("DOSBox is already running." & vbCrLf &
                "To mount inside DOSBox, type in the DOSBox window:" & vbCrLf & vbCrLf &
                "  imgmount " & drive.ToLower() & " """ & path & """ -t floppy",
                "Mount Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEject_Click(sender As Object, e As EventArgs) Handles BtnEject.Click
        If LvFloppyImages.SelectedItems.Count = 0 Then Return
        Dim path = LvFloppyImages.SelectedItems(0).SubItems(2).Text
        If _mountedA = path Then
            _mountedA = ""
        ElseIf _mountedB = path Then
            _mountedB = ""
        End If
        UpdateMountedDisplay()
        UpdateStatusBar()
    End Sub

    Private Sub BtnEjectA_Click(sender As Object, e As EventArgs) Handles BtnEjectA.Click
        _mountedA = ""
        UpdateMountedDisplay()
        UpdateStatusBar()
    End Sub

    Private Sub BtnEjectB_Click(sender As Object, e As EventArgs) Handles BtnEjectB.Click
        _mountedB = ""
        UpdateMountedDisplay()
        UpdateStatusBar()
    End Sub

    Private Sub BtnCreateImage_Click(sender As Object, e As EventArgs) Handles BtnCreateImage.Click
        ShowCreateImageDialog()
    End Sub

    Private Sub BtnOpenLibFolder_Click(sender As Object, e As EventArgs) Handles BtnOpenLibFolder.Click
        If Directory.Exists(_libraryFolder) Then
            Process.Start("explorer.exe", _libraryFolder)
        End If
    End Sub

    Private Sub CtxOpenFolder_Click(sender As Object, e As EventArgs) Handles CtxOpenFolder.Click
        If LvFloppyImages.SelectedItems.Count = 0 Then Return
        Dim path = LvFloppyImages.SelectedItems(0).SubItems(2).Text
        Dim folder = Path.GetDirectoryName(path)
        If Directory.Exists(folder) Then
            Process.Start("explorer.exe", "/select,""" & path & """")
        End If
    End Sub

    Private Sub BtnBrowseLibrary_Click(sender As Object, e As EventArgs) Handles BtnBrowseLibrary.Click
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select Floppy Image Library Folder"
            fbd.SelectedPath = _libraryFolder
            If fbd.ShowDialog() = DialogResult.OK Then
                _libraryFolder = fbd.SelectedPath
                TxtLibraryPath.Text = _libraryFolder
                TxtSettingsLibrary.Text = _libraryFolder
                SaveSettings()
            End If
        End Using
    End Sub

    ' Drag-and-drop onto the list
    Private Sub LvFloppyImages_DragEnter(sender As Object, e As DragEventArgs) Handles LvFloppyImages.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub LvFloppyImages_DragDrop(sender As Object, e As DragEventArgs) Handles LvFloppyImages.DragDrop
        Dim files = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim validExts = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {".img", ".ima", ".vfd", ".flp"}
        For Each f In files
            If validExts.Contains(Path.GetExtension(f)) Then
                AddImageToLibrary(f)
            End If
        Next
        RefreshFloppyList()
        SaveSettings()
    End Sub

    ' Double-click = mount as A:
    Private Sub LvFloppyImages_DoubleClick(sender As Object, e As EventArgs) Handles LvFloppyImages.DoubleClick
        MountSelected("A")
    End Sub


    ' =========================================================================
    ' SETTINGS TAB
    ' =========================================================================
    Private Sub BtnSettingsBrowseDOSBox_Click(sender As Object, e As EventArgs) Handles BtnSettingsBrowseDOSBox.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Locate DOSBox Executable"
            ofd.Filter = "Executables (*.exe)|*.exe|All Files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                _dosboxExe = ofd.FileName
                TxtSettingsDOSBoxExe.Text = _dosboxExe
                TxtDOSBoxPath.Text = _dosboxExe
            End If
        End Using
    End Sub

    Private Sub BtnSettingsBrowseConfig_Click(sender As Object, e As EventArgs) Handles BtnSettingsBrowseConfig.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select DOSBox Config File"
            ofd.Filter = "Config Files (*.conf;*.cfg)|*.conf;*.cfg|All Files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                _dosboxConfig = ofd.FileName
                TxtSettingsConfig.Text = _dosboxConfig
            End If
        End Using
    End Sub

    Private Sub BtnEditConfig_Click(sender As Object, e As EventArgs) Handles BtnEditConfig.Click
        Dim cfg = TxtSettingsConfig.Text.Trim()
        If String.IsNullOrWhiteSpace(cfg) Then
            MessageBox.Show("No config file selected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not File.Exists(cfg) Then
            MessageBox.Show("Config file not found: " & cfg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Process.Start("notepad.exe", """" & cfg & """")
    End Sub

    Private Sub BtnSettingsBrowseLibrary_Click(sender As Object, e As EventArgs) Handles BtnSettingsBrowseLibrary.Click
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select Default Floppy Library Folder"
            fbd.SelectedPath = _libraryFolder
            If fbd.ShowDialog() = DialogResult.OK Then
                _libraryFolder = fbd.SelectedPath
                TxtSettingsLibrary.Text = _libraryFolder
                TxtLibraryPath.Text = _libraryFolder
            End If
        End Using
    End Sub

    Private Sub BtnSaveSettings_Click(sender As Object, e As EventArgs) Handles BtnSaveSettings.Click
        _dosboxExe = TxtSettingsDOSBoxExe.Text.Trim()
        _dosboxConfig = TxtSettingsConfig.Text.Trim()
        _libraryFolder = TxtSettingsLibrary.Text.Trim()
        _cycles = TxtCycles.Text.Trim()
        _memoryMB = If(CmbMemory.SelectedItem IsNot Nothing, CmbMemory.SelectedItem.ToString(), "8")
        _fullscreen = ChkFullscreen.Checked
        TxtDOSBoxPath.Text = _dosboxExe
        TxtLibraryPath.Text = _libraryFolder
        SaveSettings()
        StatusLabelMain.Text = "Settings saved."
        MessageBox.Show("Settings saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnResetSettings_Click(sender As Object, e As EventArgs) Handles BtnResetSettings.Click
        If MessageBox.Show("Reset all settings to defaults?", "Confirm",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _dosboxExe = ""
            _dosboxConfig = ""
            _libraryFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            _cycles = "auto"
            _memoryMB = "8"
            _fullscreen = False
            TxtSettingsDOSBoxExe.Text = ""
            TxtSettingsConfig.Text = ""
            TxtSettingsLibrary.Text = _libraryFolder
            TxtDOSBoxPath.Text = ""
            TxtLibraryPath.Text = _libraryFolder
            TxtCycles.Text = "auto"
            CmbMemory.SelectedIndex = 3
            ChkFullscreen.Checked = False
            SaveSettings()
        End If
    End Sub


    ' =========================================================================
    ' TIMER – status bar polling
    ' =========================================================================
    Private Sub TimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick
        UpdateStatusBar()
    End Sub

    Private Sub UpdateStatusBar()
        Dim running As Boolean = (_dosboxProcess IsNot Nothing AndAlso Not _dosboxProcess.HasExited)
        StatusLabelDOSBox.Text = If(running, "DOSBox: Running", "DOSBox: Not Running")
        StatusLabelDriveA.Text = If(String.IsNullOrEmpty(_mountedA), "A: (empty)", "A: " & Path.GetFileName(_mountedA))
        StatusLabelDriveB.Text = If(String.IsNullOrEmpty(_mountedB), "B: (empty)", "B: " & Path.GetFileName(_mountedB))
        LblDOSBoxStatus.Text = If(running, "DOSBox: Running", "DOSBox: Not Running")
        LblDOSBoxStatus.ForeColor = If(running, System.Drawing.Color.Green, System.Drawing.Color.DarkRed)
    End Sub

    ' =========================================================================
    ' HELPERS
    ' =========================================================================
    Private Sub AddImageToLibrary(path As String)
        If _floppyImages.Exists(Function(x) x.FilePath.Equals(path, StringComparison.OrdinalIgnoreCase)) Then Return
        _floppyImages.Add(New FloppyImage(path))
    End Sub

    Private Sub AddToRecent(path As String)
        _recentImages.RemoveAll(Function(x) x.Equals(path, StringComparison.OrdinalIgnoreCase))
        _recentImages.Insert(0, path)
        If _recentImages.Count > 20 Then _recentImages.RemoveAt(_recentImages.Count - 1)
    End Sub

    Private Sub RefreshFloppyList()
        LvFloppyImages.BeginUpdate()
        LvFloppyImages.Items.Clear()
        For Each img In _floppyImages
            Dim item As New ListViewItem(img.Name)
            item.SubItems.Add(img.SizeKB & " KB")
            item.SubItems.Add(img.FilePath)
            item.SubItems.Add(If(img.LastUsed = DateTime.MinValue, "", img.LastUsed.ToString("yyyy-MM-dd HH:mm")))
            ' Highlight mounted images
            If img.FilePath = _mountedA Then
                item.BackColor = System.Drawing.Color.FromArgb(220, 255, 220)
                item.ToolTipText = "Mounted as A:"
            ElseIf img.FilePath = _mountedB Then
                item.BackColor = System.Drawing.Color.FromArgb(220, 235, 255)
                item.ToolTipText = "Mounted as B:"
            End If
            LvFloppyImages.Items.Add(item)
        Next
        LvFloppyImages.EndUpdate()
    End Sub

    Private Sub RefreshRecentCombo()
        CmbRecentFloppy.Items.Clear()
        For Each r In _recentImages.Take(20)
            CmbRecentFloppy.Items.Add(r)
        Next
        If CmbRecentFloppy.Items.Count > 0 Then CmbRecentFloppy.SelectedIndex = 0
    End Sub

    Private Sub RefreshQuickAccess()
        PanelQuickAccess.Controls.Clear()
        For Each path In _recentImages.Take(5)
            Dim p = path  ' capture for lambda
            Dim btn As New Button()
            btn.Text = Path.GetFileName(p)
            btn.Width = 210
            btn.Height = 30
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            btn.FlatStyle = FlatStyle.Flat
            btn.Cursor = Cursors.Hand
            btn.Tag = p
            ToolTip1.SetToolTip(btn, p)
            AddHandler btn.Click, Sub(s, ev)
                                      Dim imgPath = CStr(CType(s, Button).Tag)
                                      AddToRecent(imgPath)
                                      MountImageAs(imgPath, "A")
                                  End Sub
            PanelQuickAccess.Controls.Add(btn)
        Next
    End Sub

    Private Sub UpdateMountedDisplay()
        LblMountedAValue.Text = If(String.IsNullOrEmpty(_mountedA), "(empty)", Path.GetFileName(_mountedA))
        LblMountedAValue.ForeColor = If(String.IsNullOrEmpty(_mountedA), System.Drawing.Color.Gray, System.Drawing.Color.DarkGreen)
        LblMountedBValue.Text = If(String.IsNullOrEmpty(_mountedB), "(empty)", Path.GetFileName(_mountedB))
        LblMountedBValue.ForeColor = If(String.IsNullOrEmpty(_mountedB), System.Drawing.Color.Gray, System.Drawing.Color.DarkBlue)
        BtnEjectA.Enabled = Not String.IsNullOrEmpty(_mountedA)
        BtnEjectB.Enabled = Not String.IsNullOrEmpty(_mountedB)
        RefreshFloppyList()
    End Sub

    Private Sub MountImageAs(path As String, drive As String)
        If Not File.Exists(path) Then
            MessageBox.Show("File not found: " & path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If drive = "A" Then _mountedA = path Else _mountedB = path
        Dim img = _floppyImages.Find(Function(x) x.FilePath = path)
        If img IsNot Nothing Then img.LastUsed = DateTime.Now
        UpdateMountedDisplay()
        UpdateStatusBar()
        SaveSettings()
        StatusLabelMain.Text = "Mounted " & Path.GetFileName(path) & " as " & drive & ":"
    End Sub


    ' =========================================================================
    ' CREATE BLANK FLOPPY IMAGE
    ' =========================================================================
    Private Sub ShowCreateImageDialog()
        Using dlg As New CreateImageDialog()
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                Dim destPath = dlg.OutputPath
                Dim sizeBytes = dlg.SizeBytes
                Try
                    CreateBlankFloppyImage(destPath, sizeBytes)
                    AddImageToLibrary(destPath)
                    RefreshFloppyList()
                    SaveSettings()
                    StatusLabelMain.Text = "Created: " & Path.GetFileName(destPath)
                    MessageBox.Show("Blank floppy image created:" & vbCrLf & destPath,
                                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to create image: " & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub CreateBlankFloppyImage(path As String, sizeBytes As Long)
        Using fs As New FileStream(path, FileMode.Create, FileAccess.Write)
            ' Write a simple FAT12 boot sector for 1.44 MB, or just zeros for other sizes
            Dim buf(sizeBytes - 1) As Byte
            If sizeBytes = 1474560 Then
                ' Minimal FAT12 BPB for 1.44 MB
                buf(0) = &HEB : buf(1) = &H3C : buf(2) = &H90  ' JMP + NOP
                ' OEM name
                Dim oem = System.Text.Encoding.ASCII.GetBytes("MSDOS5.0")
                Array.Copy(oem, 0, buf, 3, 8)
                buf(11) = 0 : buf(12) = 2   ' bytes per sector = 512
                buf(13) = 1                  ' sectors per cluster
                buf(14) = 1 : buf(15) = 0   ' reserved sectors
                buf(16) = 2                  ' number of FATs
                buf(17) = 224 : buf(18) = 0 ' root entries
                buf(19) = 64 : buf(20) = 11 ' total sectors (2880)
                buf(21) = &HF0              ' media descriptor
                buf(22) = 9 : buf(23) = 0   ' sectors per FAT
                buf(24) = 18 : buf(25) = 0  ' sectors per track
                buf(26) = 2 : buf(27) = 0   ' number of heads
                buf(510) = &H55 : buf(511) = &HAA ' boot signature
                ' FAT1 at sector 1
                buf(512) = &HF0 : buf(513) = &HFF : buf(514) = &HFF
                ' FAT2 at sector 10
                buf(512 + 9 * 512) = &HF0
                buf(512 + 9 * 512 + 1) = &HFF
                buf(512 + 9 * 512 + 2) = &HFF
            End If
            fs.Write(buf, 0, buf.Length)
        End Using
    End Sub

    ' ToolTip component (needed for quick-access buttons)
    Private WithEvents ToolTip1 As New System.Windows.Forms.ToolTip()

End Class

