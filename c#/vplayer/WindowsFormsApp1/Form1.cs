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
        string VideoName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
       

        //Кнопка Добавить в плейлист
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyVideo = new Video(openFileDialog1.FileName);

                VideoName = openFileDialog1.FileName;
                listBox1.Items.Add(VideoName);


               

            }
        }


        //Кнопка Удалить из плейлиста
        private void button5_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        //Кнопка STOP
        private void button2_Click(object sender, EventArgs e)
        {
            if (MyVideo.Playing == true)
            {
                trackBar2.Enabled = false;
                MyVideo.Stop();
               
               // MyVideo.Dispose();
            }
        }

        //Кнопка PLAY
        private void button3_Click(object sender, EventArgs e)
        {

            if (VideoName != null)
            {
                MyVideo.Open(VideoName);
                MyVideo.Owner = panel1;
                MyVideo.Owner.Width = 320;
                MyVideo.Owner.Height = 240;
                
                trackBar2.Enabled = true;
                MyVideo.Play();
            }
            
        }

        //Выбор видео из плейлиста
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                VideoName = listBox1.SelectedItem.ToString();
            }
        }

        //Двойной щелчок по файлу в списке
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                VideoName = listBox1.SelectedItem.ToString();
                if (VideoName != null)
                {
                    MyVideo.Open(VideoName);
                    MyVideo.Owner = panel1;
                    MyVideo.Owner.Width = 320;
                    MyVideo.Owner.Height = 240;

                    trackBar2.Enabled = true;
                    MyVideo.Play();
                }
            }
        }

        //Кнопка сохранить плейлист
        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var item in listBox1.Items)
                        SaveFile.WriteLine(item.ToString());
                }
            }
        }

        //Кнопка Загрузить плейлист
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
            
                MyVideo.Audio.Volume = trackBar2.Value;
            
        }
    }

}
