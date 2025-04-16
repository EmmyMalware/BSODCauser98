using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BSODCauser98
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "I am running: " + Environment.OSVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Environment.OSVersion.VersionString.StartsWith("Microsoft Windows NT"))
            {
                if (MessageBox.Show("Sorry, this app is only for Windows 98 only!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

            else
            {
                if (MessageBox.Show("Are you sure you want to run this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process.Start("con/con");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // I made a mistake...
        }
    }
}
