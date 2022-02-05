using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_game_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movingline(gamespeed);
            enemy(3);
            coin(2);
            check();
        }

        int score = 0;
        void check()
        {
            if (car.Bounds.IntersectsWith(e1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
   
            }

            if (car.Bounds.IntersectsWith(e2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(e3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(c1.Bounds))
            {
                score += 1;
                label3.Text = "Cash = " + score;
                c1.Visible = false;
            }

            if (car.Bounds.IntersectsWith(c2.Bounds))
            {
                score += 1;
                label3.Text = "Cash = " + score;
                c2.Visible = false;
            }

            if (car.Bounds.IntersectsWith(c3.Bounds))
            {
                score += 1;
                label3.Text = "Cash = " + score;
                c3.Visible = false;
            }

            if (car.Bounds.IntersectsWith(c4.Bounds))
            {
                score += 1;
                label3.Text = $"Cash = { score}";
                c4.Visible = false;
            }

        }
        void movingline(int speed)
        {

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }


            if (c1.Top >= 500)
            {
                c1.Visible = true;
                c1.Top = 0;
            }
            else
            {
                c1.Top += speed;
            }

            if (c2.Top >= 500)
            {
                c2.Visible = true;
                c2.Top = 0;
            }
            else
            {
                c2.Top += speed;
            }

            if (c3.Top >= 500)
            {
                c3.Visible = true;
                c3.Top = 0;
            }
            else
            {
                c3.Top += speed;
            }

            if (c4.Top >= 500)
            {
                c4.Visible = true;
                c4.Top = 0;
            }
            else
            {
                c4.Top += speed;
            }
        }

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (e1.Top >= 500)
            {
                x = r.Next(0, 200);
                e1.Location = new Point(x, y);

            }
            else
            {
                e1.Top += speed;
            }

            if (e2.Top >= 500)
            {
                x = r.Next(0, 400);
                e2.Location = new Point(x, 0);
            }
            else
            {
                e2.Top += speed;
            }

            if (e3.Top >= 500)
            {
                x = r.Next(250, 350);
                e3.Location = new Point(x, 0);
            }
            else
            {
                e3.Top += speed;
            }
        }

        void coin(int speed)
        {
            if (c1.Top >= 500)
            {
                x = r.Next(0, 200);
                c1.Location = new Point(x, y);
                c1.Visible = true;
            }
            else
            {
                c1.Top += speed;
            }

            if (c2.Top >= 500)
            {
                x = r.Next(0, 400);
                c2.Location = new Point(x, 0);
                c2.Visible = true;
            }
            else
            {
                c2.Top += speed;
            }

            if (c3.Top >= 500)
            {
                x = r.Next(250, 350);
                c3.Location = new Point(x, 0);
                c3.Visible = true;
            }
            else
            {
                c3.Top += speed;
            }

            if (c4.Top >= 500)
            {
                x = r.Next(250, 350);
                c4.Location = new Point(x, 0);
                c4.Visible = true;
            }
            else
            {
                c4.Top += speed;
            }
        }

        int gamespeed = 5;



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left>0)
                car.Left += -15;
            }

            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<390)
                car.Left += 15;

            }

            if (e.KeyCode == Keys.Up){
                if (gamespeed<10)
                {
                    gamespeed++;
                }
            }


            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed >0)
                {
                    gamespeed--;
                }
            }
        }
    }
}
