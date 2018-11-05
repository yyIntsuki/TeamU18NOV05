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
        private IOperate bluray;
        private IOperate dvd;
        private IOperate video;

        private BluRay bluray2 = new BluRay();
        private DVD johan2 = new DVD();

        public Form1()
        {
            InitializeComponent();

            label1.Text = "VIDEO";
            label2.Text = "DVD";
            label3.Text = "BLURAY";

            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

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

            button7.Text = "johan";
            button7.Click += new EventHandler(johan);
            button8.Text = "en ny knapp";
            button8.Click += new EventHandler(blurayBlu);
            button9.Text = "en ny knapp";
            button9.Click += new EventHandler(blurayBlu);

            dvd = new DVD();
            video = new Video();
            bluray = new BluRay();
        }

        private void johan(object sender, EventArgs e)
        {
            label4.Text = johan2.video();
        }

        private void blurayBlu(object sender, EventArgs e)
        {
            label6.Text = bluray2.Blue();
        }

        private void videoPlay(object sender, EventArgs e)
        {
            label4.Text = video.Play();
        }

        private void dvdPlay(object sender, EventArgs e)
        {
            label5.Text = dvd.Play();
        }

        private void blurayPlay(object sender, EventArgs e)
        {
            label6.Text = bluray.Play();
        }

        private void videoStop(object sender, EventArgs e)
        {
            label4.Text = video.Stop();
        }

        private void dvdStop(object sender, EventArgs e)
        {
            label5.Text = dvd.Stop();
        }

        private void blurayStop(object sender, EventArgs e)
        {
            label6.Text = bluray.Stop();
        }
    }
}
