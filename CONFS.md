You can execute Optimizer silently, applying tweaks according to a configuration file.

Download the configuration file based on your Windows version and edit it accordingly.

* true: applies the specific option
* false: resets the specific option
* null: ignores the specific option

Then, execute it like this: optimizer.exe /w10.conf

### For Windows 7: ###
https://github.com/hellzerg/optimizer/blob/master/confs/w7.conf

### For Windows 8/8.1: ###
https://github.com/hellzerg/optimizer/blob/master/confs/w8.conf

### For Windows 10: ###
https://github.com/hellzerg/optimizer/blob/master/confs/w10.conf

## Run Optimizer on Windows Server 2008-2012-2016-2019 ##
#### Some options might not work properly ####
optimizer.exe /unsafe

## Reset Optimizer configuration might fix it when can't open
optimizer.exe /reset
