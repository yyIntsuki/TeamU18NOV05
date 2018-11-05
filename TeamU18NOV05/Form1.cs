using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamU18NOV05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "VIDEO";
            label2.Text = "DVD";
            label3.Text = "BLURAY";

            label4.Text = "VIDEOSTATUS";
            label5.Text = "DVDSTATUS";
            label6.Text = "BLURAYSTATUS";

            button1.Text = "PLAY";
            button3.Text = "PLAY";
            button5.Text = "PLAY";

            button2.Text = "STOP";
            button4.Text = "STOP";
            button6.Text = "STOP";
        }
    }
}
