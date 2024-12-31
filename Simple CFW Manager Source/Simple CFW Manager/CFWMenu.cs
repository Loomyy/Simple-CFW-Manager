using PS3Lib;
using PS3Lib.NET;
using System;
using System.Windows.Forms;

namespace Simple_CFW_Manager
{
    public partial class CFWMenu : Form
    {
        // This Program is for beginners with the PS3Lib.
        // This will show you the common API Usage and the program is focused on basic code for newbies in if - else statements.
        // Appreciate it have fun!


        public CFWMenu()
        {
            InitializeComponent();
            PS3.ChangeAPI(SelectAPI.ControlConsole); // Automatically uses CCAPI as Connection instead of TMAPI or others..
        }
        public static PS3API PS3 = new PS3API();
        private string title;
        public static uint ProcessID;
        public static uint[] processIDs;
        public static string snresult;
        private static string usage;
        public static string Info;
        public static string Status;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (PS3.ConnectTarget())
                {         
                    // Connect to CFW and receive Informations.
                    label6.Text = PS3.CCAPI.GetFirmwareType();
                    label5.Text = PS3.CCAPI.GetFirmwareVersion();
                    label8.Text = PS3.CCAPI.GetTemperatureCELL();
                    label7.Text = PS3.CCAPI.GetTemperatureRSX();
                    groupBox1.Enabled = true; // If CFW Sucessfully connects to Program enable groupbox to get Sys. Infos.
                    MessageBox.Show("Connected!", "Simple CFW Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error!", "Simple CFW Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!", "Simple CFW Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.ShutDown);
            }
            if (radioButton2.Checked)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.SoftReboot);
            }
            if (radioButton3.Checked)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.HardReboot);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.On);
            }
            if (radioButton8.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
            }
            if (radioButton7.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
            }

            if (radioButton4.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.On);
            }
            if (radioButton5.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Off);
            }
            if (radioButton6.Checked)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Blink);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
            }
            if (radioButton11.Checked)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            }
            if (radioButton12.Checked)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Triple);
            }
            if (radioButton13.Checked)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Continuous);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.WRONGWAY, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.CAUTION, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY3, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.ARROW, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.DIALOG, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.DIALOGSHADOW, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.HAND, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.POINTER, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PROGRESS, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.SLIDER, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 16)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY1, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 18)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY2, this.textBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 19)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, this.textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleID(textBox2.Text);
            PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.ARROWRIGHT, "Your CID got Changed.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // You can use this button to keep your CFW Infos up-to-date and check what you reach while in game (you have to attach eboot.bin tho)
            label6.Text = PS3.CCAPI.GetFirmwareType();
            label5.Text = PS3.CCAPI.GetFirmwareVersion();
            label8.Text = PS3.CCAPI.GetTemperatureCELL();
            label7.Text = PS3.CCAPI.GetTemperatureRSX();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
               
               // attachs to game.
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "Attached.\nby Simple CFW Manager");

            }
        }
    }
}
