using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame4
{
    public partial class Form1 : Form
    {
        int attempts = 1;
        Random rnd = new Random();
        List<Point> points = new List<Point>();
        PictureBox firstClick,
                   secondClick;
        public Form1()
        {
            InitializeComponent();
            SwapLocation();
        }

        #region ImageClick
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
            if (firstClick == null)
                firstClick = pictureBox1;
            else if(firstClick != null && secondClick == null && firstClick != pictureBox1)
                secondClick = pictureBox1;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._1;
            if (firstClick == null)
                firstClick = pictureBox2;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox2)
                secondClick = pictureBox2;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources._2;
            if (firstClick == null)
                firstClick = pictureBox3;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox3)
                secondClick = pictureBox3;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources._2;
            if (firstClick == null)
                firstClick = pictureBox4;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox4)
                secondClick = pictureBox4;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources._3;
            if (firstClick == null)
                firstClick = pictureBox5;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox5)
                secondClick = pictureBox5;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._3;
            if (firstClick == null)
                firstClick = pictureBox6;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox6)
                secondClick = pictureBox6;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources._4;
            if (firstClick == null)
                firstClick = pictureBox7;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox7)
                secondClick = pictureBox7;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources._4;
            if (firstClick == null)
                firstClick = pictureBox8;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox8)
                secondClick = pictureBox8;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources._5;
            if (firstClick == null)
                firstClick = pictureBox9;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox9)
                secondClick = pictureBox9;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources._5;
            if (firstClick == null)
                firstClick = pictureBox10;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox10)
                secondClick = pictureBox10;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources._6;
            if (firstClick == null)
                firstClick = pictureBox11;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox11)
                secondClick = pictureBox11;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources._6;
            if (firstClick == null)
                firstClick = pictureBox12;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox12)
                secondClick = pictureBox12;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources._7;
            if (firstClick == null)
                firstClick = pictureBox13;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox13)
                secondClick = pictureBox13;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources._7;
            if (firstClick == null)
                firstClick = pictureBox14;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox14)
                secondClick = pictureBox14;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources._8;
            if (firstClick == null)
                firstClick = pictureBox15;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox15)
                secondClick = pictureBox15;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources._8;
            if (firstClick == null)
                firstClick = pictureBox16;
            else if (firstClick != null && secondClick == null && firstClick != pictureBox16)
                secondClick = pictureBox16;
            CheckForWinner();
            if (firstClick != null && secondClick != null)
            {
                attempts++;
                if (secondClick.Tag == firstClick.Tag)
                {
                    firstClick.Enabled = false;
                    secondClick.Enabled = false;
                    secondClick = null;
                    firstClick = null;
                }
                else
                {
                    timer1.Start();
                }
            }
        }
        #endregion

        private void SwapLocation()
        {
            foreach(PictureBox pictureBox in Controls)
            {
                points.Add(pictureBox.Location);
            }
            foreach (PictureBox pictureBox in Controls)
            {
                int next = rnd.Next(points.Count);
                pictureBox.Location = points[next];
                points.Remove(points[next]);
            }
        }

        private void CheckForWinner()
        {
            PictureBox pictureBox;
            for (int i = 0; i < Controls.Count; i++)
            {
                pictureBox = Controls[i] as PictureBox;

                if (pictureBox != null && pictureBox.Image == null)
                    return;
            }

            MessageBox.Show($"You finished.Used {attempts} attempts.");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClick.Image = null;
            secondClick.Image = null;
            secondClick = null;
            firstClick = null;
        }
    }
}
