namespace MultiScreenPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelArduinoA = new System.Windows.Forms.Label();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TestButtonA = new System.Windows.Forms.Button();
            this.TestButtonB = new System.Windows.Forms.Button();
            this.TestButtonC = new System.Windows.Forms.Button();
            this.TestAllButton = new System.Windows.Forms.Button();
            this.LightServoLabel = new System.Windows.Forms.Label();
            this.AudioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.ResetButton = new System.Windows.Forms.Button();
            this.uiUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SerialTestButton1 = new System.Windows.Forms.Button();
            this.SerialTestButton2 = new System.Windows.Forms.Button();
            this.SerialTestButton3 = new System.Windows.Forms.Button();
            this.SerialTestButton4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AudioPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelArduinoA
            // 
            this.LabelArduinoA.AutoSize = true;
            this.LabelArduinoA.Location = new System.Drawing.Point(35, 13);
            this.LabelArduinoA.Name = "LabelArduinoA";
            this.LabelArduinoA.Size = new System.Drawing.Size(291, 32);
            this.LabelArduinoA.TabIndex = 0;
            this.LabelArduinoA.Text = "Connection Arduino A";
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.Location = new System.Drawing.Point(35, 45);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(301, 32);
            this.ReceivedLabel.TabIndex = 1;
            this.ReceivedLabel.Text = "No Arduino Connected";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(41, 145);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(211, 68);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TestButtonA
            // 
            this.TestButtonA.Location = new System.Drawing.Point(41, 340);
            this.TestButtonA.Name = "TestButtonA";
            this.TestButtonA.Size = new System.Drawing.Size(211, 68);
            this.TestButtonA.TabIndex = 5;
            this.TestButtonA.Text = "TestA";
            this.TestButtonA.UseVisualStyleBackColor = true;
            this.TestButtonA.Click += new System.EventHandler(this.TestButtonA_Click);
            // 
            // TestButtonB
            // 
            this.TestButtonB.Location = new System.Drawing.Point(258, 340);
            this.TestButtonB.Name = "TestButtonB";
            this.TestButtonB.Size = new System.Drawing.Size(211, 68);
            this.TestButtonB.TabIndex = 6;
            this.TestButtonB.Text = "TestB";
            this.TestButtonB.UseVisualStyleBackColor = true;
            this.TestButtonB.Click += new System.EventHandler(this.TestButtonB_Click);
            // 
            // TestButtonC
            // 
            this.TestButtonC.Location = new System.Drawing.Point(475, 340);
            this.TestButtonC.Name = "TestButtonC";
            this.TestButtonC.Size = new System.Drawing.Size(115, 68);
            this.TestButtonC.TabIndex = 7;
            this.TestButtonC.Text = "TestC";
            this.TestButtonC.UseVisualStyleBackColor = true;
            this.TestButtonC.Click += new System.EventHandler(this.TestButtonC_Click);
            // 
            // TestAllButton
            // 
            this.TestAllButton.Location = new System.Drawing.Point(41, 266);
            this.TestAllButton.Name = "TestAllButton";
            this.TestAllButton.Size = new System.Drawing.Size(645, 68);
            this.TestAllButton.TabIndex = 8;
            this.TestAllButton.Text = "Test All";
            this.TestAllButton.UseVisualStyleBackColor = true;
            this.TestAllButton.Click += new System.EventHandler(this.TestAllButton_Click);
            // 
            // LightServoLabel
            // 
            this.LightServoLabel.AutoSize = true;
            this.LightServoLabel.Location = new System.Drawing.Point(41, 81);
            this.LightServoLabel.Name = "LightServoLabel";
            this.LightServoLabel.Size = new System.Drawing.Size(92, 32);
            this.LightServoLabel.TabIndex = 9;
            this.LightServoLabel.Text = "label1";
            // 
            // AudioPlayer
            // 
            this.AudioPlayer.Enabled = true;
            this.AudioPlayer.Location = new System.Drawing.Point(605, 12);
            this.AudioPlayer.Name = "AudioPlayer";
            this.AudioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AudioPlayer.OcxState")));
            this.AudioPlayer.Size = new System.Drawing.Size(183, 50);
            this.AudioPlayer.TabIndex = 10;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(605, 340);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(183, 68);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Test Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // uiUpdateTimer
            // 
            this.uiUpdateTimer.Enabled = true;
            this.uiUpdateTimer.Interval = 1000;
            this.uiUpdateTimer.Tick += new System.EventHandler(this.uiUpdateTimer_Tick);
            // 
            // SerialTestButton1
            // 
            this.SerialTestButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialTestButton1.Location = new System.Drawing.Point(280, 145);
            this.SerialTestButton1.Name = "SerialTestButton1";
            this.SerialTestButton1.Size = new System.Drawing.Size(83, 68);
            this.SerialTestButton1.TabIndex = 12;
            this.SerialTestButton1.Text = "Serial Test A";
            this.SerialTestButton1.UseVisualStyleBackColor = true;
            this.SerialTestButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerialTestButton2
            // 
            this.SerialTestButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialTestButton2.Location = new System.Drawing.Point(369, 150);
            this.SerialTestButton2.Name = "SerialTestButton2";
            this.SerialTestButton2.Size = new System.Drawing.Size(83, 68);
            this.SerialTestButton2.TabIndex = 13;
            this.SerialTestButton2.Text = "Serial Test B";
            this.SerialTestButton2.UseVisualStyleBackColor = true;
            this.SerialTestButton2.Click += new System.EventHandler(this.SerialTestButton2_Click);
            // 
            // SerialTestButton3
            // 
            this.SerialTestButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialTestButton3.Location = new System.Drawing.Point(458, 150);
            this.SerialTestButton3.Name = "SerialTestButton3";
            this.SerialTestButton3.Size = new System.Drawing.Size(83, 68);
            this.SerialTestButton3.TabIndex = 14;
            this.SerialTestButton3.Text = "Serial Test C";
            this.SerialTestButton3.UseVisualStyleBackColor = true;
            this.SerialTestButton3.Click += new System.EventHandler(this.SerialTestButton3_Click);
            // 
            // SerialTestButton4
            // 
            this.SerialTestButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialTestButton4.Location = new System.Drawing.Point(547, 150);
            this.SerialTestButton4.Name = "SerialTestButton4";
            this.SerialTestButton4.Size = new System.Drawing.Size(83, 68);
            this.SerialTestButton4.TabIndex = 15;
            this.SerialTestButton4.Text = "Serial Test D";
            this.SerialTestButton4.UseVisualStyleBackColor = true;
            this.SerialTestButton4.Click += new System.EventHandler(this.SerialTestButton4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SerialTestButton4);
            this.Controls.Add(this.SerialTestButton3);
            this.Controls.Add(this.SerialTestButton2);
            this.Controls.Add(this.SerialTestButton1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AudioPlayer);
            this.Controls.Add(this.LightServoLabel);
            this.Controls.Add(this.TestAllButton);
            this.Controls.Add(this.TestButtonC);
            this.Controls.Add(this.TestButtonB);
            this.Controls.Add(this.TestButtonA);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ReceivedLabel);
            this.Controls.Add(this.LabelArduinoA);
            this.Name = "MainForm";
            this.Text = "MultiScreenPlayer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AudioPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelArduinoA;
        private System.Windows.Forms.Label ReceivedLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button TestButtonA;
        private System.Windows.Forms.Button TestButtonB;
        private System.Windows.Forms.Button TestButtonC;
        private System.Windows.Forms.Button TestAllButton;
        private System.Windows.Forms.Label LightServoLabel;
        private AxWMPLib.AxWindowsMediaPlayer AudioPlayer;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer uiUpdateTimer;
        private System.Windows.Forms.Button SerialTestButton1;
        private System.Windows.Forms.Button SerialTestButton2;
        private System.Windows.Forms.Button SerialTestButton3;
        private System.Windows.Forms.Button SerialTestButton4;
    }
}

