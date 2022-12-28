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

## Reset Optimizer configuration might fix it when can't open ##
```optimizer.exe /repair```

## How to disable/enable HPET (High Precision Event Timer) in order to gain a boost when gaming [use at your own risk!] ##

- ```optimizer.exe /disablehpet```
- ```optimizer.exe /enablehpet```

## You can execute Optimizer silently, applying tweaks according to a configuration file. ##

Download the configuration file based on your Windows version and edit it accordingly.

* ```true```: applies the specific option
* ```false```: resets the specific option
* ```null```: ignores the specific option

Then, execute it like this: ```optimizer.exe /win10.conf```

### For Windows 7: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win7.conf

### For Windows 8/8.1: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win8.conf

### For Windows 10: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win10.conf

### For Windows 11: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win11.conf


