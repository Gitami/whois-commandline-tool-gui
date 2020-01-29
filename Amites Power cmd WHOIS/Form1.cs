using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Amites_Power_cmd_WHOIS
{
    public partial class Form1 : Form
    {

        // ###### VERSION TRACKING #############################
            public static string versionNumber = "ver.:0.12-ALFA";
            public static string versionBuild = "Build 2009112801";
        // #####################################################


        // Class constructor
        public Form1()
        {
            InitializeComponent();
            versionLabel.Text = "" + versionNumber;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Domainnames.Lines.Length; i++)
            {
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "whois.exe " + Domainnames.Lines.GetValue(i).ToString());
                Process = Process.Start(ProcessInfo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ProcessInfo_CMDkill;
            Process Process_CMDkill;
            ProcessInfo_CMDkill = new ProcessStartInfo("cmd.exe", "/C " + "taskkill.exe " + "/F /IM cmd.exe /T");
            Process_CMDkill = Process.Start(ProcessInfo_CMDkill);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\r\n" + "Power tool for CMD Whois" + "\r\n" + "by Amite. " + "\r\n\r\n" + versionNumber + " | " + versionBuild, "About");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parses a list of domain names, line by line, to the Windows CMD prompt, where the "
                            + "whois.exe will run once for each domain, i.e. spawning a DOS window with the output for each."
                            + "You can use the KILL-button to termination all your CMD windows when you are done." + "\r\n\r\n"
                            + "NOTE: whois.exe is NOT included with this tool. You will have to download (Freeware) that separately.",
                              "Help");
        }

    }
}
