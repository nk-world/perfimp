namespace SpeedUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", "https://www.github.com/nk-world/perfimp");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", "https://www.github.com/nk-world/perfimp/issues");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update your Windows to the latest version so that your drivers are latest which improves speed.","Windows Update");
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\control.exe", "update");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Restarting your PC closes apps and makes your PC faster. Only open the necessary apps so that your PC won't slow down again. Please save your work and close all apps to avoid data loss. You might want to change startup items to set which apps can start automatically at startup. Are you sure you wanna restart?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Windows\\System32\\shutdown.exe", "/t 10 /r");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Restart cancled.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to kill onedrive sync?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Windows\\system32\\taskkill.exe", "/im OneDrive.exe /f");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancled");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:\\windows\\system32\\cmd.exe", "/c c:\\windows\\system32\\taskmgr.exe /0 /startup");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:\\windows\\system32\\cmd.exe", "/c start windowsdefender:");
        }
    }
}