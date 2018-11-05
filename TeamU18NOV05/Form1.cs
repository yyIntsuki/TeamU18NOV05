using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamU18NOV05.DomainModel.Abstract;
using TeamU18NOV05.DomainModel.Concrete;

namespace TeamU18NOV05
{
    public partial class Form1 : Form
    {
        private IOperate blueray;
        private IOperate dvd;
        private IOperate video;

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
            button1.Click += new EventHandler(videoPlay);
            button3.Text = "PLAY";
            button3.Click += new EventHandler(dvdPlay);
            button5.Text = "PLAY";
            button5.Click += new EventHandler(blurayPlay);

            button2.Text = "STOP";
            button2.Click += new EventHandler(videoStop);
            button4.Text = "STOP";
            button4.Click += new EventHandler(dvdStop);
            button6.Text = "STOP";
            button6.Click += new EventHandler(blurayStop);

            dvd = new DVD();
            video = new Video();
            blueray = new BluRay();
        }

        private void videoPlay(object sender, EventArgs e)
        {
            label4.Text = video.Play();
        }

        private void dvdPlay(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void blurayPlay(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void videoStop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dvdStop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void blurayStop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
