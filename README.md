<p align=center><a href="#"><img src="https://github.com/RWELabs/RedM-Launcher/blob/main/WebAssets/RedM_Launcher_Head.png?raw=true" width="600px"></a></p>

# RedM Launcher
<p align=left><a href="#"><img src="https://github.com/RWELabs/RedM-Launcher/blob/main/WebAssets/csharpdotnet.svg"></a>  <a href="#"><img src="https://github.com/RWELabs/RedM-Launcher/blob/main/WebAssets/w11w10.svg"></a></p>

RedM Launcher is a custom launcher for RedM by Cfx.re that automatically checks and clears cache files before launching the game. This program aims to target the previous solution for automatically clearing cache files, which was to create a bat script. RedM Launcher offers a clean, user friendly and non-intimidating solution that is fast and effective.

## What does it do and how does it work?
The idea behind RedM Launcher is that it can launch the RedM application with a series of checks and operations to best ensure that the environment is ready for RedM to launch - so the player has the best possible experience. Here's a rundown of exactly what happens when you launch the RedM Launcher:

<p align=center><br><a href="#"><img src="https://github.com/RWELabs/RedM-Launcher/blob/main/WebAssets/Overview_Full.png?raw=true" width="650px"></a></p>

### When you launch RedM Launcher
1. RedM Launcher will check that ``RedM.exe`` exists within your ``%localappdata%\RedM`` directory.
2. If ``RedM.exe`` is found, RedM Launcher will move to *step 4*.
3. If ``RedM.exe`` is not found, RedM Launcher will copy a bundled version of ``RedM.exe`` from ``C:\Program Files (x86)\RWE Labs\RedM Launcher`` to ``%localappdata%\RedM``.
4. RedM Launcher will then check ``%localappdata%\RedM\RedM Application Data\data``.
5. If the directory ``server-cache`` exists inside of that directory, it is deleted.
6. If the directory ``server-cache-priv`` exists inside of that directory, it is also deleted.
7. RedM Launcher then launches ``RedM.exe``. If it was freshly copied, it will run through the installation process.

RedM Launcher will now act as the program you use to access RedM, replacing the regular RedM shortcut or your bat script shortcut.

<p align=center><br><a href="#"><img src="https://github.com/RWELabs/RedM-Launcher/blob/main/WebAssets/AnimatedDemo.gif?raw=true" width="600px"></a></p>


### Existing Methods
Currently, many servers recommend you clear your cache before joining a server. Not doing so can result in graphical issues and bugs in gameplay that are a result of your cache files not being properly overwritten at join time. A simple bat script can do the job but is intimidating to less technically savvy users and take an adept level of knowledge to do, without full and detailed documentation.

## Get Started
You can download RedM Launcher now via the GitHub Releases page. We recommend using Windows 10 or Windows 11 with at least 150mb of free space. Alternatively you can download the source code and compile it yourself with Visual Studio 2022.

### System Requirements
- Windows 10 or 11
- 200mb Disk Space (Minimum)
- Administrator Privileges
- RedM and RDR2/RDO installed (Recommended)

### Download
- [Download for Windows](https://github.com/RWELabs/RedM-Launcher/releases/latest)
- [Bug Report](https://github.com/RWELabs/RedM-Launcher/issues/new/choose)