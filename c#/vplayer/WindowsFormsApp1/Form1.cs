using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Text = '\u23f9'.ToString();
            button3.Text = '\u23f5'.ToString();

            button4.Text = '\u21e9'.ToString();
            button6.Text = '\u21E7'.ToString();
            button7.Text = '\u23f8'.ToString();
            

        }
       

        //Кнопка Добавить в плейлист
        private void button1_Click(object sender, EventArgs e)
        {
          if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
            //Проверка не воспроизводится ли другое видео
            if (MyVideo != null)
            {
                MyVideo.Dispose();
            }
            //------------------------//

            if (listBox1.SelectedIndex != -1)
            {
                VideoName = listBox1.SelectedItem.ToString();
                if (File.Exists(VideoName) != true)
                {
                    MessageBox.Show("Файл не найден!");
                }
                else
                {

                    if (VideoName != null)
                    {
                        //MessageBox.Show(VideoName);
                        MyVideo = new Video(VideoName);
                        MyVideo.Open(VideoName);
                        MyVideo.Owner = panel1;
                        MyVideo.Owner.Width = 640;
                        MyVideo.Owner.Height = 480;

                        //----------------------//                
                        trackBar2.Enabled = true;
                        MyVideo.Audio.Volume = -2000;

                        trackBar1.Enabled = true;

                        trackBar1.Maximum = Convert.ToInt32(MyVideo.Duration);

                        MyVideo.Play();
                        button2.Enabled = true;
                        button7.Enabled = true;
                        timer1.Enabled = true;
                        //--------------------//
                    }
                }


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
            //Проверка не воспроизводится ли другое видео
            if (MyVideo!=null)
            {
                MyVideo.Dispose();
            }
            //---------------------------//

            if (listBox1.SelectedIndex != -1)
            {
                VideoName = listBox1.SelectedItem.ToString();
                if (File.Exists(VideoName) != true)
                {
                    MessageBox.Show("Файл не найден!");
                }
                else
                {
                    if (VideoName != null)
                    {
                        MyVideo = new Video(VideoName);
                        MyVideo.Open(VideoName);
                        MyVideo.Owner = panel1;
                        MyVideo.Owner.Width = 640;
                        MyVideo.Owner.Height = 480;

                        //----------------------//                
                        trackBar2.Enabled = true;
                        MyVideo.Audio.Volume = -2000;

                        trackBar1.Enabled = true;

                        trackBar1.Maximum = Convert.ToInt32(MyVideo.Duration);

                        MyVideo.Play();
                        button2.Enabled = true;
                        button7.Enabled = true;
                        timer1.Enabled = true;
                        //--------------------//
                    }
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
            if (openFileDialog2.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.AddRange(File.ReadAllLines(openFileDialog2.FileName, Encoding.Default));
              
            }
        }

        //Регулятор звука
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            MyVideo.Audio.Volume = trackBar2.Value;
        }

        //Перемотка видео
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (MyVideo.Playing==true)
            {
                MyVideo.Pause();
                MyVideo.CurrentPosition = trackBar1.Value;
                MyVideo.Play();
            }
        }

        //Таймер для отображения позиции воспроизведения видео
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MyVideo.Playing==true)
            {
                trackBar1.Value = Convert.ToInt32(MyVideo.CurrentPosition);
            }
        }

        //Кнопка Пауза
        private void button7_Click(object sender, EventArgs e)
        {
            if (MyVideo.Playing==true)
            {
                MyVideo.Pause();
            }
            else
            { 
             MyVideo.Play();
            }
        }


        //На весь экран
        private void наВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyVideo!=null)
            {
                if (MyVideo.Fullscreen != true)
                {
                    MyVideo.Fullscreen = true;
                }
                else
                {
                    MyVideo.Fullscreen = false;
                }
            }
            
        }
    }

}
