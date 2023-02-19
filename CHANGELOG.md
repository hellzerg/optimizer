## [14.9] - 2023-02-18
- New: Uninstall OneDrive is ONLY visible in UNSAFE MODE, for apparent reasons...
- New: Optimizer Insights collects - with great respect to privacy - every error the app produces for further investigation
- New: Of course, you can disable Optimizer Insights in Options
- New: Fully translated into Japanese (thanks to Yamada Hayao - https://github.com/Hayao0819 for Japanese translation) (#286)
- Improved: Minor code refactoring

## [14.8] - 2023-01-07
- New: Updated to .NET Framework 4.8 for better performance and support
- New: Added Restore all UWP apps
- Improved: Refactored command-line processor
- Hotfix: UWP uninstall confirmation message fixed (#281)

## [14.7] - 2022-12-24
- Hotfix: Theme color bug causing crash on launch

## [14.6] - 2022-12-17
- New: Disable Microsoft Store Updates
- Hotfix: Automatic/manual updates working again
- Hotfix: Disable NTFS Timestamp now retained after restart
- Removed: Disable Feature Updates

## [14.5] - 2022-11-26
- New: Fully translated into Ukrainian (thanks to Kirill Ermakov - https://github.com/kirill0ermakov) (#261)
- New: Disable Search service in General (#257)
- Hotfix: Weather not being enabled after resetting Classic File Explorer (#263)
- Hotfix: Domain will not be prefixed with www in Hosts Editor anymore (#259)
- Improved: Assets cleanup, reduced file size (#260)

## [14.4] - 2022-11-05
- Hotfix: Disabling Game Bar does not turn off Game Mode too
- Hotfix: Resetting Classic Ribbon for Explorer is working properly (Windows 11)

## [14.3] - 2022-10-26
- New: Disable Virtualization-based security (for Windows 11)
- New: Concise categorization for every toggle
- New: Grayscale app icon for neutrality
- Hotfix: Tab headers scaling problem

## [14.2] - 2022-10-21
- Hotfix: Proper DPI scaling for main tabs (#236)
- Hotfix: Not saving and loading Dutch language
- Improved: Chrome Telemetry, Enhance Privacy and Optimize Performance
- Removed: Network monitoring in tray menu

## [14.1] - 2022-10-18
- New: Theme engine supporting whole color spectrum (thanks to  cat - https://github.com/vadiscode)
- New: Disable NVIDIA Telemetry in Universal
- New: Start Optimizer with Windows in Options (works with proper permissions)
- Hotfix: App crashes when no internet connection available
- Hotfix: Translation issues
- Improved: Enhance Privacy and Superfetch options

## [14.0] - 2022-09-24
- New: Fully translated into Dutch (thanks to svanlaere - https://github.com/svanlaere)
- Hotfix: Snap Assist not working
- Hotfix: Restart button crash
- Hotfix: UWP app image crash
- Hotfix: Chinese translation
- Improved: Reset Configuration renamed to Repair, because it is an auto-repair mechanism, NOT a Reset

## [13.9] - 2022-08-21
- Hotfix: Help messages for each toggle now appears on a panel
- Hotfix: Restarting from inside the app does not save settings

## [13.8] - 2022-08-20
- New: Disable Hibernate in Universal
- New: Disable NTFS timestamp in Universal
- New: Disable SMBv1 & SMBv2 protocols in Universal
- New: Display icons in UWP Apps list (#213)
- New: Display Restart prompt when necessary
- New: Enable Performance Tweaks renamed to: Optimize Performance
- New: Splash art updated
- Improved: Reduced memory dump size tweak in Optimize Performance
- Hotfix: Disable Telemetry Services no longer stops WdiSystemHost service, which is responsible for battery statistics (#214)

## [13.7] - 2022-08-05
- New: Disable/Enable HPET using ```/disablehpet``` & ```/enablehpet``` switches
- New: Allow Optimizer to run on startup using ```/addstartup``` (#206)
- Hotfix: Disable Telemetry Services no longer disables Diagnostics Policy service (DPS), which is responsible for network app usage (#212)
- Hotfix: Proper DPI scaling for software list in Apps (#193)
- Improved: Enhance Privacy now disables Phone Link

## [13.6] - 2022-06-12
- New: Fully translated into Romanian (thanks to BeamingNG - https://github.com/BeamingNG)
- New: DPI awareness support
- Improved: Proper reset for Enhance Privacy tweak

## [13.5] - 2022-06-05
- New: Fully translated into Hungarian (thanks to Zan)
- Hotfix: Disable TPM Check not working
- Hotfix: Proper reset for Cloud Clipboard

## [13.4] - 2022-05-14
- Hotfix: Crashes on loading if network is offline

## [13.3] - 2022-05-10
- New: Fully translated into Kurdish (thanks to Parwar Andam)

## [13.2] - 2022-05-08
- New: Brave browser support in Cleaner (#176)
- New: Find file lock handles and free it by killing the processes
- Hotfix: Uninstalled UWP apps no longer remain in the list (#129)
- Hotfix: 'Enable Compact Mode in Files' not reflecting current state

## [13.1] - 2022-05-07
- New: Change DNS servers rapidly using Pinger (Cloudflare, OpenDNS, Quad9, Google, Alternate, Adguard, Cleanbrowsing) 
- Hotfix: Rare issue with Cleaner not emptying subfolders
- Hotfix: Not responding when Enhance Privacy toggle is pressed
- Hotfix: FPS drops when moving the entire window (#175)

## [13.0] - 2022-05-04
- New: Enable Compact mode in Files for Windows 11 (removes extra space between files)
- New: Cleaner now estimates size based on your preferences
- New: Shiny new update window
- Hotfix: Using ```/disablehibernate & /enablehibernate``` switches throws config not found error

## [12.9] - 2022-05-03
- New: Enable Defender automatically (```/restart=enabledefender``` switch)
- New: Enable/Disable hibernation from command-line (```/disablehibernate & /enablehibernate```)
- New: Added accessibility support for toggles (#150)
- Hotfix: Warning if choosing to Disable System Restore

## [12.8] - 2022-05-02
- New: Enable Gaming Mode (plus hardware-accelerated GPU scheduling)
- New: Added Brave browser in Common Apps
- New: Disable Defender automatically (```/restart=disabledefender``` switch)
- Hotfix: Warning if choosing to Uninstall OneDrive
- Hotfix: Performance Tweaks do not disable tray grouping (arrow icon)
- Hotfix: Translation fixes in almost all languages
- Improved: Slightly faster loading time
- Removed: Disable Notification/Action Center

## [12.7] - 2022-04-3
- New: Fully translated into Arabic (thanks to https://github.com/MesterPerfect - MesterPerfect)

## [12.6] - 2022-04-03
- New: Redesigned Cleaner tool
- Hotfix: Enable Classic Ribbon registry key fixed
- Hotfix: Translation issues

## [12.5] - 2022-04-02
- New: Fully translated into Polish (thanks to https://github.com/factuall - Adrian Nieściur)

## [12.4] - 2022-03-29
- New: Fully translated into Korean (thanks to https://github.com/VenusGirl - VenusGirl)
- New: Updated Newtonsoft.Json from version 12.0.2 to 13.0.1
- Hotfix: Translation additions and fixes in all supported languages
- Improved: Performance Tweaks

## [12.3] - 2022-03-27
- Hotfix: Italian translation
- Hotfix: Flush DNS cache now requires confirmation
- Hotfix: Chinese instead of Taiwanese flag
- Removed: Pre-made AdBlock lists in Hosts due to several bugs

## [12.2] - 2022-03-26
- Hotfix: Crash when loading German language

## [12.1] - 2022-03-26
- New: Fully translated into Taiwanese (thanks to https://github.com/H3XDaemon - H3XDaemon)
- New: Added ShareX in Common Apps feed
- Improved: Fixed translation issues on German and Italian languages
- Removed: Hardware-accelerated GPU scheduling from Xbox Live toggle

## [12.0] - 2022-03-06
- New: Fully translated into Czech (thanks to https://github.com/tomlonghorn - Tom Longhorn)

## [11.9] - 2022-02-23
- Hotfix: Permissions issue on Windows 11 (#97)

## [11.8] - 2022-02-21
- New: Restart in normal and minimal safe-mode from command-line
- Hotfix: Faster network monitoring initialization
- Hotfix: Resize main window based on each language for maximum visibility
- Minor visual changes

## [11.7] - 2022-02-10
- Hotfix: Hangs on loading in case network monitoring is not supported (#93, #95)

## [11.6] - 2022-02-08
- New: Disable Google Chrome telemetry and software reporting tool
- New: Disable Mozilla Firefox telemetry and data collection service
- New: Disable Visual Studio telemetry, feedback and collector service
- Improved: Office telemetry tweaks

## [11.5] - 2022-01-31
- Hotfix: Crashing when detecting CPU on Windows 7 (#90)

## [11.4] - 2022-01-30
- New: Hardware specifications inspection tool
- New: Network speed monitoring in Quick Access Menu (if enabled)

## [11.3] - 2022-01-29
- Quality improvements in many aspects (Telemetry services, Enhanced privacy, etc.)
- Visual changes

## [11.2] - 2022-01-28
- New: Interface has been slightly reworked to be easy on eyes
- Couple of bug fixes

## [11.1] - 2022-01-23
- New: Major browsers support in Cleaner (clear cache, cookies, history, session, passwords)

## [11.0] - 2022-01-15
- Improved: Translation fixes in all supported languages

## [10.9] - 2021-12-12
- New: Fully translated into Chinese (thanks to https://github.com/btwise - btwise)

## [10.8] - 2021-12-05
- New: Add/Delete 'Open with CMD' option in Integrator (#73)
- Hotfix: Disable Meet icon properly

## [10.7] - 2021-11-23
- New: Disable Meet Now icon (in Restore Classic File Explorer)
- New: Disable lockscreen suggestions (in Disable Start Menu Ads)
- Hotfix: Portuguese translation corrected
- Minor bug fixes

## [10.6] - 2021-11-16
- New: Fully translated into Italian (thanks to https://github.com/Ziocash - Ziocash)
- New: Disable File History (in Restore Classic File Explorer)
- New: Loading animation for smoother opening

## [10.5] - 2021-11-14
- New: Open Command Prompt here (in Performance Tweaks)
- New: Disable News and Weather in taskbar (in Restore Classic File Explorer)

## [10.4] - 2021-10-29
- Hotfix: Crash when Spanish language is selected

## [10.3] - 2021-10-10
- Improved: Disable TPM Check (both 2.0, 1.2 and RAM check)

## [10.2] - 2021-10-07
- New: Optimizer now runs in single-instance mode
- Improved: Preview and select files before cleaning
- Improved: French translation

## [10.1] - 2021-10-06
- New: Fully compatible with Windows 11 (with silent configuration support)
- New: Align taskbar to te left
- New: Disable Snap Assist, Widgets and Chat
- New: Smaller taskbar size
- New: Restore Classic Ribbon in File Explorer
- New: Restore Classic Right-Click Menu (no Show More Options)
- New: Disable TPM 2.0 checks, allowing the upgrading to Windows 11
- New: Single-instance support
- Improved: Exclude Drivers from Windows Update

## [10.0] - 2021-09-14
- Code cleanup
- Minor UI changes

## [9.9] - 2021-08-23
- New: Fully translated into French (thanks to https://github.com/RAFF47 - RAFF)

## [9.8] - 2021-08-04
- New: Disable Windows Defender completely in SAFE MODE - run Optimizer.exe /disabledefender (for Windows 10 1903 and later: https://docs.microsoft.com/en-us/windows-hardware/customize/desktop/unattend/security-malware-windows-defender-disableantispyware)
- New: Cloudflare DNS helper in Pinger
- New: System details in error logging

## [9.7] - 2021-08-02
- New: Fully translated into Portuguese (thanks to https://github.com/cassiompf - Cassio)

## [9.6] - 2021-07-24
- New: Fully translated into Spanish (thanks to https://github.com/danielcshn - danielcshn)

## [9.5] - 2021-07-15
- Hotfix: Crash when running with no internet connection
- Improved: Startup items can now be checked

## [9.4] - 2021-07-14
- New: App now opens slightly faster
- New: Enhance Privacy now attempts to enable Group Policy Editor on Windows 10 Home (gpedit.msc)
- Improved: Flush DNS cache
- Improved: Privacy tweaks (now disables Cloud Search, Find my Device, Timeline)
- Improved: Defender & Xbox tweaks

## [9.3] - 2021-06-29
- New: Fully translated into German (thanks to https://github.com/theflamehd - theflamehd)

## [9.2] - 2021-06-28
- Hotfix: Disable Spell Checking does not disable pen support (Disable Windows Ink now does this)
- Hotfix: Feed error label misplaced

## [9.1] - 2021-06-26
- Significantly reduced file size (~1.4 MB)
- Improvements in memory management (~60MB instead of ~110MB on load)
- Re-designed Common Apps: Categories and full-dynamic app loading
- Minor bug fixes

## [9.0] - 2021-06-24
- New apps added:
.NET Framework 4.8,
Java 8 JDK,
Python 3 & 2,
K-Lite Codec Pack Mega,
VS Codium,
Balena Etcher
- Minor bug fixes

## [8.9] - 2021-06-17
- New: Now detects .NET Framework installed version
- New: Fully translated into Turkish (thanks to https://github.com/Kheasyque - Kheasyque) (#47)
- Hotfix: Pinger not working when returning IPv6, now pings IPv4 only

## [8.8] - 2021-06-07
- Choose language if running first time

## [8.7] - 2021-06-06
- Hotfix: Crash when applying "Enhance Privacy"

## [8.6] - 2021-06-06
- Plenty of improvements in Performance, Privacy & Telemetry

## [8.5] - 2021-06-05
- New: Fully translated into Hellenic (thanks to aplenaki)
- Corrections to Russian localization

## [8.4] - 2021-06-02
- New: Fully translated into Russian (thanks to https://github.com/mrkaban - mrkaban) (#5) 
- Hotfix: Sometimes settings not saving (#38, #36) 
- Hotfix: Improved resetting of Disable Automatic Updates & Defender (#42) 
- Removed: Change Edge download folder (deprecated)

## [8.3] - 2021-05-31
- Hotfix: Not exiting when updating with Quick Access menu enabled

## [8.2] - 2021-05-31
- New: Added "/reset" switch for troubleshooting 
- Improved: Enabling Automatic Updates and Defender is better now

## [8.1] - 2021-05-31
- Hotfix: Pinger sometimes not working

## [8.0] - 2021-05-30
- New: Backup & restore Startup items
- Improved: Performance tweaks
- Improved: Better cconfiguration management
- Hotfix: Detect missing apps download path

## [7.9] - 2021-05-27
- Hotfix: Issue #37, crashing when registry key permission is denied

## [7.8] - 2021-04-17
- Hotfix: Crash when Startup folders are missing
- Startup can now detect batch files

## [7.7] - 2021-04-15
- Hotfix: Crashes due to localization

## [7.6] - 2021-04-12
- New: Show or hide help tips option
- UI polishing

## [7.5] - 2021-04-12
- New: Hover on each switch to read the explanation
- Improved: Disable Feature Updates

## [7.4] - 2021-04-11
- Improved: Disable SmartScreen
- Improved: Better UI scaling in Common Apps

## [7.3] - 2021-04-11
- New: Flush DNS cache (Pinger)
- Hotfix: Some tabs not working when offline
- Several improvements on Windows 10 privacy
- Removed unnecessary timers

## [7.2] - 2021-04-10
- LICENSES are now visible in Options
- Check for update on launch 

## [7.1] - 2021-04-10
- New: Pinger allows quick pinging and SHODAN.io search
- New: Quick Access menu - enable it in Options
- Hotfix: SystemResponsiveness now defaults to 14
- Hotfix: Error handling when HOSTS file is unreadable - again

## [7.0] - 2021-04-08
- New: Check space to be freed before cleaning
- Hotfix: Error handling when HOSTS file is unreadable

## [6.9] - 2021-04-03
- New: Added MEGAsync in Common Apps
- Moved: Disable Silent App Install to Disable Automatic Updates
- Improved: Disable Privacy Options is now smoother

## [6.8] - 2021-03-12
- New: Visual C++ AiO, .NET Frameworks & ViPER4Windows in Common Apps
- New: Error logging
- Improved: Updates to Common Apps versions
- Improved: UI polishing

## [6.7] - 2021-02-25
- Hotfix: Search not working (Reset Superfetch, disable it again and restart Windows to fix)

## [6.6] - 2021-02-24
- Hotfix: Crash when disabling Superfetch service

## [6.5] - 2021-02-23
- Fix: Some options not being saved when running silently
- New: Added option to Disable Notification Center (for Windows 10)
- New: Show file extensions & hidden files (Enable Performance Tweaks)
- Improved: Disable Telemetry Tasks & Services
- Improved: Disable Superfetch
- Improved: Disable Game Bar (more services)
- Improved: Disable Automatic Updates
- Minor UI polishing

## [6.4] - 2021-02-22
- Hotfix: Windows 7 crashing now resolved
- Hotfix: Changed SystemResponsiveness from 0 to 1 (0 is counting as 10)

## [6.3] - 2021-02-15
- New: Common Apps is getting the links online, no need to update the app to get new links
- Improved: Tons of bug fixes to UI and beyond

## [6.2] - 2021-02-14
- New: Nice styling to checkboxes & radios

## [6.1] - 2021-02-14
- Improved: Disable Windows Defender
- Improved: Uninstall OneDrive and removing all leftovers
- Improved: Hide non-uninstallables UWP Apps option
- Updated Chromium links
- Minor UI fixes

## [6.0] - 2021-01-20
- Smaller window size, scrollable app list in Common Apps

## [5.9] - 2021-01-19
- Hotfix: Crash when opening folder in Common Apps

## [5.8] - 2020-12-22
- Added: Rufus and Universal USB Installer in Common Apps

## [5.7] - 2020-12-20
- Added: F.lux in Common Apps

## [5.6] - 2020-12-20
- Hotfix: Disable Telemetry Services

## [5.5] - 2020-12-19
- Added: More apps supported in Common Apps
- Improved: Disable Windows Defender

## [5.4] - 2020-12-17
- Added: Run & install apps after downloading option
- Critical bug fixes regarding app downloader
- Properly save MSI packages

## [5.3] - 2020-12-17
- Added: Icons in Common Apps
- Added: Additional apps for downloading
- Several bug fixes
- UI polishing

## [5.2] - 2020-12-17
- Added: Common Apps: Download useful apps quickly at once
- Improved: Disable Telemetry Services

## [5.1] - 2020-12-11
- Some UI warnings

## [5.0] - 2020-12-10
- Added: Remove Cast to Device option
- Added: Pre-made adblock in HOSTS editor
- Added: Allow Optimizer on Windows Server using "/unsafe" switch
- Improved: Faster HOSTS file reading
- Improved: Disable Network Throttling
- Removed: Block Skype ads (useless)

## [4.9] - 2019-11-07
- Added: Run Optimizer silently, using configuration file
- Added: Disable Windows Store automatic updates (Disable Silent App Install)

## [4.8] - 2019-05-12
- Added: Disable Sticky Keys (for current user)
- Added: Enable Long Paths (removes 260 character path limit, for Windows 10)

## [4.7] - 2019-02-03
- Added: Disable Cloud Clipboard experience (for Windows 10 1809)

## [4.6] - 2019-01-30
- Changed blocked IP from 127.0.0.1 to 0.0.0.0 in HOSTS editor
- Changed 'Restart' button to 'Apply & Restart'

## [4.5] - 2018-10-08
- Improved: You can now update the app automatically by clicking Check for update in Options

## [4.4] - 2018-09-21
- Improved: Disable Automatic Updates (Windows 10)
- Added: Make HOSTS file read-only

## [4.3] - 2018-09-17
- Added: Disable SmartScreen

## [4.2] - 2018-09-12
- Improved: Disable Silent App Install (Cloud Content)
- Improved: Disable Cortana & web search

## [4.1] - 2018-03-09
- Added: Disable forced feature updates on Windows 10

## [4.0] - 2018-02-21
- Added: Disable Fax service
- Added: Disable Windows Insider service

## [3.9] - 2018-01-05
- Added: Disable Program Compatibility Assistant Service
- Added: Check for new versions in Options
- Added: View changes in Options

## [3.8] - 2017-12-31
- Windows 7 crashing fixed

## [3.7] - 2017-12-22
- Every option can now be reverted back (toggles, finally)
- Apply All button removed in favor of toggles
- Added Enable Dark Theme toggle for Windows 10
- Disable Diagnostics Tracking, WAP Push & Data Telemetry into one toggle: Disable Telemetry Services
- Remove Get Windows 10 button removed as it is no longer needed
- Various improvements
- Added Reset Configuration button in Options

## [3.6] - 2017-12-11
- Added Select All in UWP uninstaller
- Improved Disable Telemetry Tasks
- Changes to Disable Automatic Updates

## [3.5] - 2017-11-24
- Added back UWP app uninstaller
- Disable Windows Defender also removes tray icon now
- Disable Start Menu ads & Silent App Install improved
- Added option to restore Taskbar color
- Minor visual changes
- Hide Sync Provider ads renamed to Disable Quick Access History (disables used files and folders, File Explorer opens 'This PC' by default now, hides Sync Provider ads)

## [3.4] - 2017-10-25
- Performance improvements
- Startup crash on x86 systems fixed

## [3.3] - 2017-10-21
- Improved Disable Privacy Options
- Added option to disable Windows Ink & suggestions
- Added options to disable Spelling & Typing features

## [3.2] - 2017-10-18
- Compatible with Windows 10 Fall Creators Update
- Improved Disable Xbox Live & Disable Cortana options
- Added option to remove My People from taskbar
- Added option to exclude drivers from Windows Update

## [3.1] - 2017-09-26
- Disable Start Menu ads on Windows 10
- Prevent reinstalling Modern Apps on Windows 10

## [3.0] - 2017-06-28
- Added option to disable Media Player sharing service
- Various privacy optimizations for Windows 10

## [2.9] - 2017-05-17
- Added ability to remove custom commands for Run Dialog

## [2.8] - 2017-05-16
- Further improved Disable Telemetry tasks

## [2.7] - 2017-04-04
- Compatible with Windows 10 Creators Update
- Added option to enable/disable Sensor Services
- Added option to block domain in HOSTS editor

## [2.6] - 2017-03-14
- Minor visual fixes

## [2.5] - 2017-02-18
- Removed ability to uninstall Modern Apps due to several bugs

## [2.4] - 2017-02-17
- Registry fixer improvements

## [2.3] - 2017-02-15
- Improved Disable Telemetry tasks
- Added new performance tweaks

## [2.2] - 2016-12-14
- Minor bug fixes

## [2.1] - 2016-12-05
- Added Take Ownership option in Integrator ready menus
- General improvements

## [2.0] - 2016-11-24
- Minor bug fixes
- Cosmetic changes

## [1.9] - 2016-11-14
- Further improved Disable Office Telemetry

## [1.8] - 2016-10-27
- More bug fixes

## [1.7] - 2016-10-23
- Minor bug fixes

## [1.6] - 2016-10-20
- Added option to disable Game Bar on Windows 10

## [1.5] - 2016-09-14
- Major bug fixes

## [1.4] - 2016-09-12
- Added HOSTS editor
- Added Integrator tool
- Added theme option
- Performance improvements
- Cosmetic changes

## [1.3] - 2016-09-09
- Improved Startup Items detection

## [1.2] - 2016-09-08
- Compatible with Windows 10 Anniversary Update
- Minor visual fixes

## [1.1] - 2016-08-05
- Added option to enable/disable Print Service
- Improved Disable Office Telemetry option
- Major bug fixes

## [1.0] - 2016-07-26
- Initial release
