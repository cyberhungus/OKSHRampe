using RobotUICSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreenPlayer
{
    public partial class MainForm : Form
    {
        MediaPlayerWindow MediaPlayerA;
        MediaPlayerWindow MediaPlayerB;

        SerialConnector SerialConnect;

        Thread ArduinoThread;

        //ist der arduino aktiv
        bool ArduinoActive = false;
        //string für ServoPosition und relay an
        String servoPosActive = "050";
        String relayActive = "100";
        //string für servo und relay aus
        String servoPosInactive = "090";
        String relayInactive = "000";

        String rec = "";

        Thread AudioAndServoStopper;
        int AudioAndServoStopTimeSeconds = 20;

        bool audioPlaying = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)

        {


            SerialConnect = new SerialConnector();



            Console.WriteLine("Load complete");
            MediaPlayerA = new MediaPlayerWindow("/Video/AnimationA.mp4", 0);
            MediaPlayerB = new MediaPlayerWindow("/Video/AnimationB.mp4", 1, 10);
          
            MediaPlayerA.Show();
            MediaPlayerB.Show();

            performScreenReset();

            autoConnectSerial();

            AudioPlayer.URL = System.IO.Directory.GetCurrentDirectory() + "/Audio/Applause.mp3";
            AudioPlayer.settings.setMode("Loop", true);
            AudioPlayer.Ctlcontrols.stop();

        }


        private void autoConnectSerial()
        {
            String[] AvailablePorts = SerialPort.GetPortNames();
            try
            {
                SerialConnect.setPort(AvailablePorts[0]);

                SerialConnect.openPort();
                SerialConnect.MessageReceivedEvent += ReceiveMessage;
        
                LabelArduinoA.BackColor = Color.Green;
                LabelArduinoA.Text = "COM: " + AvailablePorts[0];
                ArduinoThread = new Thread(new ThreadStart(ArduinoWorker));
                ArduinoThread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                LabelArduinoA.BackColor = Color.Red;
            }
            if (AvailablePorts.Length == 0)
            {
                LabelArduinoA.BackColor = Color.Red;
            }
        }
        private void turnOnLightandServo()
        {
            ArduinoActive = true;
           // LightServoLabel.Text = "Light and Servo ON";
        }

        private void turnOffLightandServo()
        {
            ArduinoActive = false;
          //  LightServoLabel.Text = "Light and Servo OFF";
        }

        private void ArduinoWorker()
        {
            while (true)
            {
                //  Console.WriteLine("Arduino RUnner");
                if (ArduinoActive == true)
                {
                    SerialConnect.sendMessage("<SYS-" + servoPosActive + "-" + relayActive + ">");

                }
                else
                {
                    SerialConnect.sendMessage("<SYS-" + servoPosInactive + "-" + relayInactive + ">");

                }
                Thread.Sleep(50);

            }
        }
        private void ReceiveMessage(object sender, MessageReceivedEventArgs e)
        {
            try
            {
                rec = e.Message.Substring(0, 6);
               // Console.WriteLine(DateTime.Now + "Received: *" + rec + "*");
                //ReceivedLabel.Text = e.Message;
                //<0000> = ALLE AUS <1000>
                //<0100> = 2. Sensor an

               // Console.WriteLine("compare algo: " + compareStrings(rec, "<0010>"));
                if (compareStrings(rec, "<1000>"))
                {
                    Console.WriteLine("sensor a triggered");
                    if (MediaPlayerA.getPlayState() == false)
                    {
                        MediaPlayerA.playMedia();
                        Console.WriteLine("started playback on screen A");
                    }
                }

                if (compareStrings(rec, "<0100>"))
                {
                    Console.WriteLine("sensor b triggered");
                    if (MediaPlayerB.getPlayState() == false)
                    {
                        MediaPlayerB.playMedia();
                    }
                }
                if (compareStrings(rec, "<0010>"))
                {
                    Console.WriteLine("sensor c triggered");
                    turnOnLightandServo();
                    startAudioPlayback();

                }
                if (compareStrings(rec, "<0001>"))
                {

                    performScreenReset();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void startAudioPlayback()
        {
            Console.WriteLine((int)AudioPlayer.playState);
            if (!audioPlaying)  {

                AudioPlayer.URL = System.IO.Directory.GetCurrentDirectory() + "/Audio/Applause.mp3";
                AudioPlayer.Ctlcontrols.play();
                audioPlaying = true;
                Console.WriteLine("Started Audio playback");
                AudioAndServoStopper = new Thread(new ThreadStart(ServoAudioRunner));
                AudioAndServoStopper.Start();
            }
        }

        private void ServoAudioRunner()
        {
            Thread.Sleep(AudioAndServoStopTimeSeconds * 1000);
            stopAudioPlayback();
            ArduinoActive = false;
        }

        private void stopAudioPlayback()
        {
            AudioPlayer.Ctlcontrols.stop();
            audioPlaying = false;
        }


        private void performScreenReset()
        {
            Console.WriteLine("Screen Reset Triggered");
            turnOffLightandServo();
            MediaPlayerA.stopMedia();
            MediaPlayerB.stopMedia();
            stopAudioPlayback();
           


        }

        private void TestButtonA_Click(object sender, EventArgs e)
        {
            MediaPlayerA.playMedia();
        }

        private void TestButtonB_Click(object sender, EventArgs e)
        {
            MediaPlayerB.playMedia();
        }

        private void TestButtonC_Click(object sender, EventArgs e)
        {
           turnOnLightandServo() ;
            startAudioPlayback();

        }

        private void TestAllButton_Click(object sender, EventArgs e)
        {
            MediaPlayerA.playMedia();
            MediaPlayerB.playMedia();
            turnOnLightandServo();
            startAudioPlayback();

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialConnect.shutdownPort();
            autoConnectSerial();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            performScreenReset();
        }
        bool compareStrings(String A, String B)
        {
            bool toReturn = false;
            //Console.WriteLine($"{A} {B}");
            //Console.WriteLine(A.Length +"- " + B.Length);
            if (A.Length == B.Length) {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == B[i]) {
                        toReturn = true; }
                    else { return false;
                         }
                }
                return toReturn;
            }
            else {  return false; }
        }

        private void uiUpdateTimer_Tick(object sender, EventArgs e)
        {
            ReceivedLabel.Text = rec;
            if (ArduinoActive) { LightServoLabel.Text = "Light and Servo ON"; }
            else
            {
                LightServoLabel.Text = "Light and Servo OFF";
            }
        }
    }

   
}
