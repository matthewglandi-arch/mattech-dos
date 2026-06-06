<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        ' ── Top-level containers ──────────────────────────────────────────────
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.TabLaunch = New System.Windows.Forms.TabPage()
        Me.TabFloppy = New System.Windows.Forms.TabPage()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.TabAbout = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDOSBox = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDriveA = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDriveB = New System.Windows.Forms.ToolStripStatusLabel()

        ' ── Launch Tab controls ───────────────────────────────────────────────
        Me.PanelLaunchMain = New System.Windows.Forms.Panel()
        Me.BtnLaunchDOSBox = New System.Windows.Forms.Button()
        Me.BtnQuickLaunchFloppy = New System.Windows.Forms.Button()
        Me.GrpRecentFloppy = New System.Windows.Forms.GroupBox()
        Me.CmbRecentFloppy = New System.Windows.Forms.ComboBox()
        Me.BtnLaunchWithRecent = New System.Windows.Forms.Button()
        Me.ChkMountOnStart = New System.Windows.Forms.CheckBox()
        Me.GrpDOSBoxPath = New System.Windows.Forms.GroupBox()
        Me.TxtDOSBoxPath = New System.Windows.Forms.TextBox()
        Me.BtnBrowseDOSBox = New System.Windows.Forms.Button()
        Me.LblDOSBoxStatus = New System.Windows.Forms.Label()
        Me.PicDOSBoxStatus = New System.Windows.Forms.PictureBox()

        ' ── Floppy Tab controls ───────────────────────────────────────────────
        Me.SplitFloppy = New System.Windows.Forms.SplitContainer()
        Me.PanelFloppyLeft = New System.Windows.Forms.Panel()
        Me.LvFloppyImages = New System.Windows.Forms.ListView()
        Me.ColName = New System.Windows.Forms.ColumnHeader()
        Me.ColSize = New System.Windows.Forms.ColumnHeader()
        Me.ColPath = New System.Windows.Forms.ColumnHeader()
        Me.ColLastUsed = New System.Windows.Forms.ColumnHeader()
        Me.ToolStripFloppy = New System.Windows.Forms.ToolStrip()
        Me.BtnAddImages = New System.Windows.Forms.ToolStripButton()
        Me.BtnRemoveImage = New System.Windows.Forms.ToolStripButton()
        Me.Sep1Floppy = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnMountA = New System.Windows.Forms.ToolStripButton()
        Me.BtnMountB = New System.Windows.Forms.ToolStripButton()
        Me.BtnEject = New System.Windows.Forms.ToolStripButton()
        Me.Sep2Floppy = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCreateImage = New System.Windows.Forms.ToolStripButton()
        Me.BtnOpenLibFolder = New System.Windows.Forms.ToolStripButton()
        Me.CtxFloppy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CtxMountA = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxMountB = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CtxOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CtxRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelFloppyRight = New System.Windows.Forms.Panel()
        Me.GrpQuickAccess = New System.Windows.Forms.GroupBox()
        Me.PanelQuickAccess = New System.Windows.Forms.FlowLayoutPanel()
        Me.GrpMounted = New System.Windows.Forms.GroupBox()
        Me.LblMountedA = New System.Windows.Forms.Label()
        Me.LblMountedAValue = New System.Windows.Forms.Label()
        Me.LblMountedB = New System.Windows.Forms.Label()
        Me.LblMountedBValue = New System.Windows.Forms.Label()
        Me.BtnEjectA = New System.Windows.Forms.Button()
        Me.BtnEjectB = New System.Windows.Forms.Button()
        Me.LblLibraryPath = New System.Windows.Forms.Label()
        Me.TxtLibraryPath = New System.Windows.Forms.TextBox()
        Me.BtnBrowseLibrary = New System.Windows.Forms.Button()

        ' ── Settings Tab controls ─────────────────────────────────────────────
        Me.PanelSettings = New System.Windows.Forms.Panel()
        Me.GrpSettingsDOSBox = New System.Windows.Forms.GroupBox()
        Me.LblSettingsDOSBoxExe = New System.Windows.Forms.Label()
        Me.TxtSettingsDOSBoxExe = New System.Windows.Forms.TextBox()
        Me.BtnSettingsBrowseDOSBox = New System.Windows.Forms.Button()
        Me.LblSettingsConfig = New System.Windows.Forms.Label()
        Me.TxtSettingsConfig = New System.Windows.Forms.TextBox()
        Me.BtnSettingsBrowseConfig = New System.Windows.Forms.Button()
        Me.BtnEditConfig = New System.Windows.Forms.Button()
        Me.GrpSettingsPerf = New System.Windows.Forms.GroupBox()
        Me.LblCycles = New System.Windows.Forms.Label()
        Me.TxtCycles = New System.Windows.Forms.TextBox()
        Me.LblMemory = New System.Windows.Forms.Label()
        Me.CmbMemory = New System.Windows.Forms.ComboBox()
        Me.ChkFullscreen = New System.Windows.Forms.CheckBox()
        Me.GrpSettingsLibrary = New System.Windows.Forms.GroupBox()
        Me.LblSettingsLibrary = New System.Windows.Forms.Label()
        Me.TxtSettingsLibrary = New System.Windows.Forms.TextBox()
        Me.BtnSettingsBrowseLibrary = New System.Windows.Forms.Button()
        Me.BtnSaveSettings = New System.Windows.Forms.Button()
        Me.BtnResetSettings = New System.Windows.Forms.Button()

        ' ── About Tab controls ────────────────────────────────────────────────
        Me.PanelAbout = New System.Windows.Forms.Panel()
        Me.LblAboutTitle = New System.Windows.Forms.Label()
        Me.LblAboutVersion = New System.Windows.Forms.Label()
        Me.LblAboutDesc = New System.Windows.Forms.Label()
        Me.LblAboutFeatures = New System.Windows.Forms.Label()
        Me.LblAboutCopyright = New System.Windows.Forms.Label()

        ' ── Timer ─────────────────────────────────────────────────────────────
        Me.TimerStatus = New System.Windows.Forms.Timer(Me.components)

        ' ══════════════════════════════════════════════════════════════════════
        ' BEGIN SUSPEND LAYOUT
        ' ══════════════════════════════════════════════════════════════════════
        Me.MainTabControl.SuspendLayout()
        Me.TabLaunch.SuspendLayout()
        Me.TabFloppy.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.TabAbout.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelLaunchMain.SuspendLayout()
        Me.GrpRecentFloppy.SuspendLayout()
        Me.GrpDOSBoxPath.SuspendLayout()
        CType(Me.PicDOSBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitFloppy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitFloppy.SuspendLayout()
        Me.PanelFloppyLeft.SuspendLayout()
        Me.ToolStripFloppy.SuspendLayout()
        Me.CtxFloppy.SuspendLayout()
        Me.PanelFloppyRight.SuspendLayout()
        Me.GrpQuickAccess.SuspendLayout()
        Me.GrpMounted.SuspendLayout()
        Me.PanelSettings.SuspendLayout()
        Me.GrpSettingsDOSBox.SuspendLayout()
        Me.GrpSettingsPerf.SuspendLayout()
        Me.GrpSettingsLibrary.SuspendLayout()
        Me.PanelAbout.SuspendLayout()
        Me.SuspendLayout()

        ' ══════════════════════════════════════════════════════════════════════
        ' STATUS STRIP
        ' ══════════════════════════════════════════════════════════════════════
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.StatusLabelMain, Me.StatusLabelDOSBox, Me.StatusLabelDriveA, Me.StatusLabelDriveB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"

        Me.StatusLabelMain.Name = "StatusLabelMain"
        Me.StatusLabelMain.Size = New System.Drawing.Size(39, 17)
        Me.StatusLabelMain.Text = "Ready"
        Me.StatusLabelMain.Spring = True
        Me.StatusLabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        Me.StatusLabelDOSBox.Name = "StatusLabelDOSBox"
        Me.StatusLabelDOSBox.Size = New System.Drawing.Size(120, 17)
        Me.StatusLabelDOSBox.Text = "DOSBox: Not Running"
        Me.StatusLabelDOSBox.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left

        Me.StatusLabelDriveA.Name = "StatusLabelDriveA"
        Me.StatusLabelDriveA.Size = New System.Drawing.Size(80, 17)
        Me.StatusLabelDriveA.Text = "A: (empty)"
        Me.StatusLabelDriveA.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left

        Me.StatusLabelDriveB.Name = "StatusLabelDriveB"
        Me.StatusLabelDriveB.Size = New System.Drawing.Size(80, 17)
        Me.StatusLabelDriveB.Text = "B: (empty)"
        Me.StatusLabelDriveB.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left

        ' ══════════════════════════════════════════════════════════════════════
        ' MAIN TAB CONTROL
        ' ══════════════════════════════════════════════════════════════════════
        Me.MainTabControl.Controls.Add(Me.TabLaunch)
        Me.MainTabControl.Controls.Add(Me.TabFloppy)
        Me.MainTabControl.Controls.Add(Me.TabSettings)
        Me.MainTabControl.Controls.Add(Me.TabAbout)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(884, 539)
        Me.MainTabControl.TabIndex = 1

        ' ══════════════════════════════════════════════════════════════════════
        ' LAUNCH TAB
        ' ══════════════════════════════════════════════════════════════════════
        Me.TabLaunch.Controls.Add(Me.PanelLaunchMain)
        Me.TabLaunch.Location = New System.Drawing.Point(4, 26)
        Me.TabLaunch.Name = "TabLaunch"
        Me.TabLaunch.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLaunch.Size = New System.Drawing.Size(876, 509)
        Me.TabLaunch.TabIndex = 0
        Me.TabLaunch.Text = "  ▶  Launch  "
        Me.TabLaunch.UseVisualStyleBackColor = True

        ' PanelLaunchMain
        Me.PanelLaunchMain.Controls.Add(Me.BtnLaunchDOSBox)
        Me.PanelLaunchMain.Controls.Add(Me.BtnQuickLaunchFloppy)
        Me.PanelLaunchMain.Controls.Add(Me.GrpRecentFloppy)
        Me.PanelLaunchMain.Controls.Add(Me.ChkMountOnStart)
        Me.PanelLaunchMain.Controls.Add(Me.GrpDOSBoxPath)
        Me.PanelLaunchMain.Controls.Add(Me.LblDOSBoxStatus)
        Me.PanelLaunchMain.Controls.Add(Me.PicDOSBoxStatus)
        Me.PanelLaunchMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLaunchMain.Location = New System.Drawing.Point(3, 3)
        Me.PanelLaunchMain.Name = "PanelLaunchMain"
        Me.PanelLaunchMain.Size = New System.Drawing.Size(870, 503)
        Me.PanelLaunchMain.TabIndex = 0

        ' BtnLaunchDOSBox
        Me.BtnLaunchDOSBox.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaunchDOSBox.Location = New System.Drawing.Point(20, 20)
        Me.BtnLaunchDOSBox.Name = "BtnLaunchDOSBox"
        Me.BtnLaunchDOSBox.Size = New System.Drawing.Size(380, 70)
        Me.BtnLaunchDOSBox.TabIndex = 0
        Me.BtnLaunchDOSBox.Text = "▶  Launch DOSBox"
        Me.BtnLaunchDOSBox.UseVisualStyleBackColor = False
        Me.BtnLaunchDOSBox.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.BtnLaunchDOSBox.ForeColor = System.Drawing.Color.White
        Me.BtnLaunchDOSBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaunchDOSBox.FlatAppearance.BorderSize = 0
        Me.BtnLaunchDOSBox.Cursor = System.Windows.Forms.Cursors.Hand

        ' BtnQuickLaunchFloppy
        Me.BtnQuickLaunchFloppy.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuickLaunchFloppy.Location = New System.Drawing.Point(420, 20)
        Me.BtnQuickLaunchFloppy.Name = "BtnQuickLaunchFloppy"
        Me.BtnQuickLaunchFloppy.Size = New System.Drawing.Size(380, 70)
        Me.BtnQuickLaunchFloppy.TabIndex = 1
        Me.BtnQuickLaunchFloppy.Text = "💾  Quick Launch with Floppy"
        Me.BtnQuickLaunchFloppy.UseVisualStyleBackColor = False
        Me.BtnQuickLaunchFloppy.BackColor = System.Drawing.Color.FromArgb(16, 137, 62)
        Me.BtnQuickLaunchFloppy.ForeColor = System.Drawing.Color.White
        Me.BtnQuickLaunchFloppy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuickLaunchFloppy.FlatAppearance.BorderSize = 0
        Me.BtnQuickLaunchFloppy.Cursor = System.Windows.Forms.Cursors.Hand

        ' GrpRecentFloppy
        Me.GrpRecentFloppy.Controls.Add(Me.CmbRecentFloppy)
        Me.GrpRecentFloppy.Controls.Add(Me.BtnLaunchWithRecent)
        Me.GrpRecentFloppy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpRecentFloppy.Location = New System.Drawing.Point(20, 110)
        Me.GrpRecentFloppy.Name = "GrpRecentFloppy"
        Me.GrpRecentFloppy.Size = New System.Drawing.Size(780, 80)
        Me.GrpRecentFloppy.TabIndex = 2
        Me.GrpRecentFloppy.TabStop = False
        Me.GrpRecentFloppy.Text = "💾  Recent Floppy Images"

        ' CmbRecentFloppy
        Me.CmbRecentFloppy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRecentFloppy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRecentFloppy.FormattingEnabled = True
        Me.CmbRecentFloppy.Location = New System.Drawing.Point(12, 30)
        Me.CmbRecentFloppy.Name = "CmbRecentFloppy"
        Me.CmbRecentFloppy.Size = New System.Drawing.Size(620, 23)
        Me.CmbRecentFloppy.TabIndex = 0

        ' BtnLaunchWithRecent
        Me.BtnLaunchWithRecent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaunchWithRecent.Location = New System.Drawing.Point(645, 28)
        Me.BtnLaunchWithRecent.Name = "BtnLaunchWithRecent"
        Me.BtnLaunchWithRecent.Size = New System.Drawing.Size(120, 27)
        Me.BtnLaunchWithRecent.TabIndex = 1
        Me.BtnLaunchWithRecent.Text = "▶  Launch"
        Me.BtnLaunchWithRecent.UseVisualStyleBackColor = True

        ' ChkMountOnStart
        Me.ChkMountOnStart.AutoSize = True
        Me.ChkMountOnStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMountOnStart.Location = New System.Drawing.Point(20, 205)
        Me.ChkMountOnStart.Name = "ChkMountOnStart"
        Me.ChkMountOnStart.Size = New System.Drawing.Size(220, 21)
        Me.ChkMountOnStart.TabIndex = 3
        Me.ChkMountOnStart.Text = "Mount selected floppy on start"
        Me.ChkMountOnStart.UseVisualStyleBackColor = True

        ' GrpDOSBoxPath
        Me.GrpDOSBoxPath.Controls.Add(Me.TxtDOSBoxPath)
        Me.GrpDOSBoxPath.Controls.Add(Me.BtnBrowseDOSBox)
        Me.GrpDOSBoxPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDOSBoxPath.Location = New System.Drawing.Point(20, 240)
        Me.GrpDOSBoxPath.Name = "GrpDOSBoxPath"
        Me.GrpDOSBoxPath.Size = New System.Drawing.Size(780, 70)
        Me.GrpDOSBoxPath.TabIndex = 4
        Me.GrpDOSBoxPath.TabStop = False
        Me.GrpDOSBoxPath.Text = "⚙  DOSBox Executable"

        ' TxtDOSBoxPath
        Me.TxtDOSBoxPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOSBoxPath.Location = New System.Drawing.Point(12, 30)
        Me.TxtDOSBoxPath.Name = "TxtDOSBoxPath"
        Me.TxtDOSBoxPath.Size = New System.Drawing.Size(640, 23)
        Me.TxtDOSBoxPath.TabIndex = 0

        ' BtnBrowseDOSBox
        Me.BtnBrowseDOSBox.Location = New System.Drawing.Point(665, 28)
        Me.BtnBrowseDOSBox.Name = "BtnBrowseDOSBox"
        Me.BtnBrowseDOSBox.Size = New System.Drawing.Size(100, 27)
        Me.BtnBrowseDOSBox.TabIndex = 1
        Me.BtnBrowseDOSBox.Text = "📂  Browse..."
        Me.BtnBrowseDOSBox.UseVisualStyleBackColor = True

        ' PicDOSBoxStatus
        Me.PicDOSBoxStatus.Location = New System.Drawing.Point(20, 330)
        Me.PicDOSBoxStatus.Name = "PicDOSBoxStatus"
        Me.PicDOSBoxStatus.Size = New System.Drawing.Size(16, 16)
        Me.PicDOSBoxStatus.TabIndex = 5
        Me.PicDOSBoxStatus.TabStop = False

        ' LblDOSBoxStatus
        Me.LblDOSBoxStatus.AutoSize = True
        Me.LblDOSBoxStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDOSBoxStatus.Location = New System.Drawing.Point(42, 330)
        Me.LblDOSBoxStatus.Name = "LblDOSBoxStatus"
        Me.LblDOSBoxStatus.Size = New System.Drawing.Size(150, 17)
        Me.LblDOSBoxStatus.TabIndex = 6
        Me.LblDOSBoxStatus.Text = "DOSBox: Not Running"

        ' ══════════════════════════════════════════════════════════════════════
        ' FLOPPY TAB
        ' ══════════════════════════════════════════════════════════════════════
        Me.TabFloppy.Controls.Add(Me.SplitFloppy)
        Me.TabFloppy.Location = New System.Drawing.Point(4, 26)
        Me.TabFloppy.Name = "TabFloppy"
        Me.TabFloppy.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFloppy.Size = New System.Drawing.Size(876, 509)
        Me.TabFloppy.TabIndex = 1
        Me.TabFloppy.Text = "  💾  Floppy Images  "
        Me.TabFloppy.UseVisualStyleBackColor = True

        ' SplitFloppy
        Me.SplitFloppy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitFloppy.Location = New System.Drawing.Point(3, 3)
        Me.SplitFloppy.Name = "SplitFloppy"
        Me.SplitFloppy.Panel1.Controls.Add(Me.PanelFloppyLeft)
        Me.SplitFloppy.Panel2.Controls.Add(Me.PanelFloppyRight)
        Me.SplitFloppy.Size = New System.Drawing.Size(870, 503)
        Me.SplitFloppy.SplitterDistance = 620
        Me.SplitFloppy.TabIndex = 0

        ' PanelFloppyLeft
        Me.PanelFloppyLeft.Controls.Add(Me.LvFloppyImages)
        Me.PanelFloppyLeft.Controls.Add(Me.ToolStripFloppy)
        Me.PanelFloppyLeft.Controls.Add(Me.LblLibraryPath)
        Me.PanelFloppyLeft.Controls.Add(Me.TxtLibraryPath)
        Me.PanelFloppyLeft.Controls.Add(Me.BtnBrowseLibrary)
        Me.PanelFloppyLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFloppyLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelFloppyLeft.Name = "PanelFloppyLeft"
        Me.PanelFloppyLeft.Size = New System.Drawing.Size(620, 503)
        Me.PanelFloppyLeft.TabIndex = 0

        ' ToolStripFloppy
        Me.ToolStripFloppy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.BtnAddImages, Me.BtnRemoveImage, Me.Sep1Floppy,
            Me.BtnMountA, Me.BtnMountB, Me.BtnEject, Me.Sep2Floppy,
            Me.BtnCreateImage, Me.BtnOpenLibFolder})
        Me.ToolStripFloppy.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripFloppy.Name = "ToolStripFloppy"
        Me.ToolStripFloppy.Size = New System.Drawing.Size(620, 25)
        Me.ToolStripFloppy.TabIndex = 0
        Me.ToolStripFloppy.Text = "ToolStripFloppy"

        Me.BtnAddImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnAddImages.Name = "BtnAddImages"
        Me.BtnAddImages.Size = New System.Drawing.Size(80, 22)
        Me.BtnAddImages.Text = "➕ Add Image(s)"

        Me.BtnRemoveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnRemoveImage.Name = "BtnRemoveImage"
        Me.BtnRemoveImage.Size = New System.Drawing.Size(65, 22)
        Me.BtnRemoveImage.Text = "✖ Remove"

        Me.Sep1Floppy.Name = "Sep1Floppy"
        Me.Sep1Floppy.Size = New System.Drawing.Size(6, 25)

        Me.BtnMountA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnMountA.Name = "BtnMountA"
        Me.BtnMountA.Size = New System.Drawing.Size(75, 22)
        Me.BtnMountA.Text = "💾 Mount A:"

        Me.BtnMountB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnMountB.Name = "BtnMountB"
        Me.BtnMountB.Size = New System.Drawing.Size(75, 22)
        Me.BtnMountB.Text = "💾 Mount B:"

        Me.BtnEject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnEject.Name = "BtnEject"
        Me.BtnEject.Size = New System.Drawing.Size(55, 22)
        Me.BtnEject.Text = "⏏ Eject"

        Me.Sep2Floppy.Name = "Sep2Floppy"
        Me.Sep2Floppy.Size = New System.Drawing.Size(6, 25)

        Me.BtnCreateImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnCreateImage.Name = "BtnCreateImage"
        Me.BtnCreateImage.Size = New System.Drawing.Size(100, 22)
        Me.BtnCreateImage.Text = "🆕 Create Image"

        Me.BtnOpenLibFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnOpenLibFolder.Name = "BtnOpenLibFolder"
        Me.BtnOpenLibFolder.Size = New System.Drawing.Size(90, 22)
        Me.BtnOpenLibFolder.Text = "📂 Open Folder"

        ' LvFloppyImages
        Me.LvFloppyImages.AllowDrop = True
        Me.LvFloppyImages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {
            Me.ColName, Me.ColSize, Me.ColPath, Me.ColLastUsed})
        Me.LvFloppyImages.ContextMenuStrip = Me.CtxFloppy
        Me.LvFloppyImages.FullRowSelect = True
        Me.LvFloppyImages.GridLines = True
        Me.LvFloppyImages.HideSelection = False
        Me.LvFloppyImages.Location = New System.Drawing.Point(0, 25)
        Me.LvFloppyImages.MultiSelect = True
        Me.LvFloppyImages.Name = "LvFloppyImages"
        Me.LvFloppyImages.Size = New System.Drawing.Size(620, 440)
        Me.LvFloppyImages.TabIndex = 1
        Me.LvFloppyImages.UseCompatibleStateImageBehavior = False
        Me.LvFloppyImages.View = System.Windows.Forms.View.Details
        Me.LvFloppyImages.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.ColName.Text = "Name"
        Me.ColName.Width = 160
        Me.ColSize.Text = "Size"
        Me.ColSize.Width = 70
        Me.ColPath.Text = "Path"
        Me.ColPath.Width = 260
        Me.ColLastUsed.Text = "Last Used"
        Me.ColLastUsed.Width = 120

        ' LblLibraryPath
        Me.LblLibraryPath.AutoSize = True
        Me.LblLibraryPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibraryPath.Location = New System.Drawing.Point(0, 472)
        Me.LblLibraryPath.Name = "LblLibraryPath"
        Me.LblLibraryPath.Size = New System.Drawing.Size(80, 15)
        Me.LblLibraryPath.Text = "Library Folder:"

        ' TxtLibraryPath
        Me.TxtLibraryPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLibraryPath.Location = New System.Drawing.Point(88, 469)
        Me.TxtLibraryPath.Name = "TxtLibraryPath"
        Me.TxtLibraryPath.ReadOnly = True
        Me.TxtLibraryPath.Size = New System.Drawing.Size(420, 23)
        Me.TxtLibraryPath.TabIndex = 2

        ' BtnBrowseLibrary
        Me.BtnBrowseLibrary.Location = New System.Drawing.Point(515, 467)
        Me.BtnBrowseLibrary.Name = "BtnBrowseLibrary"
        Me.BtnBrowseLibrary.Size = New System.Drawing.Size(100, 27)
        Me.BtnBrowseLibrary.TabIndex = 3
        Me.BtnBrowseLibrary.Text = "📂  Browse..."
        Me.BtnBrowseLibrary.UseVisualStyleBackColor = True

        ' Context Menu
        Me.CtxFloppy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.CtxMountA, Me.CtxMountB, Me.CtxSep1, Me.CtxOpenFolder, Me.CtxSep2, Me.CtxRemove})
        Me.CtxFloppy.Name = "CtxFloppy"
        Me.CtxFloppy.Size = New System.Drawing.Size(180, 120)

        Me.CtxMountA.Name = "CtxMountA"
        Me.CtxMountA.Size = New System.Drawing.Size(179, 22)
        Me.CtxMountA.Text = "💾  Mount as A:"

        Me.CtxMountB.Name = "CtxMountB"
        Me.CtxMountB.Size = New System.Drawing.Size(179, 22)
        Me.CtxMountB.Text = "💾  Mount as B:"

        Me.CtxSep1.Name = "CtxSep1"
        Me.CtxSep1.Size = New System.Drawing.Size(176, 6)

        Me.CtxOpenFolder.Name = "CtxOpenFolder"
        Me.CtxOpenFolder.Size = New System.Drawing.Size(179, 22)
        Me.CtxOpenFolder.Text = "📂  Open containing folder"

        Me.CtxSep2.Name = "CtxSep2"
        Me.CtxSep2.Size = New System.Drawing.Size(176, 6)

        Me.CtxRemove.Name = "CtxRemove"
        Me.CtxRemove.Size = New System.Drawing.Size(179, 22)
        Me.CtxRemove.Text = "✖  Remove from list"

        ' PanelFloppyRight
        Me.PanelFloppyRight.Controls.Add(Me.GrpQuickAccess)
        Me.PanelFloppyRight.Controls.Add(Me.GrpMounted)
        Me.PanelFloppyRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFloppyRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelFloppyRight.Name = "PanelFloppyRight"
        Me.PanelFloppyRight.Size = New System.Drawing.Size(246, 503)
        Me.PanelFloppyRight.TabIndex = 0

        ' GrpMounted
        Me.GrpMounted.Controls.Add(Me.LblMountedA)
        Me.GrpMounted.Controls.Add(Me.LblMountedAValue)
        Me.GrpMounted.Controls.Add(Me.BtnEjectA)
        Me.GrpMounted.Controls.Add(Me.LblMountedB)
        Me.GrpMounted.Controls.Add(Me.LblMountedBValue)
        Me.GrpMounted.Controls.Add(Me.BtnEjectB)
        Me.GrpMounted.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMounted.Location = New System.Drawing.Point(5, 5)
        Me.GrpMounted.Name = "GrpMounted"
        Me.GrpMounted.Size = New System.Drawing.Size(236, 140)
        Me.GrpMounted.TabIndex = 0
        Me.GrpMounted.TabStop = False
        Me.GrpMounted.Text = "💿  Currently Mounted"

        Me.LblMountedA.AutoSize = True
        Me.LblMountedA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMountedA.Location = New System.Drawing.Point(10, 25)
        Me.LblMountedA.Name = "LblMountedA"
        Me.LblMountedA.Size = New System.Drawing.Size(20, 15)
        Me.LblMountedA.Text = "A:"

        Me.LblMountedAValue.AutoSize = False
        Me.LblMountedAValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMountedAValue.ForeColor = System.Drawing.Color.Gray
        Me.LblMountedAValue.Location = New System.Drawing.Point(35, 25)
        Me.LblMountedAValue.Name = "LblMountedAValue"
        Me.LblMountedAValue.Size = New System.Drawing.Size(155, 30)
        Me.LblMountedAValue.Text = "(empty)"

        Me.BtnEjectA.Location = New System.Drawing.Point(10, 58)
        Me.BtnEjectA.Name = "BtnEjectA"
        Me.BtnEjectA.Size = New System.Drawing.Size(80, 24)
        Me.BtnEjectA.TabIndex = 0
        Me.BtnEjectA.Text = "⏏ Eject A:"
        Me.BtnEjectA.UseVisualStyleBackColor = True
        Me.BtnEjectA.Enabled = False

        Me.LblMountedB.AutoSize = True
        Me.LblMountedB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMountedB.Location = New System.Drawing.Point(10, 90)
        Me.LblMountedB.Name = "LblMountedB"
        Me.LblMountedB.Size = New System.Drawing.Size(20, 15)
        Me.LblMountedB.Text = "B:"

        Me.LblMountedBValue.AutoSize = False
        Me.LblMountedBValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMountedBValue.ForeColor = System.Drawing.Color.Gray
        Me.LblMountedBValue.Location = New System.Drawing.Point(35, 90)
        Me.LblMountedBValue.Name = "LblMountedBValue"
        Me.LblMountedBValue.Size = New System.Drawing.Size(155, 30)
        Me.LblMountedBValue.Text = "(empty)"

        Me.BtnEjectB.Location = New System.Drawing.Point(10, 108)
        Me.BtnEjectB.Name = "BtnEjectB"
        Me.BtnEjectB.Size = New System.Drawing.Size(80, 24)
        Me.BtnEjectB.TabIndex = 1
        Me.BtnEjectB.Text = "⏏ Eject B:"
        Me.BtnEjectB.UseVisualStyleBackColor = True
        Me.BtnEjectB.Enabled = False

        ' GrpQuickAccess
        Me.GrpQuickAccess.Controls.Add(Me.PanelQuickAccess)
        Me.GrpQuickAccess.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpQuickAccess.Location = New System.Drawing.Point(5, 155)
        Me.GrpQuickAccess.Name = "GrpQuickAccess"
        Me.GrpQuickAccess.Size = New System.Drawing.Size(236, 200)
        Me.GrpQuickAccess.TabIndex = 1
        Me.GrpQuickAccess.TabStop = False
        Me.GrpQuickAccess.Text = "⚡  Quick Access (Last 5)"

        Me.PanelQuickAccess.AutoScroll = True
        Me.PanelQuickAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelQuickAccess.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PanelQuickAccess.Location = New System.Drawing.Point(3, 19)
        Me.PanelQuickAccess.Name = "PanelQuickAccess"
        Me.PanelQuickAccess.Size = New System.Drawing.Size(230, 178)
        Me.PanelQuickAccess.TabIndex = 0
        Me.PanelQuickAccess.WrapContents = False

        ' ══════════════════════════════════════════════════════════════════════
        ' SETTINGS TAB
        ' ══════════════════════════════════════════════════════════════════════
        Me.TabSettings.Controls.Add(Me.PanelSettings)
        Me.TabSettings.Location = New System.Drawing.Point(4, 26)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(876, 509)
        Me.TabSettings.TabIndex = 2
        Me.TabSettings.Text = "  ⚙  Settings  "
        Me.TabSettings.UseVisualStyleBackColor = True

        Me.PanelSettings.AutoScroll = True
        Me.PanelSettings.Controls.Add(Me.GrpSettingsDOSBox)
        Me.PanelSettings.Controls.Add(Me.GrpSettingsPerf)
        Me.PanelSettings.Controls.Add(Me.GrpSettingsLibrary)
        Me.PanelSettings.Controls.Add(Me.BtnSaveSettings)
        Me.PanelSettings.Controls.Add(Me.BtnResetSettings)
        Me.PanelSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSettings.Location = New System.Drawing.Point(3, 3)
        Me.PanelSettings.Name = "PanelSettings"
        Me.PanelSettings.Size = New System.Drawing.Size(870, 503)
        Me.PanelSettings.TabIndex = 0

        ' GrpSettingsDOSBox
        Me.GrpSettingsDOSBox.Controls.Add(Me.LblSettingsDOSBoxExe)
        Me.GrpSettingsDOSBox.Controls.Add(Me.TxtSettingsDOSBoxExe)
        Me.GrpSettingsDOSBox.Controls.Add(Me.BtnSettingsBrowseDOSBox)
        Me.GrpSettingsDOSBox.Controls.Add(Me.LblSettingsConfig)
        Me.GrpSettingsDOSBox.Controls.Add(Me.TxtSettingsConfig)
        Me.GrpSettingsDOSBox.Controls.Add(Me.BtnSettingsBrowseConfig)
        Me.GrpSettingsDOSBox.Controls.Add(Me.BtnEditConfig)
        Me.GrpSettingsDOSBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSettingsDOSBox.Location = New System.Drawing.Point(15, 15)
        Me.GrpSettingsDOSBox.Name = "GrpSettingsDOSBox"
        Me.GrpSettingsDOSBox.Size = New System.Drawing.Size(840, 130)
        Me.GrpSettingsDOSBox.TabIndex = 0
        Me.GrpSettingsDOSBox.TabStop = False
        Me.GrpSettingsDOSBox.Text = "⚙  DOSBox Configuration"

        Me.LblSettingsDOSBoxExe.AutoSize = True
        Me.LblSettingsDOSBoxExe.Location = New System.Drawing.Point(10, 28)
        Me.LblSettingsDOSBoxExe.Name = "LblSettingsDOSBoxExe"
        Me.LblSettingsDOSBoxExe.Size = New System.Drawing.Size(110, 15)
        Me.LblSettingsDOSBoxExe.Text = "DOSBox Executable:"

        Me.TxtSettingsDOSBoxExe.Location = New System.Drawing.Point(130, 25)
        Me.TxtSettingsDOSBoxExe.Name = "TxtSettingsDOSBoxExe"
        Me.TxtSettingsDOSBoxExe.Size = New System.Drawing.Size(580, 23)
        Me.TxtSettingsDOSBoxExe.TabIndex = 0

        Me.BtnSettingsBrowseDOSBox.Location = New System.Drawing.Point(720, 23)
        Me.BtnSettingsBrowseDOSBox.Name = "BtnSettingsBrowseDOSBox"
        Me.BtnSettingsBrowseDOSBox.Size = New System.Drawing.Size(100, 27)
        Me.BtnSettingsBrowseDOSBox.TabIndex = 1
        Me.BtnSettingsBrowseDOSBox.Text = "📂  Browse..."
        Me.BtnSettingsBrowseDOSBox.UseVisualStyleBackColor = True

        Me.LblSettingsConfig.AutoSize = True
        Me.LblSettingsConfig.Location = New System.Drawing.Point(10, 68)
        Me.LblSettingsConfig.Name = "LblSettingsConfig"
        Me.LblSettingsConfig.Size = New System.Drawing.Size(110, 15)
        Me.LblSettingsConfig.Text = "DOSBox Config File:"

        Me.TxtSettingsConfig.Location = New System.Drawing.Point(130, 65)
        Me.TxtSettingsConfig.Name = "TxtSettingsConfig"
        Me.TxtSettingsConfig.Size = New System.Drawing.Size(470, 23)
        Me.TxtSettingsConfig.TabIndex = 2

        Me.BtnSettingsBrowseConfig.Location = New System.Drawing.Point(610, 63)
        Me.BtnSettingsBrowseConfig.Name = "BtnSettingsBrowseConfig"
        Me.BtnSettingsBrowseConfig.Size = New System.Drawing.Size(100, 27)
        Me.BtnSettingsBrowseConfig.TabIndex = 3
        Me.BtnSettingsBrowseConfig.Text = "📂  Browse..."
        Me.BtnSettingsBrowseConfig.UseVisualStyleBackColor = True

        Me.BtnEditConfig.Location = New System.Drawing.Point(720, 63)
        Me.BtnEditConfig.Name = "BtnEditConfig"
        Me.BtnEditConfig.Size = New System.Drawing.Size(100, 27)
        Me.BtnEditConfig.TabIndex = 4
        Me.BtnEditConfig.Text = "✏  Edit Config"
        Me.BtnEditConfig.UseVisualStyleBackColor = True

        ' GrpSettingsPerf
        Me.GrpSettingsPerf.Controls.Add(Me.LblCycles)
        Me.GrpSettingsPerf.Controls.Add(Me.TxtCycles)
        Me.GrpSettingsPerf.Controls.Add(Me.LblMemory)
        Me.GrpSettingsPerf.Controls.Add(Me.CmbMemory)
        Me.GrpSettingsPerf.Controls.Add(Me.ChkFullscreen)
        Me.GrpSettingsPerf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSettingsPerf.Location = New System.Drawing.Point(15, 160)
        Me.GrpSettingsPerf.Name = "GrpSettingsPerf"
        Me.GrpSettingsPerf.Size = New System.Drawing.Size(840, 110)
        Me.GrpSettingsPerf.TabIndex = 1
        Me.GrpSettingsPerf.TabStop = False
        Me.GrpSettingsPerf.Text = "🖥  Performance"

        Me.LblCycles.AutoSize = True
        Me.LblCycles.Location = New System.Drawing.Point(10, 30)
        Me.LblCycles.Name = "LblCycles"
        Me.LblCycles.Size = New System.Drawing.Size(70, 15)
        Me.LblCycles.Text = "CPU Cycles:"

        Me.TxtCycles.Location = New System.Drawing.Point(90, 27)
        Me.TxtCycles.Name = "TxtCycles"
        Me.TxtCycles.Size = New System.Drawing.Size(150, 23)
        Me.TxtCycles.TabIndex = 0
        Me.TxtCycles.Text = "auto"

        Me.LblMemory.AutoSize = True
        Me.LblMemory.Location = New System.Drawing.Point(260, 30)
        Me.LblMemory.Name = "LblMemory"
        Me.LblMemory.Size = New System.Drawing.Size(80, 15)
        Me.LblMemory.Text = "Memory (MB):"

        Me.CmbMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMemory.FormattingEnabled = True
        Me.CmbMemory.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "63"})
        Me.CmbMemory.Location = New System.Drawing.Point(350, 27)
        Me.CmbMemory.Name = "CmbMemory"
        Me.CmbMemory.Size = New System.Drawing.Size(80, 23)
        Me.CmbMemory.TabIndex = 1
        Me.CmbMemory.SelectedIndex = 3

        Me.ChkFullscreen.AutoSize = True
        Me.ChkFullscreen.Location = New System.Drawing.Point(10, 65)
        Me.ChkFullscreen.Name = "ChkFullscreen"
        Me.ChkFullscreen.Size = New System.Drawing.Size(130, 19)
        Me.ChkFullscreen.TabIndex = 2
        Me.ChkFullscreen.Text = "Start in Fullscreen"
        Me.ChkFullscreen.UseVisualStyleBackColor = True

        ' GrpSettingsLibrary
        Me.GrpSettingsLibrary.Controls.Add(Me.LblSettingsLibrary)
        Me.GrpSettingsLibrary.Controls.Add(Me.TxtSettingsLibrary)
        Me.GrpSettingsLibrary.Controls.Add(Me.BtnSettingsBrowseLibrary)
        Me.GrpSettingsLibrary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSettingsLibrary.Location = New System.Drawing.Point(15, 285)
        Me.GrpSettingsLibrary.Name = "GrpSettingsLibrary"
        Me.GrpSettingsLibrary.Size = New System.Drawing.Size(840, 75)
        Me.GrpSettingsLibrary.TabIndex = 2
        Me.GrpSettingsLibrary.TabStop = False
        Me.GrpSettingsLibrary.Text = "💾  Floppy Library"

        Me.LblSettingsLibrary.AutoSize = True
        Me.LblSettingsLibrary.Location = New System.Drawing.Point(10, 30)
        Me.LblSettingsLibrary.Name = "LblSettingsLibrary"
        Me.LblSettingsLibrary.Size = New System.Drawing.Size(110, 15)
        Me.LblSettingsLibrary.Text = "Default Library Folder:"

        Me.TxtSettingsLibrary.Location = New System.Drawing.Point(130, 27)
        Me.TxtSettingsLibrary.Name = "TxtSettingsLibrary"
        Me.TxtSettingsLibrary.Size = New System.Drawing.Size(580, 23)
        Me.TxtSettingsLibrary.TabIndex = 0

        Me.BtnSettingsBrowseLibrary.Location = New System.Drawing.Point(720, 25)
        Me.BtnSettingsBrowseLibrary.Name = "BtnSettingsBrowseLibrary"
        Me.BtnSettingsBrowseLibrary.Size = New System.Drawing.Size(100, 27)
        Me.BtnSettingsBrowseLibrary.TabIndex = 1
        Me.BtnSettingsBrowseLibrary.Text = "📂  Browse..."
        Me.BtnSettingsBrowseLibrary.UseVisualStyleBackColor = True

        ' Save / Reset buttons
        Me.BtnSaveSettings.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveSettings.Location = New System.Drawing.Point(15, 375)
        Me.BtnSaveSettings.Name = "BtnSaveSettings"
        Me.BtnSaveSettings.Size = New System.Drawing.Size(150, 35)
        Me.BtnSaveSettings.TabIndex = 3
        Me.BtnSaveSettings.Text = "💾  Save Settings"
        Me.BtnSaveSettings.UseVisualStyleBackColor = True

        Me.BtnResetSettings.Location = New System.Drawing.Point(175, 375)
        Me.BtnResetSettings.Name = "BtnResetSettings"
        Me.BtnResetSettings.Size = New System.Drawing.Size(130, 35)
        Me.BtnResetSettings.TabIndex = 4
        Me.BtnResetSettings.Text = "↺  Reset Defaults"
        Me.BtnResetSettings.UseVisualStyleBackColor = True

        ' ══════════════════════════════════════════════════════════════════════
        ' ABOUT TAB
        ' ══════════════════════════════════════════════════════════════════════
        Me.TabAbout.Controls.Add(Me.PanelAbout)
        Me.TabAbout.Location = New System.Drawing.Point(4, 26)
        Me.TabAbout.Name = "TabAbout"
        Me.TabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAbout.Size = New System.Drawing.Size(876, 509)
        Me.TabAbout.TabIndex = 3
        Me.TabAbout.Text = "  ℹ  About  "
        Me.TabAbout.UseVisualStyleBackColor = True

        Me.PanelAbout.Controls.Add(Me.LblAboutTitle)
        Me.PanelAbout.Controls.Add(Me.LblAboutVersion)
        Me.PanelAbout.Controls.Add(Me.LblAboutDesc)
        Me.PanelAbout.Controls.Add(Me.LblAboutFeatures)
        Me.PanelAbout.Controls.Add(Me.LblAboutCopyright)
        Me.PanelAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAbout.Location = New System.Drawing.Point(3, 3)
        Me.PanelAbout.Name = "PanelAbout"
        Me.PanelAbout.Size = New System.Drawing.Size(870, 503)
        Me.PanelAbout.TabIndex = 0

        Me.LblAboutTitle.AutoSize = True
        Me.LblAboutTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAboutTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.LblAboutTitle.Location = New System.Drawing.Point(30, 30)
        Me.LblAboutTitle.Name = "LblAboutTitle"
        Me.LblAboutTitle.Size = New System.Drawing.Size(300, 45)
        Me.LblAboutTitle.TabIndex = 0
        Me.LblAboutTitle.Text = "💾 DOSBox Frontend"

        Me.LblAboutVersion.AutoSize = True
        Me.LblAboutVersion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAboutVersion.ForeColor = System.Drawing.Color.Gray
        Me.LblAboutVersion.Location = New System.Drawing.Point(30, 80)
        Me.LblAboutVersion.Name = "LblAboutVersion"
        Me.LblAboutVersion.Size = New System.Drawing.Size(100, 20)
        Me.LblAboutVersion.TabIndex = 1
        Me.LblAboutVersion.Text = "Version 1.0.0"

        Me.LblAboutDesc.AutoSize = True
        Me.LblAboutDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAboutDesc.Location = New System.Drawing.Point(30, 120)
        Me.LblAboutDesc.Name = "LblAboutDesc"
        Me.LblAboutDesc.Size = New System.Drawing.Size(500, 19)
        Me.LblAboutDesc.TabIndex = 2
        Me.LblAboutDesc.Text = "A feature-rich frontend for DOSBox with floppy disk image management."

        Me.LblAboutFeatures.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAboutFeatures.Location = New System.Drawing.Point(30, 160)
        Me.LblAboutFeatures.Name = "LblAboutFeatures"
        Me.LblAboutFeatures.Size = New System.Drawing.Size(600, 200)
        Me.LblAboutFeatures.TabIndex = 3
        Me.LblAboutFeatures.Text = "Features:" & vbCrLf &
            "  • Launch DOSBox with one click" & vbCrLf &
            "  • Manage a library of floppy disk images (.img, .ima, .vfd, .flp)" & vbCrLf &
            "  • Mount floppy images as drive A: or B: in DOSBox" & vbCrLf &
            "  • Drag-and-drop floppy images onto the list" & vbCrLf &
            "  • Quick Access panel for the 5 most recently used images" & vbCrLf &
            "  • Create new blank floppy images" & vbCrLf &
            "  • Persistent settings and library saved to AppData" & vbCrLf &
            "  • DOSBox process monitoring"

        Me.LblAboutCopyright.AutoSize = True
        Me.LblAboutCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAboutCopyright.ForeColor = System.Drawing.Color.Gray
        Me.LblAboutCopyright.Location = New System.Drawing.Point(30, 380)
        Me.LblAboutCopyright.Name = "LblAboutCopyright"
        Me.LblAboutCopyright.Size = New System.Drawing.Size(200, 15)
        Me.LblAboutCopyright.TabIndex = 4
        Me.LblAboutCopyright.Text = "Built with VB.NET / .NET Framework 4.7.2"

        ' ══════════════════════════════════════════════════════════════════════
        ' TIMER
        ' ══════════════════════════════════════════════════════════════════════
        Me.TimerStatus.Interval = 2000
        Me.TimerStatus.Enabled = True

        ' ══════════════════════════════════════════════════════════════════════
        ' MAIN FORM
        ' ══════════════════════════════════════════════════════════════════════
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💾 DOSBox Frontend"

        ' ══════════════════════════════════════════════════════════════════════
        ' RESUME LAYOUT
        ' ══════════════════════════════════════════════════════════════════════
        Me.MainTabControl.ResumeLayout(False)
        Me.TabLaunch.ResumeLayout(False)
        Me.TabFloppy.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.TabAbout.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelLaunchMain.ResumeLayout(False)
        Me.PanelLaunchMain.PerformLayout()
        Me.GrpRecentFloppy.ResumeLayout(False)
        Me.GrpDOSBoxPath.ResumeLayout(False)
        Me.GrpDOSBoxPath.PerformLayout()
        CType(Me.PicDOSBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitFloppy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitFloppy.ResumeLayout(False)
        Me.PanelFloppyLeft.ResumeLayout(False)
        Me.PanelFloppyLeft.PerformLayout()
        Me.ToolStripFloppy.ResumeLayout(False)
        Me.ToolStripFloppy.PerformLayout()
        Me.CtxFloppy.ResumeLayout(False)
        Me.PanelFloppyRight.ResumeLayout(False)
        Me.GrpQuickAccess.ResumeLayout(False)
        Me.GrpMounted.ResumeLayout(False)
        Me.GrpMounted.PerformLayout()
        Me.PanelSettings.ResumeLayout(False)
        Me.GrpSettingsDOSBox.ResumeLayout(False)
        Me.GrpSettingsDOSBox.PerformLayout()
        Me.GrpSettingsPerf.ResumeLayout(False)
        Me.GrpSettingsPerf.PerformLayout()
        Me.GrpSettingsLibrary.ResumeLayout(False)
        Me.GrpSettingsLibrary.PerformLayout()
        Me.PanelAbout.ResumeLayout(False)
        Me.PanelAbout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Control declarations ──────────────────────────────────────────────────
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabLaunch As System.Windows.Forms.TabPage
    Friend WithEvents TabFloppy As System.Windows.Forms.TabPage
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents TabAbout As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabelDOSBox As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabelDriveA As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabelDriveB As System.Windows.Forms.ToolStripStatusLabel

    ' Launch tab
    Friend WithEvents PanelLaunchMain As System.Windows.Forms.Panel
    Friend WithEvents BtnLaunchDOSBox As System.Windows.Forms.Button
    Friend WithEvents BtnQuickLaunchFloppy As System.Windows.Forms.Button
    Friend WithEvents GrpRecentFloppy As System.Windows.Forms.GroupBox
    Friend WithEvents CmbRecentFloppy As System.Windows.Forms.ComboBox
    Friend WithEvents BtnLaunchWithRecent As System.Windows.Forms.Button
    Friend WithEvents ChkMountOnStart As System.Windows.Forms.CheckBox
    Friend WithEvents GrpDOSBoxPath As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDOSBoxPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowseDOSBox As System.Windows.Forms.Button
    Friend WithEvents LblDOSBoxStatus As System.Windows.Forms.Label
    Friend WithEvents PicDOSBoxStatus As System.Windows.Forms.PictureBox

    ' Floppy tab
    Friend WithEvents SplitFloppy As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelFloppyLeft As System.Windows.Forms.Panel
    Friend WithEvents LvFloppyImages As System.Windows.Forms.ListView
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColLastUsed As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripFloppy As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAddImages As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRemoveImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep1Floppy As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMountA As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnMountB As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEject As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep2Floppy As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCreateImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnOpenLibFolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents CtxFloppy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CtxMountA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtxMountB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtxSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CtxOpenFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtxSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CtxRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelFloppyRight As System.Windows.Forms.Panel
    Friend WithEvents GrpQuickAccess As System.Windows.Forms.GroupBox
    Friend WithEvents PanelQuickAccess As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GrpMounted As System.Windows.Forms.GroupBox
    Friend WithEvents LblMountedA As System.Windows.Forms.Label
    Friend WithEvents LblMountedAValue As System.Windows.Forms.Label
    Friend WithEvents LblMountedB As System.Windows.Forms.Label
    Friend WithEvents LblMountedBValue As System.Windows.Forms.Label
    Friend WithEvents BtnEjectA As System.Windows.Forms.Button
    Friend WithEvents BtnEjectB As System.Windows.Forms.Button
    Friend WithEvents LblLibraryPath As System.Windows.Forms.Label
    Friend WithEvents TxtLibraryPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowseLibrary As System.Windows.Forms.Button

    ' Settings tab
    Friend WithEvents PanelSettings As System.Windows.Forms.Panel
    Friend WithEvents GrpSettingsDOSBox As System.Windows.Forms.GroupBox
    Friend WithEvents LblSettingsDOSBoxExe As System.Windows.Forms.Label
    Friend WithEvents TxtSettingsDOSBoxExe As System.Windows.Forms.TextBox
    Friend WithEvents BtnSettingsBrowseDOSBox As System.Windows.Forms.Button
    Friend WithEvents LblSettingsConfig As System.Windows.Forms.Label
    Friend WithEvents TxtSettingsConfig As System.Windows.Forms.TextBox
    Friend WithEvents BtnSettingsBrowseConfig As System.Windows.Forms.Button
    Friend WithEvents BtnEditConfig As System.Windows.Forms.Button
    Friend WithEvents GrpSettingsPerf As System.Windows.Forms.GroupBox
    Friend WithEvents LblCycles As System.Windows.Forms.Label
    Friend WithEvents TxtCycles As System.Windows.Forms.TextBox
    Friend WithEvents LblMemory As System.Windows.Forms.Label
    Friend WithEvents CmbMemory As System.Windows.Forms.ComboBox
    Friend WithEvents ChkFullscreen As System.Windows.Forms.CheckBox
    Friend WithEvents GrpSettingsLibrary As System.Windows.Forms.GroupBox
    Friend WithEvents LblSettingsLibrary As System.Windows.Forms.Label
    Friend WithEvents TxtSettingsLibrary As System.Windows.Forms.TextBox
    Friend WithEvents BtnSettingsBrowseLibrary As System.Windows.Forms.Button
    Friend WithEvents BtnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents BtnResetSettings As System.Windows.Forms.Button

    ' About tab
    Friend WithEvents PanelAbout As System.Windows.Forms.Panel
    Friend WithEvents LblAboutTitle As System.Windows.Forms.Label
    Friend WithEvents LblAboutVersion As System.Windows.Forms.Label
    Friend WithEvents LblAboutDesc As System.Windows.Forms.Label
    Friend WithEvents LblAboutFeatures As System.Windows.Forms.Label
    Friend WithEvents LblAboutCopyright As System.Windows.Forms.Label

    ' Timer
    Friend WithEvents TimerStatus As System.Windows.Forms.Timer

End Class
