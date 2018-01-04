using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Optimizer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "O";
            string s2 = "Op";
            string s3 = "Opt";
            string s4 = "Opti";
            string s5 = "Optim";
            string s6 = "Optimi";
            string s7 = "Optimiz";
            string s8 = "Optimize";
            string s9 = "Optimizer";

            switch (l1.Text)
            {
                case "":
                    l1.Text = s1;
                    break;
                case "O":
                    l1.Text = s2;
                    break;
                case "Op":
                    l1.Text = s3;
                    break;
                case "Opt":
                    l1.Text = s4;
                    break;
                case "Opti":
                    l1.Text = s5;
                    break;
                case "Optim":
                    l1.Text = s6;
                    break;
                case "Optimi":
                    l1.Text = s7;
                    break;
                case "Optimiz":
                    l1.Text = s8;
                    break;
                case "Optimize":
                    l1.Text = s9;
                    t1.Stop();
                    t2.Start();
                    break;
                case "Optimizer":
                    l1.Text = s0;
                    break;
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "d";
            string s2 = "de";
            string s3 = "dea";
            string s4 = "dead";
            string s5 = "deadm";
            string s6 = "deadmo";
            string s7 = "deadmoo";
            string s8 = "deadmoon";
            string s9 = "deadmoon © ";
            string s10 = "deadmoon © 2";
            string s11 = "deadmoon © 20";
            string s12 = "deadmoon © 201";
            string s13 = "deadmoon © 2018";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "d":
                    l2.Text = s2;
                    break;
                case "de":
                    l2.Text = s3;
                    break;
                case "dea":
                    l2.Text = s4;
                    break;
                case "dead":
                    l2.Text = s5;
                    break;
                case "deadm":
                    l2.Text = s6;
                    break;
                case "deadmo":
                    l2.Text = s7;
                    break;
                case "deadmoo":
                    l2.Text = s8;
                    break;
                case "deadmoon":
                    l2.Text = s9;
                    break;
                case "deadmoon © ":
                    l2.Text = s10;
                    break;
                case "deadmoon © 2":
                    l2.Text = s11;
                    break;
                case "deadmoon © 20":
                    l2.Text = s12;
                    break;
                case "deadmoon © 201":
                    l2.Text = s13;
                    t2.Stop();
                    //t1.Start();
                    break;
                case "deadmoon © 2018":
                    l2.Text = s0;
                    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://carcinos.eu/deadmoon");
        }
    }
}
