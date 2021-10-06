## You can execute Optimizer silently, applying tweaks according to a configuration file. ##

Download the configuration file based on your Windows version and edit it accordingly.

* true: applies the specific option
* false: resets the specific option
* null: ignores the specific option

Then, execute it like this: optimizer.exe /w10.conf

### For Windows 7: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win7.conf

### For Windows 8/8.1: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win8.conf

### For Windows 10: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win10.conf

### For Windows 11: ###
https://github.com/hellzerg/optimizer/blob/master/confs/win11.conf

## Run Optimizer on Windows Server 2008-2012-2016-2019 ##
#### Some options might not work properly ####
optimizer.exe /unsafe

## How to disable Windows Defender in Windows 10 1903 and later ##
#### https://docs.microsoft.com/en-us/windows-hardware/customize/desktop/unattend/security-malware-windows-defender-disableantispyware "DisableAntiSpyware" is discontinued and will be ignored on client devices, as of version 1903. ####

- Restart in SAFE MODE
- Execute: optimizer.exe /disabledefender

## Reset Optimizer configuration might fix it when can't open ##
optimizer.exe /reset
