using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Video MyVideo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyVideo = new Video(openFileDialog1.FileName);

               



                if (MyVideo.Playing == true)
                {
                    MyVideo.Stop();
                    MyVideo.Audio.Stop();
                    MyVideo.Dispose();
                }
                else
                {

                    MyVideo.Open(openFileDialog1.FileName);

                    
                    MyVideo.Owner = panel1;
                    MyVideo.Owner.Width = 320;
                    MyVideo.Owner.Height = 240;
                    
                    MyVideo.Play();

                }

            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (MyVideo.Playing == true)
            {
                MyVideo.Stop();
                MyVideo.Audio.Stop();
                MyVideo.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MyVideo.Playing==false)
            {
                MyVideo.Play();
            }
        }
    }

}
