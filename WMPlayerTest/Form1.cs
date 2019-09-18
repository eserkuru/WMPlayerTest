using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using WMPLib;
using System.Windows.Input;

namespace WMPlayerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\Users\eser.kuru\source\repos\WMPlayerTest\WMPlayerTest\stretched\do1.wav"));
                c.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {

                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\Users\eser.kuru\source\repos\WMPlayerTest\WMPlayerTest\stretched\re1.wav"));
                c.Play();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                button1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                button2.PerformClick();
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                button1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                button2.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                button1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                button2.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
