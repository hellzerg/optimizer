## Frequently Asked Questions for using Optimizer safely ##

- Q: Do I need to restart my computer for the app to take effect?
- A: Absolutely, yes.

- Q: Do I need to keep the app running in the background?
- A: No. You just need to enable your preferred options and restart.

- Q: My Desktop files and documents got suddenly deleted! Why?
- A: You shouldn't **Uninstall OneDrive** on a Windows 10/11 with Microsoft-synced account setup.
It's strongly advisable to **Uninstall OneDrive** only on a fresh Windows installation, before
setting up Microsoft account.

- Q: How can I disable **Windows Defender** on Windows 10/11?
- A: The **Disable Windows Defender** toggle is working only on Windows 7/8/8.1.
In order to effectively disable **Windows Defender** on Windows 10/11 you need to restart in safe-mode.
You may easily do this just by executing the app with ```/restart=disabledefender```. This command
will automatically restart in safe-mode, disable **Windows Defender** and finally restart normally again.
You may anytime enable **Windows Defender** again with ```/restart=enabledefender```.

- Q: Should I disable **System Restore**?
- A: It's up to you, but keep in mind that by disabling it your current backups will get deleted.

- Q: Should I disable **Print Service** or **Fax Service**?
- A: In case you are actively using printer and/or fax devices, you shouldn't disable them.

- Q: My digital pen is not working, why?
- A: Reset **Disable Windows Ink**, restart your computer and your pen should be functional again.

- Q: My clipboard history stopped working, why?
- A: Reset **Disable Cloud Clipboard** and it's should be fine.

- Q: Should I disable **Sensor Services**?
- A: If your device is a tablet, has various sensors (proximity, auto-brightness, etc) or a touch-screen, you shouldn't disable this.