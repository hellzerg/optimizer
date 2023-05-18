## You can execute Optimizer silently, automating a range of operations based on a template. ##

Download the template file and edit it accordingly.
Then, execute it like this: ```optimizer.exe /config=template.json```

### Download the template: ###
https://github.com/hellzerg/optimizer/blob/master/templates/optimizer-template.json

#### WindowsVersion (required) ####
* Should match your actual Windows version. Available values: ```7 | 8 | 10 | 11```

#### Cleaner ####
* Choose which target folder you wish to clean by marking ```true```

#### Pinger ####
* Choose your desired DNS provider.
* Available values: ```Automatic | Cloudflare | OpenDNS | Quad9 | Google | AlternateDNS | Adguard | CleanBrowsing | CleanBrowsing (adult filter)```
* If you wish to perform DNS cache flushing, set it to ```true```

#### ProcessControl ####
* Choose which processes you wish to prevent from running, using their filename.
* You can remove previously prevented processes, in order to allow them to run again.
* Example: 
```
"ProcessControl": {
	"Prevent": ["chrome.exe", "firefox.exe"],
	"Allow": ["opera.exe"]
}
```

#### Hosts ####
* Control your hosts entries. ```Add``` list adds the entries, ```Block``` list routes the entries to ```0.0.0.0``` effectively blocking access to them.
* Example:
```
"HostsEditor": {
    "Block": ["youtube.com", "google.com"],
    "Add": [
	    {
	    	"Domain": "test.com",
	    	"IPAddress": "192.168.1.5",
	    	"Comment": "comment is optional"
	    },
	    {
	    	"Domain": "test2.com",
	    	"IPAddress": "192.168.1.9",
	    	"Comment": ""
	    }
    ]
}	
```

#### RegistryFix ####
* You can try enabling core Windows components by marking them ```true```
* You typically do not need this, unless you are trying to repair a computer from malicious actions

#### Integrator ####
* ```TakeOwnership```: Mark ```true``` to add a "Take Ownership" option in right-click menu. Remove it by marking ```false```
* ```OpenWithCMD```: Mark ```true``` to add a "Open CMD here" option in right-click menu. Remove it by marking ```false```

#### AdvancedTweaks ####
* Deeply technical tweaks that you should NOT touch, unless you know what you are really doing

* ```UnlockAllCores```: DO NOT use this option. Leave it ```null``` or ```false```.
* ```DisableHPET```: Enables or disables High Precision Event Timer.
* ```EnableLoginVerbose```: Enables or disables Detailed Login Screen

##### SvchostProcessSplitting #####
* Mark it ```true``` and set the amount of ```RAM``` to reduce the svchost.exe processes for optimal memory
* Mark it ```false``` to enable process splitting for optimal performance

#### Tweaks ####
* Mark the options you want to APPLY to ```true```
* Mark the options you want to RESET to ```false```
* Mark the options you want to IGNORE to ```null```

#### PostAction ####
* Final action after executing the template.
* You may mark ```Restart``` to ```true``` to restart in order to effectively apply the changes.
* You may choose between different types of restarting by configuring ```RestartType```
* ```Normal``` performs a normal restart
* ```SafeMode``` performs a restart in minimal safemode

* ```DisableDefender```: you can disable Windows defender (Windows 10/11 needs this) by going through safemode and returning, everything automated
* ```EnableDefender```: same, but for enabling Windows defender