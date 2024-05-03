## **Frequently Asked Questions (FAQ)**

Welcome to our FAQ section, where we address common queries and concerns regarding our application. We're here to help you make the most out of your experience. If you have a question that isn't covered here, please feel free to reach out to our support team.

### **Do I need to restart my computer for the changes to take effect?**
Absolutely. Restarting your computer is essential for the changes you've made through our application to be applied and fully functional.

### **Do I need to keep the app running in the background?**
No, you don't need to keep the app running in the background. Once you've enabled your preferred options, simply restart your computer to ensure the changes take effect.

### **My Desktop files and documents got suddenly deleted! Why?**
If you've experienced unexpected file and document deletions on your Desktop, it's possible that these deletions are related to uninstalling OneDrive. It's crucial to avoid uninstalling OneDrive on a Windows 10/11 system with a Microsoft-synced account setup. It's recommended to uninstall OneDrive only on a fresh Windows installation, before setting up your Microsoft account.

### **How can I disable Windows Defender on Windows 10/11?**
Please note that the "Disable Windows Defender" toggle is only functional on Windows 7/8/8.1 systems. To effectively disable Windows Defender on Windows 10/11, follow these steps:

1. Execute the app with the command `/restart=disabledefender`.
2. This will initiate a restart in safe mode, during which Windows Defender will be disabled.
3. After the safe mode restart, your system will restart in normal mode with Windows Defender disabled.
4. You can re-enable Windows Defender at any time using the command `/restart=enabledefender`.

### **My games stopped working or I am experiencing issues with them!**
You should reset "Enhance Privacy", "Disable Xbox Live", "Disable Game Bar" and restart your computer.
If the problem persists, you may open an issue.

### **Should I disable System Restore?**
The decision to disable System Restore is up to you. Keep in mind that disabling it will result in the deletion of your existing backups. Consider the implications and potential risks before making this choice.

### **Should I disable Print Service or Fax Service?**
If you actively use printer and/or fax devices, it's advisable not to disable these services. Disabling them might hinder your ability to use these devices effectively.

### **My Windows Hello stopped working! Why?**
You should reset the "Enhance Privacy" and restart your computer.

### **I cannot log in to Xbox Live! Why?**
If you're facing login issues with Xbox Live, follow these steps to troubleshoot:

1. Reset both the "Disable Xbox Live" and "Disable Game Bar" options within our application.
2. Restart your computer to ensure the changes take effect.
3. Attempt to log in to Xbox Live again.

### **My digital pen is not working, why?**
If your digital pen is not functioning, it might be related to the "Disable Windows Ink" setting. To resolve this:

1. Reset the "Disable Windows Ink" option in our application.
2. Restart your computer.
3. Your digital pen should now be functional again.

### **My clipboard history stopped working, why?**
If your clipboard history has stopped working, try these steps:

1. Reset the "Disable Cloud Clipboard" setting in our application.
2. Verify if the clipboard history is now functioning as expected.

### **My Phone Link suddenly stopped working!**
You should reset the "Enhance Privacy" and restart your computer.

### **Should I disable Sensor Services?**
If your device is a tablet, has various sensors (proximity, auto-brightness, etc.), or features a touch screen, it's recommended not to disable Sensor Services. These services likely contribute to the functionality of these features on your device.

### **Is my Anti-Virus going to detect anything wrong?**
Yes, it is possible. When disabling the telemetry services through this tool, one of the things it does is disables the Windows Malicious Software Removal Tool (MRT). You might get a Potentially Unwanted Modifications (PUM) alert from your anti-virus or malware scanner.

MalwareBytes labels certain system modifications as "Potentially Unwanted Modifications" (PUM) when they change default system settings or disable security features. The "PUM.Optional.DisableMRT" detection specifically relates to disabling the Windows Malicious Software Removal Tool (MRT). This tool is designed to enhance system performance and user privacy by limiting telemetry and automatic data collection, but these changes can also affect system security and functionality. However, most consumers will not notice any functionality changes.

Please keep in mind, this is only relevant for Windows Malicious Software Removal Tool and not Defender. You will still be able to run Defender quick-scans, full-scans, and etc. Microsoft most likely keeps MRT for redundancy, assurance, supplemental tool for recovery, and legacy support.

References: 
 - https://answers.microsoft.com/en-us/windows/forum/all/is-there-a-difference-between-windows-defender/ad27e697-8f96-4f0a-9731-58b132c2b9ab
 - https://www.reddit.com/r/Windows10/comments/1b3evt1/is_windows_malicious_software_removal_tool_good/


We hope these answers have provided clarity on common questions. If you require further assistance, please don't hesitate to reach out to our support team for personalized help.
