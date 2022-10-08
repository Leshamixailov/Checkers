using System;
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

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen Black = new Pen(Color.Green, 1);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int countHorizontal = pictureBox1.Width / 8;
            int countVertical = pictureBox1.Height / 8;
           
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                for (int i = 0; i < countHorizontal; i++)
                {
                    for (int j = 0; j < countVertical; j++)
                    {
                        if (i%2==1 )
                        {   if (j % 2 == 1)
                            {
                                g.FillRectangle(Brushes.Black, i * 100, j * 100, 100, 100);
                                g.DrawRectangle(Black, i * 100, j * 100, 100, 100);
                            }
                         
                        }
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                g.FillRectangle(Brushes.Black, i * 100, j * 100, 100, 100);
                                g.DrawRectangle(Black, i * 100, j * 100, 100, 100);
                            }
                        }

                    }
                }
            }
            
        }
    }
}
