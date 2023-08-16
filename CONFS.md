## Run Optimizer on Windows Server 2008-2012-2016-2019-2022 ##
#### Some options might not work properly ####
- ```optimizer.exe /unsafe```

## How to disable Windows Defender in Windows 10 1903 and later ##
#### https://docs.microsoft.com/en-us/windows-hardware/customize/desktop/unattend/security-malware-windows-defender-disableantispyware "DisableAntiSpyware" is discontinued and will be ignored on client devices, as of version 1903. ####

- Restart in SAFE MODE
- Execute: ```optimizer.exe /disabledefender```

-OR-

- Execute: ```optimizer.exe /restart=disabledefender``` and let Optimizer do the rest automatically

## How to re-enable Windows Defender ##

- Restart in SAFE MODE
- Execute: ```optimizer.exe /enabledefender```

-OR-

- Execute: ```optimizer.exe /restart=enabledefender``` and let Optimizer do the rest automatically

## How to restart in SAFE MODE / NORMAL easily ##

- ```optimizer.exe /restart=safemode```
- ```optimizer.exe /restart=normal```

## Display version info from command line using:

- ```optimizer.exe /version```

## You may disable specific tools for troubleshooting purposes ##
#### Available list: ####

* Hardware inspection utility (```indicium```)
* Common Apps downloader tool (```apps```)
* HOSTS Editor tool (```hosts```)
* UWP Apps Uninstaller (```uwp```)
* Startup items tool (```startup```)
* Cleaner utility (```cleaner```)
* Integrator tool (```integrator```)
* Pinger tool (```pinger```)

#### Examples ####

- ```optimizer.exe /disable=indicium,uwp```
- ```optimizer.exe /disable=indicium,uwp,hosts```

## Disable or Reset svchost process splitting mechanism ##
### Reduces the amount of svchost processes running, improving RAM usage ###
### To disable it, you need to provide your amount of RAM using this command (example for 8GB RAM): ###

```optimizer.exe /svchostsplit=8```

#### Reset the mechanism to its default configuration using: ####
```optimizer.exe /resetsvchostsplit```

## Reset Optimizer configuration might fix it when can't open ##
```optimizer.exe /repair```

## How to disable/enable HPET (High Precision Event Timer) in order to gain a boost when gaming [use at your own risk!] ##

- ```optimizer.exe /disablehpet```
- ```optimizer.exe /enablehpet```
