# Windows Server Optimizer Commands #

## Running the Optimizer ##
Please note that some options might not work properly.
- Run the optimizer with: `optimizer.exe /unsafe`

## Disabling Windows Defender ##
For Windows 10 1903 and later, `DisableAntiSpyware` is ignored starting from version 1903.
To disable Windows Defender:
1. Restart in SAFE MODE.
2. Execute: `optimizer.exe /disabledefender` OR `optimizer.exe /restart=disabledefender` (automatic)

## Re-enabling Windows Defender ##
To re-enable Windows Defender:
1. Restart in SAFE MODE.
2. Execute: `optimizer.exe /enabledefender` OR `optimizer.exe /restart=enabledefender` (automatic)

## Restart Modes ##
Restart in SAFE MODE: `optimizer.exe /restart=safemode`
Restart in NORMAL MODE: `optimizer.exe /restart=normal`

## Version Info ##
Display version information: `optimizer.exe /version`

## Disabling Specific Tools ##
For troubleshooting purposes, you can disable specific tools:
- Hardware inspection utility: `indicium`
- Common Apps downloader tool: `apps`
- HOSTS Editor tool: `hosts`
- UWP Apps Uninstaller: `uwp`
- Startup items tool: `startup`
- Cleaner utility: `cleaner`
- Integrator tool: `integrator`
- Pinger tool: `pinger`
Example: `optimizer.exe /disable=indicium,uwp`

## svchost Process Splitting Mechanism ##
Reduce svchost processes to improve RAM usage:
- Disable (provide RAM amount): `optimizer.exe /svchostsplit=8`
- Reset to default: `optimizer.exe /resetsvchostsplit`

## Resetting Optimizer Configuration ##
To fix issues when unable to open the optimizer:
- Reset configuration: `optimizer.exe /repair`

## Disabling/Enabling HPET (High Precision Event Timer) ##
Use at your own risk for gaming performance:
- Disable: `optimizer.exe /disablehpet`
- Enable: `optimizer.exe /enablehpet`
