﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Position[,] Position = new Position[9, 9];
        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {


            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {

                    Position[i, j] = new Position();
                    Position[i, j].x = i;
                    Position[i, j].y = j;
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            Position[i, j].Id = "Белая клетка";
                        }

                    }
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Position[i, j].Id = "Белая клетка";
                        }
                    }
                    if (Position[i, j].Id == "Пусто" && j >= 0 && j <= 2)
                    {
                        Position[i, j].Id = "Черная шашка";
                    }
                    if (Position[i, j].Id == "Пусто" && j >= 5 && j <= 7)
                    {
                        Position[i, j].Id = "Белая шашка";
                    }
                }
            }
            Pen Black = new Pen(Color.Black, 1);
            Pen Red = new Pen(Color.Red, 2);
            Pen Purple = new Pen(Color.Purple, 2);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int countHorizontal = pictureBox1.Width / 100;
            int countVertical = pictureBox1.Height / 100;
            Font font = new Font("Segoe UI", 10, FontStyle.Regular);

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                for (int i = 0; i < countHorizontal; i++)
                {
                    for (int j = 0; j < countVertical; j++)
                    {
                        if (i % 2 == 1)
                        {
                            if (j % 2 == 0)
                            {
                                g.FillRectangle(Brushes.Black, i * 100 + 20, j * 100 + 20, 100, 100);
                                g.DrawRectangle(Black, i * 100 + 20, j * 100 + 20, 100, 100);
                                if (Position[i, j].Id == "Черная шашка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 100 + 30, j * 100 + 30, 80, 80);
                                    g.DrawEllipse(Red, i * 100 + 30, j * 100 + 30, 80, 80);
                                }
                                if (Position[i, j].Id == "Белая шашка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 100 + 30, j * 100 + 30, 80, 80);
                                    g.DrawEllipse(Purple, i * 100 + 30, j * 100 + 30, 80, 80);
                                }
                            }

                        }
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 1)
                            {
                                g.FillRectangle(Brushes.Black, i * 100 + 20, j * 100 + 20, 100, 100);
                                g.DrawRectangle(Black, i * 100 + 20, j * 100 + 20, 100, 100);
                                if (Position[i, j].Id == "Черная шашка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 100 + 30, j * 100 + 30, 80, 80);
                                    g.DrawEllipse(Red, i * 100 + 30, j * 100 + 30, 80, 80);
                                }
                                if (Position[i, j].Id == "Белая шашка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 100 + 30, j * 100 + 30, 80, 80);
                                    g.DrawEllipse(Purple, i * 100 + 30, j * 100 + 30, 80, 80);
                                }
                            }
                            
                        }



                    }
                    char Letter = 'A';
                    for (int j = 0; j < countVertical; j++)
                    {
                        g.DrawString((8-j ).ToString(), font, Brushes.Black, 0, 20 + j * 100);
                        g.DrawString((Letter++).ToString(), font, Brushes.Black, 20 + j * 100, 0);
                    }

                   
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen Black = new Pen(Color.Green, 1);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int countHorizontal = pictureBox1.Width / 8;
            int countVertical = pictureBox1.Height / 8;
            Font font = new Font("Segoe UI", 10, FontStyle.Regular);

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                for (int i = 0; i < countHorizontal; i++)
                {
                    for (int j = 0; j < countVertical; j++)
                    {
                        if (i%2==1 )
                        {   if (j % 2 == 0)
                            {
                                g.FillRectangle(Brushes.Black, i * 100 + 20, j * 100 + 20, 100, 100);
                                g.DrawRectangle(Black, i * 100 + 20, j * 100 + 20, 100, 100);
                            }
                         
                        }
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 1)
                            {
                                g.FillRectangle(Brushes.Black, i * 100+20, j * 100 + 20, 100, 100);
                                g.DrawRectangle(Black, i * 100 + 20, j * 100 + 20, 100, 100);
                            }
                        }

                       
                       
                    }
                    char Letter = 'A';
                    for (int j = 0; j < countVertical; j++)
                    {
                        g.DrawString((j+1).ToString(), font, Brushes.Black, 0, 20 + j * 100);
                        g.DrawString((Letter++).ToString(), font, Brushes.Black, 20 + j * 100,0 );
                    }

                }
            }
            
        }
    }
}
