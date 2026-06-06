# 💾 MatTech DOS

A VirtualBox-style DOS and Windows emulator frontend for Ubuntu, powered by QEMU.

![Ubuntu](https://img.shields.io/badge/Ubuntu-22.04%2B-E95420?logo=ubuntu&logoColor=white)
![QEMU](https://img.shields.io/badge/QEMU-powered-orange)
![Python](https://img.shields.io/badge/Python-3.8%2B-3776AB?logo=python&logoColor=white)
![GTK3](https://img.shields.io/badge/GTK-3-4A90D9)
![License](https://img.shields.io/badge/License-MIT-green)

## Features

- **VirtualBox-style UI** — left sidebar machine list, right detail panel
- **QEMU-powered** — full x86 PC emulation, not a DOS compatibility layer
- **Auto-download install media** — fetches install disks from archive.org automatically
- **One-click disk swap** — floating panel swaps floppy/CD images via QEMU monitor
- **Blank floppy & CD creator** — create FAT12 floppies or ISO images with custom labels
- **Save & resume state** — VM snapshots saved on shutdown, resumed on next start
- **Auto-detected requirements** — correct CPU, RAM, disk size set per OS automatically
- **Factory reset** — wipe a VM's hard disk and start fresh with one click

## Supported Operating Systems

| OS | Year | Media |
|---|---|---|
| Windows 1.0 | 1985 | 💾 Floppy + DOS 3.30 |
| Windows 2.0 | 1987 | 💾 Floppy + DOS 3.30 |
| Windows 3.0 | 1990 | 💾 Floppy + DOS 6.22 |
| Windows 3.11 | 1993 | 💾 Floppy + DOS 6.22 |
| Windows NT 3.51 | 1995 | 💿 CD-ROM |
| Windows 95 OSR2 | 1995 | 💿 CD-ROM |
| Windows NT 4.0 | 1996 | 💿 CD-ROM |
| Windows 98 SE | 1999 | 💿 CD-ROM |
| Windows 2000 Pro | 2000 | 💿 CD-ROM |
| Windows XP SP3 | 2001 | 💿 CD-ROM |
| MS-DOS 5.00 | 1991 | 💾 Floppy |
| MS-DOS 6.22 | 1994 | 💾 Floppy |
| PC-DOS 7.00 | 1994 | 💾 Floppy |
| FreeDOS 1.3 | 2022 | 💿 CD-ROM |

## Installation

Download the `.deb` package from the [website](https://mattech-dos.netlify.app) or from the [releases page](https://github.com/matthewglandi-arch/mattech-dos/releases).

```bash
sudo apt install ./mattech-dos_1.0.0_all.deb
```

### Dependencies (auto-installed)

```bash
sudo apt install qemu-system-x86 qemu-utils python3-gi python3-gi-cairo gir1.2-gtk-3.0 xdotool genisoimage
```

## Usage

Launch from the app menu or run:

```bash
mattech-dos
```

1. Click **New** to create a machine and pick an OS version
2. Click **Download** to fetch install media from archive.org
3. Click **Start** to boot the VM
4. Use the **Disk Swap** panel to insert/eject floppy and CD-ROM images
5. Click **Shutdown** to save state and power off

## System Requirements

- Ubuntu 22.04+ or Debian-based Linux
- x86_64 architecture
- Python 3.8+
- QEMU (`qemu-system-x86`)
- ~2 GB disk space for media

## Building from Source

```bash
git clone https://github.com/matthewglandi-arch/mattech-dos.git
cd mattech-dos
dpkg-deb --build vboxlike mattech-dos_1.0.0_all.deb
sudo dpkg -i mattech-dos_1.0.0_all.deb
```

## License

MIT
