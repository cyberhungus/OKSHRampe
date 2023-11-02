using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MultiScreenPlayer
{
    public partial class MediaPlayerWindow : Form
    {
        String path = "";

        int runtimeSeconds = 10;

        Thread StopMediaThread;

        bool playerVisible = false;


        
        public MediaPlayerWindow(string path, int screen, int playTime = 10)
        {
            InitializeComponent();
            this.path = path;
            if (Screen.AllScreens.Length > 1 ) { this.Location = Screen.AllScreens[screen].WorkingArea.Location; }
            
            Thread.Sleep(500);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Console.WriteLine("Starting Media Player - " + path);
            MediaPlayer.URL = System.IO.Directory.GetCurrentDirectory() + path;
            MediaPlayer.settings.setMode("Loop", true);

            StopMediaThread = new Thread(new ThreadStart(stopMediaWorker));
            runtimeSeconds = playTime;
        }

        private void stopMediaWorker()
        {
            Console.WriteLine("Media Stopping Thread Started");
            Thread.Sleep(runtimeSeconds * 1000);
            this.stopMedia();
            Console.WriteLine("Media was stopped by thread");
            StopMediaThread.Join();
            
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
            {
                MediaPlayer.uiMode = "none";
                MediaPlayer.fullScreen = true;
            }
            if (e.newState == 8)
            {
                Console.WriteLine("play finished");
            }
        }

        public void playMedia()
        {
            
            MediaPlayer.Ctlcontrols.play();
            playerVisible = true;
            StopMediaThread = new Thread(new ThreadStart(stopMediaWorker));
            StopMediaThread.Start();
            try
            {
                MediaPlayer.fullScreen = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Playback Error");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("playing" + path );
        }

        public void stopMedia()
        {

            MediaPlayer.Ctlcontrols.stop();
            playerVisible = false;

            Console.WriteLine("stopping" + path);
        }



        public bool getPlayState()
        {
            int state = (int)MediaPlayer.playState;
            if (state == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void uiUpdateTimer_Tick(object sender, EventArgs e)
        {
            MediaPlayer.Visible = playerVisible;
        }
    }
}
