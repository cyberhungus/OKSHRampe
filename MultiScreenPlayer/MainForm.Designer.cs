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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

