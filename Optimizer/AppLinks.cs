using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    public class AppLinks
    {
        public AppInfo Chromium = new AppInfo();
        public AppInfo Firefox = new AppInfo();
        public AppInfo Vivaldi = new AppInfo();
        public AppInfo Chrome = new AppInfo();
        public AppInfo Opera = new AppInfo();

        public AppInfo VLC = new AppInfo();
        public AppInfo PotPlayer = new AppInfo();
        public AppInfo Foobar2000 = new AppInfo();
        public AppInfo BSPlayer = new AppInfo();
        public AppInfo IrfanView = new AppInfo();
        public AppInfo PhotoFiltre = new AppInfo();

        public AppInfo SevenZip = new AppInfo();
        public AppInfo PeaZip = new AppInfo();
        public AppInfo WinRAR = new AppInfo();

        public AppInfo SumatraPDF = new AppInfo();
        public AppInfo Foxit = new AppInfo();
        public AppInfo AdobeReader = new AppInfo();

        public AppInfo Discord = new AppInfo();
        public AppInfo Skype = new AppInfo();
        public AppInfo Viber = new AppInfo();
        public AppInfo Thunderbird = new AppInfo();

        public AppInfo NotepadPP = new AppInfo();
        public AppInfo SublimeText = new AppInfo();
        public AppInfo VSCode = new AppInfo();
        public AppInfo Atom = new AppInfo();
        public AppInfo VS = new AppInfo();
        public AppInfo SublimeMerge = new AppInfo();

        public AppInfo QBitTorrent = new AppInfo();
        public AppInfo Deluge = new AppInfo();
        public AppInfo UTorrent = new AppInfo();
        public AppInfo BitTorrent = new AppInfo();

        public AppInfo Putty = new AppInfo();
        public AppInfo FileZilla = new AppInfo();
        public AppInfo GitHub = new AppInfo();
        public AppInfo NodeJS = new AppInfo();
        public AppInfo XAMPP = new AppInfo();
        public AppInfo Postman = new AppInfo();

        public List<AppInfo> Apps = new List<AppInfo>();

        public AppLinks()
        {
            // BROWSERS
            Chromium.Title = "Chromium";
            Chromium.Link64 = new Uri("https://github.com/Hibbiki/chromium-win64/releases/download/v87.0.4280.88-r812852/mini_installer.sync.exe");
            Chromium.Link = new Uri("https://github.com/Hibbiki/chromium-win32/releases/download/v87.0.4280.88-r812852/mini_installer.sync.exe");
            Chromium.Tag = "cChromium";

            Firefox.Title = "Mozilla Firefox";
            Firefox.Link64 = new Uri("https://ftp.mozilla.org/pub/firefox/releases/84.0/win64/en-US/Firefox%20Setup%2084.0.exe");
            Firefox.Link = new Uri("https://ftp.mozilla.org/pub/firefox/releases/84.0/win32/en-US/Firefox%20Setup%2084.0.exe");
            Firefox.Tag = "cFirefox";

            Vivaldi.Title = "Vivaldi";
            Vivaldi.Link64 = new Uri("https://downloads.vivaldi.com/stable/Vivaldi.3.5.2115.81.x64.exe");
            Vivaldi.Link = new Uri("https://downloads.vivaldi.com/stable/Vivaldi.3.5.2115.81.exe");
            Vivaldi.Tag = "cVivaldi";

            Chrome.Title = "Google Chrome";
            Chrome.Link64 = new Uri("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BFD62DDBC-14C6-20BD-706F-C7744738E422%7D%26lang%3Den%26browser%3D3%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/chrome/install/ChromeStandaloneSetup64.exe");
            Chrome.Link = new Uri("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BFD62DDBC-14C6-20BD-706F-C7744738E422%7D%26lang%3Den%26browser%3D3%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dstable-arch_x86-statsdef_1%26installdataindex%3Dempty/chrome/install/ChromeStandaloneSetup.exe");
            Chrome.Tag = "cChrome";

            Opera.Title = "Opera";
            Opera.Link64 = new Uri("https://www.opera.com/download/get/?partner=www&opsys=Windows&arch=x64");
            Opera.Link = new Uri("https://www.opera.com/download/get/?partner=www&opsys=Windows");
            Opera.Tag = "cOpera";

            // ARCHIVING
            SevenZip.Title = "7-Zip";
            SevenZip.Link64 = new Uri("https://www.7-zip.org/a/7z1900-x64.exe");
            SevenZip.Link = new Uri("https://www.7-zip.org/a/7z1900.exe");
            SevenZip.Tag = "c7zip";

            PeaZip.Title = "PeaZip";
            PeaZip.Link64 = new Uri("https://github.com/peazip/PeaZip/releases/download/7.6.0/peazip-7.6.0.WIN64.exe");
            PeaZip.Link = new Uri("https://github.com/peazip/PeaZip/releases/download/7.6.0/peazip-7.6.0.WINDOWS.exe");
            PeaZip.Tag = "cPeaZip";

            WinRAR.Title = "WinRAR";
            WinRAR.Link64 = new Uri("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-600.exe");
            WinRAR.Link = new Uri("https://www.win-rar.com/fileadmin/winrar-versions/winrar/wrar600.exe");
            WinRAR.Tag = "cWinRar";

            // MEDIA PLAYERS
            VLC.Title = "VLC Media Player";
            VLC.Link64 = new Uri("https://get.videolan.org/vlc/3.0.11/win64/vlc-3.0.11-win64.exe");
            VLC.Link = new Uri("https://get.videolan.org/vlc/3.0.11/win32/vlc-3.0.11-win32.exe");
            VLC.Tag = "cVLC";

            PotPlayer.Title = "PotPlayer";
            PotPlayer.Link64 = new Uri("https://t1.daumcdn.net/potplayer/PotPlayer/Version/Latest/PotPlayerSetup64.exe");
            PotPlayer.Link = new Uri("https://t1.daumcdn.net/potplayer/PotPlayer/Version/Latest/PotPlayerSetup.exe");
            PotPlayer.Tag = "cPot";

            Foobar2000.Title = "Foobar2000";
            Foobar2000.Link = new Uri("https://www.foobar2000.org/files/eb9257c7785d4241dc9137edb3d4bfde/foobar2000_v1.6.2.exe");
            Foobar2000.Tag = "cFoobar";

            BSPlayer.Title = "BS.Player";
            BSPlayer.Link = new Uri("http://download11.bsplayer.com/download/file/mirror1/bsplayer276.setup.exe");
            BSPlayer.Tag = "cBS";

            IrfanView.Title = "IrfanView";
            IrfanView.Link = new Uri("http://download.betanews.com/download/967963863-1/iview456_setup.exe");
            IrfanView.Tag = "cIrfan";

            PhotoFiltre.Title = "PhotoFiltre";
            PhotoFiltre.Link = new Uri("http://static.infomaniak.ch/photofiltre/utils/pf7/pf7-setup-en-7.2.1.exe");
            PhotoFiltre.Tag = "cPhotoFiltre";

            // E-READERS
            SumatraPDF.Title = "SumatraPDF";
            SumatraPDF.Link64 = new Uri("https://www.sumatrapdfreader.org/dl2/SumatraPDF-3.2-64-install.exe");
            SumatraPDF.Link = new Uri("https://www.sumatrapdfreader.org/dl2/SumatraPDF-3.2-install.exe");
            SumatraPDF.Tag = "cSumatra";

            Foxit.Title = "Foxit Reader";
            Foxit.Link = new Uri("https://cdn01.foxitsoftware.com/product/reader/desktop/win/10.1.1/FoxitReader1011_enu_Setup_Prom.exe");
            Foxit.Tag = "cFoxit";

            AdobeReader.Title = "Adobe Reader";
            AdobeReader.Link = new Uri("https://ardownload2.adobe.com/pub/adobe/reader/win/AcrobatDC/2001320074/AcroRdrDC2001320074_en_US.exe");
            AdobeReader.Tag = "cAdobeReader";

            // COMMUNICATION
            Discord.Title = "Discord";
            Discord.Link = new Uri("https://dl.discordapp.net/apps/win/0.0.309/DiscordSetup.exe");
            Discord.Tag = "cDiscord";

            Skype.Title = "Skype";
            Skype.Link = new Uri("https://download.skype.com/s4l/download/win/Skype-8.67.0.96.exe");
            Skype.Tag = "cSkype";

            Viber.Title = "Viber";
            Viber.Link = new Uri("https://download.cdn.viber.com/desktop/windows/ViberSetup.exe");
            Viber.Tag = "cViber";

            Thunderbird.Title = "Thunderbird";
            Thunderbird.Link = new Uri("https://download-installer.cdn.mozilla.net/pub/thunderbird/releases/78.6.0/win32/en-US/Thunderbird%20Setup%2078.6.0.exe");
            Thunderbird.Tag = "cThunderbird";

            // TEXT EDITORS & IDEs
            NotepadPP.Title = "Notepad++";
            NotepadPP.Link = new Uri("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v7.9.1/npp.7.9.1.Installer.exe");
            NotepadPP.Tag = "cNPP";

            SublimeText.Title = "Sublime Text";
            SublimeText.Link64 = new Uri("https://download.sublimetext.com/Sublime%20Text%20Build%203211%20x64%20Setup.exe");
            SublimeText.Link = new Uri("https://download.sublimetext.com/Sublime%20Text%20Build%203211%20Setup.exe");
            SublimeText.Tag = "cSublimeText";

            VSCode.Title = "Visual Studio Code";
            VSCode.Link64 = new Uri("https://az764295.vo.msecnd.net/stable/940b5f4bb5fa47866a54529ed759d95d09ee80be/VSCodeUserSetup-x64-1.52.0.exe");
            VSCode.Link = new Uri("https://az764295.vo.msecnd.net/stable/940b5f4bb5fa47866a54529ed759d95d09ee80be/VSCodeUserSetup-ia32-1.52.0.exe");
            VSCode.Tag = "cVSCode";

            Atom.Title = "Atom";
            Atom.Link64 = new Uri("https://github.com/atom/atom/releases/download/v1.53.0/AtomSetup-x64.exe");
            Atom.Link = new Uri("https://github.com/atom/atom/releases/download/v1.53.0/AtomSetup.exe");
            Atom.Tag = "cAtom";

            VS.Title = "Visual Studio";
            VS.Link = new Uri("https://download.visualstudio.microsoft.com/download/pr/9b3476ff-6d0a-4ff8-956d-270147f21cd4/76e39c746d9e2fc3eadd003b5b11440bcf926f3948fb2df14d5938a1a8b2b32f/vs_Community.exe");
            VS.Tag = "cVS";

            SublimeMerge.Title = "Sublime Merge";
            SublimeMerge.Link64 = new Uri("https://download.sublimetext.com/sublime_merge_build_2039_x64_setup.exe");
            SublimeMerge.Tag = "cSublimeMerge";

            // TORRENTING
            QBitTorrent.Title = "qBitTorrent";
            QBitTorrent.Link64 = new Uri("https://vorboss.dl.sourceforge.net/project/qbittorrent/qbittorrent-win32/qbittorrent-4.3.1/qbittorrent_4.3.1_x64_setup.exe");
            QBitTorrent.Link = new Uri("https://kumisystems.dl.sourceforge.net/project/qbittorrent/qbittorrent-win32/qbittorrent-4.3.1/qbittorrent_4.3.1_setup.exe");
            QBitTorrent.Tag = "cQB";

            Deluge.Title = "Deluge";
            Deluge.Link = new Uri("https://ftp.osuosl.org/pub/deluge/windows/deluge-1.3.15-win32-py2.7.exe");
            Deluge.Tag = "cDeluge";

            UTorrent.Title = "uTorrent";
            UTorrent.Link = new Uri("https://download-hr.utorrent.com/track/stable/endpoint/utorrent/os/windows");
            UTorrent.Tag = "cUT";

            BitTorrent.Title = "BitTorrent";
            BitTorrent.Link = new Uri("https://download-new.utorrent.com/endpoint/bittorrent/os/windows/track/stable/");
            BitTorrent.Tag = "cBT";

            // CODING TOOLS
            Putty.Title = "Putty";
            Putty.Link64 = new Uri("https://the.earth.li/~sgtatham/putty/latest/w64/putty-64bit-0.74-installer.msi");
            Putty.Link = new Uri("https://the.earth.li/~sgtatham/putty/latest/w32/putty-0.74-installer.msi");
            Putty.Tag = "cPutty";

            FileZilla.Title = "FileZilla";
            FileZilla.Link64 = new Uri("https://download.filezilla-project.org/client/FileZilla_3.51.0_win64-setup.exe");
            FileZilla.Link = new Uri("https://download.filezilla-project.org/client/FileZilla_3.51.0_win32-setup.exe");
            FileZilla.Tag = "cFileZilla";

            GitHub.Title = "GitHub";
            GitHub.Link = new Uri("https://desktop.githubusercontent.com/releases/2.6.1-afb56263/GitHubDesktopSetup.exe");
            GitHub.Tag = "cGitHub";

            NodeJS.Title = "NodeJS";
            NodeJS.Link = new Uri("https://nodejs.org/dist/v14.15.2/node-v14.15.2-x64.msi");
            NodeJS.Tag = "cNode";

            XAMPP.Title = "XAMPP";
            XAMPP.Link64 = new Uri("https://downloadsapachefriends.global.ssl.fastly.net/8.0.0/xampp-windows-x64-8.0.0-2-VS16-installer.exe");
            XAMPP.Tag = "cXAMPP";

            Postman.Title = "Postman";
            Postman.Link64 = new Uri("https://dl.pstmn.io/download/latest/win64");
            Postman.Link = new Uri("https://dl.pstmn.io/download/latest/win32");
            Postman.Tag = "cPostman";

            CreateList();
        }

        private void CreateList()
        {
            Apps.Add(Chromium);
            Apps.Add(Firefox);
            Apps.Add(Vivaldi);
            Apps.Add(Chrome);
            Apps.Add(Opera);
            Apps.Add(SevenZip);
            Apps.Add(PeaZip);
            Apps.Add(WinRAR);
            Apps.Add(VLC);
            Apps.Add(PotPlayer);
            Apps.Add(Foobar2000);
            Apps.Add(BSPlayer);
            Apps.Add(IrfanView);
            Apps.Add(PhotoFiltre);
            Apps.Add(SumatraPDF);
            Apps.Add(Foxit);
            Apps.Add(AdobeReader);
            Apps.Add(Discord);
            Apps.Add(Skype);
            Apps.Add(Viber);
            Apps.Add(Thunderbird);
            Apps.Add(QBitTorrent);
            Apps.Add(Deluge);
            Apps.Add(UTorrent);
            Apps.Add(BitTorrent);
            Apps.Add(NotepadPP);
            Apps.Add(SublimeMerge);
            Apps.Add(VSCode);
            Apps.Add(Atom);
            Apps.Add(VS);
            Apps.Add(SublimeText);
            Apps.Add(Putty);
            Apps.Add(FileZilla);
            Apps.Add(GitHub);
            Apps.Add(NodeJS);
            Apps.Add(XAMPP);
            Apps.Add(Postman);
        }
    }
}
