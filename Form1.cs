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
        public Position[,] Position = new Position[9, 9];
        public bool move = true;//ход черных
        bool start=false;
        private string FinishGame = "";
        private bool Finish = false;
        Image image = new Bitmap("crown.png");
        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                start = true;
                FinishGame = "";
                Finish = false;
                for (int i = 0; i <= 8; i++)
                {
                    for (int j = 0; j <= 8; j++)
                    {

                        Position[i, j] = new Position();
                        Position[i, j].y = i;
                        Position[i, j].x = j;
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
                int countHorizontal = pictureBox1.Width / 75;
                int countVertical = pictureBox1.Height / 75;
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
                                    g.FillRectangle(Brushes.Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                    g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                    if (Position[i, j].Id == "Черная шашка")
                                    {
                                        g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                        g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                    }
                                    if (Position[i, j].Id == "Белая шашка")
                                    {
                                        g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                        g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                    }
                                }

                            }
                            if (i % 2 == 0)
                            {
                                if (j % 2 == 1)
                                {
                                    g.FillRectangle(Brushes.Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                    g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                    if (Position[i, j].Id == "Черная шашка")
                                    {
                                        g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                        g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                    }
                                    if (Position[i, j].Id == "Белая шашка")
                                    {
                                        g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                        g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                    }
                                }

                            }



                        }
                        char Letter = 'A';
                        for (int j = 0; j < countVertical; j++)
                        {
                            g.DrawString((8 - j).ToString(), font, Brushes.Black, 0, 20 + j * 75);
                            g.DrawString((Letter++).ToString(), font, Brushes.Black, 20 + j * 75, 0);
                        }



                    }
                }
            }
            catch (Exception ex)
            {

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
                                g.FillRectangle(Brushes.Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                            }
                         
                        }
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 1)
                            {
                                g.FillRectangle(Brushes.Black, i * 75+20, j * 75 + 20, 75, 75);
                                g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                            }
                        }

                       
                       
                    }
                    char Letter = 'A';
                    for (int j = 0; j < countVertical; j++)
                    {
                        g.DrawString((j+1).ToString(), font, Brushes.Black, 0, 20 + j * 75);
                        g.DrawString((Letter++).ToString(), font, Brushes.Black, 20 + j * 75,0 );
                    }

                }
            }
            
        }

        private void drawing()
        {
            try {

                if (Finish)
                    MessageBox.Show(FinishGame);
            Pen Black = new Pen(Color.Black, 1);
            Pen Red = new Pen(Color.Red, 2);
            Pen Red2 = new Pen(Color.Red, 4);
            Pen Purple = new Pen(Color.Purple, 2);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int countHorizontal = pictureBox1.Width / 75;
            int countVertical = pictureBox1.Height / 75;
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
                                g.FillRectangle(Brushes.Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                if (Position[i, j].Id == "Черная шашка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                    
                                }
                                if (Position[i, j].Id == "Белая шашка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                  
                                }
                                if (Position[i, j].Id == "Черная дамка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawImage(image, i * 75 + 40, j * 75 + 40, 35, 35);
                                }
                                if (Position[i, j].Id == "Белая дамка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawImage(image, i * 75 + 40, j * 75 + 40, 35, 35);
                                }
                                 if (Position[i, j].Possible == true)
                            {
                              
                                g.DrawRectangle(Red2, i * 75 + 20, j * 75 + 20, 75, 75);
                            }
                            }

                        }
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 1)
                            {
                                g.FillRectangle(Brushes.Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                                if (Position[i, j].Id == "Черная шашка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                }
                                if (Position[i, j].Id == "Белая шашка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                }
                                if (Position[i, j].Id == "Черная дамка")
                                {
                                    g.FillEllipse(Brushes.Brown, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Red, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawImage(image, i * 75 + 40, j * 75 + 40, 35, 35);
                                }
                                if (Position[i, j].Id == "Белая дамка")
                                {
                                    g.FillEllipse(Brushes.SkyBlue, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawEllipse(Purple, i * 75 + 30, j * 75 + 30, 55, 55);
                                    g.DrawImage(image, i * 75 + 40, j * 75 + 40, 35, 35);
                                }
                            }

                        }

                        if (Position[i, j].Id == "#")
                        {
                            g.FillRectangle(Brushes.Yellow, i * 75 + 20, j * 75 + 20, 75, 75);
                            g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                        }

                        if (Position[i, j].Id == "*")
                        {
                            g.FillRectangle(Brushes.Red, i * 75 + 20, j * 75 + 20, 75, 75);
                            g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                        }
                        if (Position[i, j].Id == "!")
                        {
                            g.FillRectangle(Brushes.Red, i * 75 + 20, j * 75 + 20, 75, 75);
                            g.DrawRectangle(Black, i * 75 + 20, j * 75 + 20, 75, 75);
                        }
                       if (Position[i, j].Possible == true)
                          {

                                g.DrawRectangle(Red2, i * 75 + 20, j * 75 + 20, 75, 75);
                          }
                        }
                    char Letter = 'A';
                    for (int j = 0; j < countVertical; j++)
                    {
                        g.DrawString((8 - j).ToString(), font, Brushes.Black, 0, 20 + j * 75);
                        g.DrawString((Letter++).ToString(), font, Brushes.Black, 20 + j * 75, 0);
                    }



                }
            }
            }
            catch (Exception ex)
            {
               
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            { 
            int x = e.X;
            int y = e.Y;
            int PositionX = (e.X - 20) / 75;
            int PositionY = (e.Y - 20) / 75;
            
            if (start)
            {

                drawing();
            }
            }
            catch (Exception ex)
            {
                
            }
        }
        private bool CheckerMove(Point to,Point from)
        {
            try
            { 
            Control();
            int XNew = from.X - to.X;
            int YNew = from.Y - to.Y;
            string Delta="";
            string Save = Position[to.X, to.Y].Id;
            if (!move)
            {
                label1.Text = "Ход красных";
             

            }
            else
            {
                label1.Text = "Ход синих";
 
            }

            if (XNew > 0 && YNew > 0)
                Delta = "DownRigth";
            if (XNew < 0 && YNew < 0)//
                Delta = "UpLeft";
            if (XNew > 0 && YNew < 0)//
                Delta = "UpRigth";
            if (XNew < 0 && YNew > 0)
                Delta = "DownLeft";
            int count = 0;
            int x1 = to.X;
            int y1 = to.Y;
            if (Math.Abs(YNew ) >=2)
            {
                while (x1 != from.X || y1 != from.Y)
                {
                    
                    if (Delta == "DownRigth")
                    {
                        Position[x1++, y1++].Id = "Пусто";
                    }
                    if (Delta == "UpLeft")
                    {
                        Position[x1--, y1--].Id = "Пусто";
                    }
                    if (Delta == "UpRigth")
                    {
                        Position[x1++, y1--].Id = "Пусто";
                    }
                    if (Delta == "DownLeft")
                    {
                        Position[x1--, y1++].Id = "Пусто";
                    }
                    count++;
                }
                   

                //Position[(to.X+from.X)/2, (to.Y + from.Y) / 2].Id = "Пусто";
              
            }



            Position[to.X, to.Y].Id = Save;

            if (move)
            {
                if (from.Y != 7)
                    Position[from.X, from.Y].Id = "Черная шашка";
                if (from.Y == 7 || Position[to.X, to.Y].Id == "Черная дамка")
                    Position[from.X, from.Y].Id = "Черная дамка";
            }
            else
            {
               


                if (from.Y != 0)
                    Position[from.X, from.Y].Id = "Белая шашка";
                if (from.Y == 0 || Position[to.X, to.Y].Id == "Белая дамка")
                    Position[from.X, from.Y].Id = "Белая дамка";
            }
            Position[to.X, to.Y].Id = "Пусто";


            if (Math.Abs(from.X - to.X) < 2)
                move = !move;
            else
            {
                if(CheckOpponent1(from.X, from.Y).Count==0)
                move = !move;
            }

            }
            catch (Exception ex)
            {
              
            }


            return false;
        }
       
        private void Control()
        {
            try { 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Position[i, j].Acive = false;
                    if (Position[i, j].Id == "#")
                        Position[i, j].Id = "Пусто";
                    if (Position[i, j].Id == "*")
                        Position[i, j].Id = "Пусто";
                       
                    }
            }
            }
            catch (Exception ex)
            {

            }
        }
        private List<Point> CheckOpponent1(int PositionX, int PositionY)
        {   
            List<Point> a = new List<Point>();
            try
            {
                 

                if (!move && Position[PositionX, PositionY].Id == "Белая шашка")
                {
                    if (PositionY != 7 && PositionX != 0 && PositionX != 1)
                        if (PositionX > 0 && PositionY > 0 && (Position[PositionX - 1, PositionY + 1].Id == "Черная шашка" || Position[PositionX - 1, PositionY + 1].Id == "Черная дамка") && Position[PositionX - 2, PositionY + 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }

                    if (PositionY != 7 && PositionX != 7)
                        if (PositionX < 8 && PositionY > 0 && (Position[PositionX + 1, PositionY + 1].Id == "Черная шашка" || Position[PositionX + 1, PositionY + 1].Id == "Черная дамка") && Position[PositionX + 2, PositionY + 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));

                        }

                    /////бить назад
                    if (PositionY != 0 && PositionX != 0 && PositionX != 1 && PositionY != 1)
                        if (PositionX > 0 && PositionY > 0 && (Position[PositionX - 1, PositionY - 1].Id == "Черная шашка" || Position[PositionX - 1, PositionY - 1].Id == "Черная дамка") && Position[PositionX - 2, PositionY - 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }

                    if (PositionY != 0 && PositionX != 7 && PositionY != 1)
                        if (PositionX < 8 && PositionY > 0 && (Position[PositionX + 1, PositionY - 1].Id == "Черная шашка" || Position[PositionX + 1, PositionY - 1].Id == "Черная дамка") && Position[PositionX + 2, PositionY - 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }



                }
                if (move && Position[PositionX, PositionY].Id == "Черная шашка")
                {
                    //бить назад
                    if (PositionY != 0 && PositionX != 7)
                        if (PositionX < 8 && PositionY < 8 && (Position[PositionX + 1, PositionY - 1].Id == "Белая шашка" || Position[PositionX + 1, PositionY - 1].Id == "Белая дамка") && Position[PositionX + 2, PositionY - 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }


                    if (PositionY != 0 && PositionX != 0 && PositionX != 1)
                        if (PositionY < 8 && PositionX > 0 && (Position[PositionX - 1, PositionY - 1].Id == "Белая шашка" || Position[PositionX - 1, PositionY - 1].Id == "Белая дамка") && Position[PositionX - 2, PositionY - 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }
                    ///  бить вперед 
                    if (PositionY != 7 && PositionX != 7)
                        if (PositionX < 8 && PositionY < 8 && (Position[PositionX + 1, PositionY + 1].Id == "Белая шашка" || Position[PositionX + 1, PositionY + 1].Id == "Белая дамка") && Position[PositionX + 2, PositionY + 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));

                        }


                    if (PositionY != 7 && PositionX != 0 && PositionX != 1)
                        if (PositionY < 8 && PositionX > 0 && (Position[PositionX - 1, PositionY + 1].Id == "Белая шашка" || Position[PositionX - 1, PositionY + 1].Id == "Белая дамка") && Position[PositionX - 2, PositionY + 2].Id == "Пусто")
                        {
                            a.Add(new Point(PositionX, PositionY));
                        }

                    if (Position[PositionX, PositionY].Id == "Белая дамка")
                    {

                        if (PositionX > 0 && PositionY > 0)
                        {
                            bool stop = false;
                            int x = PositionX - 1;
                            int y = PositionY - 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x--;
                                y--;
                                if (x == -1 || y == -1)
                                { stop = true; break; }


                            }
                        }

                        //вверх вправо
                        if (PositionX < 7 && PositionY > 0)
                        {
                            bool stop = false;
                            int x = PositionX + 1;
                            int y = PositionY - 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x++;
                                y--;
                                if (x == 8 || y == -1)
                                { stop = true; break; }



                            }
                        }

                        //вниз влево
                        if (PositionX > 0 && PositionY < 7)
                        {
                            bool stop = false;
                            int x = PositionX - 1;
                            int y = PositionY + 1;
                            while (!stop)
                            {

                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x--;
                                y++;
                                if (x == -1 || y == 8)
                                { stop = true; break; }


                            }
                        }

                        //вниз вправо
                        if (PositionX < 7 && PositionY < 7)
                        {
                            bool stop = false;
                            int x = PositionX + 1;
                            int y = PositionY + 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x++;
                                y++;
                                if (x == 8 || y == 8)
                                { stop = true; break; }



                            }
                        }

                    }
                    if (Position[PositionX, PositionY].Id == "Черная дамка")
                    {
                        if (PositionX > 0 && PositionY > 0)
                        {
                            bool stop = false;
                            int x = PositionX - 1;
                            int y = PositionY - 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x--;
                                y--;
                                if (x == -1 || y == -1)
                                { stop = true; break; }


                            }
                        }

                        //вверх вправо
                        if (PositionX < 7 && PositionY > 0)
                        {
                            bool stop = false;
                            int x = PositionX + 1;
                            int y = PositionY - 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x++;
                                y--;
                                if (x == 8 || y == -1)
                                { stop = true; break; }



                            }
                        }

                        //вниз влево
                        if (PositionX > 0 && PositionY < 7)
                        {
                            bool stop = false;
                            int x = PositionX - 1;
                            int y = PositionY + 1;
                            while (!stop)
                            {

                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x--;
                                y++;
                                if (x == -1 || y == 8)
                                { stop = true; break; }


                            }
                        }

                        //вниз вправо
                        if (PositionX < 7 && PositionY < 7)
                        {
                            bool stop = false;
                            int x = PositionX + 1;
                            int y = PositionY + 1;
                            while (!stop)
                            {
                                if (Position[x, y].Id == "*")
                                {
                                    a.Add(new Point(PositionX, PositionY));
                                }
                                x++;
                                y++;
                                if (x == 8 || y == 8)
                                { stop = true; break; }



                            }
                        }
                    }

                }
           

            return a; }

            catch (Exception ex)
            {
                return a; 
            }
        }
        private bool CheckOpponent(int PositionX, int PositionY)
        {
            bool check = false;
            try
            {
                Control();
                Position[PositionY, PositionX].Acive = true;
                bool priority = false;
                
                if (!move && Position[PositionX, PositionY].Id == "Белая шашка")
                {
                    if (PositionY != 7 && PositionX != 0)
                        if (PositionX > 0 && PositionY > 0 && (Position[PositionX - 1, PositionY + 1].Id == "Черная шашка" || Position[PositionX - 1, PositionY + 1].Id == "Черная дамка") && Position[PositionX - 2, PositionY + 2].Id == "Пусто")
                        {
                            Position[PositionX - 2, PositionY + 2].Id = "*";
                            priority = true;
                            check = true;
                        }

                    if (PositionY != 7 && PositionX != 7)
                        if (PositionX < 8 && PositionY > 0 && (Position[PositionX + 1, PositionY + 1].Id == "Черная шашка" || Position[PositionX + 1, PositionY + 1].Id == "Черная дамка") && Position[PositionX + 2, PositionY + 2].Id == "Пусто")
                        {
                            Position[PositionX + 2, PositionY + 2].Id = "*";
                            priority = true;
                            check = true;
                        }

                    /////бить назад
                    if (PositionY != 0 && PositionX != 0 && PositionY != 1 && PositionX != 1)
                        if (PositionX > 0 && PositionY > 0 && (Position[PositionX - 1, PositionY - 1].Id == "Черная шашка" || Position[PositionX - 1, PositionY - 1].Id == "Черная дамка")&& Position[PositionX - 2, PositionY - 2].Id == "Пусто")
                        {
                            Position[PositionX - 2, PositionY - 2].Id = "*";
                            priority = true;
                            check = true;
                        }

                    if (PositionY != 0 && PositionX != 7 && PositionY != 1)
                        if (PositionX < 8 && PositionY > 0 &&( Position[PositionX + 1, PositionY - 1].Id == "Черная шашка" || Position[PositionX + 1, PositionY - 1].Id == "Черная дамка") && Position[PositionX + 2, PositionY - 2].Id == "Пусто")
                        {
                            Position[PositionX + 2, PositionY - 2].Id = "*";
                            priority = true;
                            check = true;
                        }
                    ////бить вперед
                    if (PositionX > 0 && PositionY > 0 && Position[PositionX - 1, PositionY - 1].Id == "Пусто" && !priority)
                        Position[PositionX - 1, PositionY - 1].Id = "#";

                    if (PositionX < 8 && PositionY > 0 && Position[PositionX + 1, PositionY - 1].Id == "Пусто" && !priority)
                        Position[PositionX + 1, PositionY - 1].Id = "#";

                }
                if (move && Position[PositionX, PositionY].Id == "Черная шашка")
                {
                    //бить назад
                    if (PositionY != 0 && PositionX != 7)
                        if (PositionX < 8 && PositionY < 8 && (Position[PositionX + 1, PositionY - 1].Id == "Белая шашка" || Position[PositionX + 1, PositionY - 1].Id == "Белая дамка") && Position[PositionX + 2, PositionY - 2].Id == "Пусто")
                        {
                            Position[PositionX + 2, PositionY - 2].Id = "*";

                            priority = true;
                            check = true;
                        }


                    if (PositionY != 0 && PositionX != 0 && PositionX != 1)
                        if (PositionY < 8 && PositionX > 0 && (Position[PositionX - 1, PositionY - 1].Id == "Белая шашка" || Position[PositionX - 1, PositionY - 1].Id == "Белая дамка") && Position[PositionX - 2, PositionY - 2].Id == "Пусто")
                        {
                            Position[PositionX - 2, PositionY - 2].Id = "*";
                            priority = true;
                            check = true;
                        }
                    ///  бить вперед 
                    if (PositionY != 7 && PositionX != 7)
                        if (PositionX < 8 && PositionY < 8 && (Position[PositionX + 1, PositionY + 1].Id == "Белая шашка" || Position[PositionX + 1, PositionY + 1].Id == "Белая дамка") && Position[PositionX + 2, PositionY + 2].Id == "Пусто")
                        {
                            Position[PositionX + 2, PositionY + 2].Id = "*";

                            priority = true;
                            check = true;
                        }


                    if (PositionY != 7 && PositionX != 0 && PositionX != 1)
                        if (PositionY < 8 && PositionX > 0 && (Position[PositionX - 1, PositionY + 1].Id == "Белая шашка" || Position[PositionX - 1, PositionY + 1].Id == "Белая дамка") && Position[PositionX - 2, PositionY + 2].Id == "Пусто")
                        {
                            Position[PositionX - 2, PositionY + 2].Id = "*";
                            priority = true;
                            check = true;
                        }
                    if (PositionY < 8 && PositionX > 0 && Position[PositionX - 1, PositionY + 1].Id == "Пусто" && !priority)
                        Position[PositionX - 1, PositionY + 1].Id = "#";
                    if (PositionX < 8 && PositionY < 8 && Position[PositionX + 1, PositionY + 1].Id == "Пусто" && !priority)
                        Position[PositionX + 1, PositionY + 1].Id = "#";

                }

                if (!move && Position[PositionX, PositionY].Id == "Белая дамка")
                {

                    if (PositionX != 0 && PositionY != 0)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX - 1;
                        int y = PositionY - 1;
                        while (!stop)
                        {


                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop1 = true; }

                            x--;
                            y--;

                            if (x == -1 || y == -1)
                            { stop = true; break; }





                        }
                    }

                    //вверх вправо
                    if (PositionX != 7 && PositionY !=0)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX + 1;
                        int y = PositionY - 1;
                        while (!stop)
                        {
                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop1 = true; }
                            x++;
                            y--;
                            

                            if (x == 8 || y == -1)
                            { stop = true; break; }

                        }
                    }

                    //вниз влево
                    if (PositionX != 0 && PositionY != 7 )
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX - 1;
                        int y = PositionY + 1;
                        while (!stop)
                        {
                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop1 = true; }
                            x--;
                            y++;
                           

                            if (x == -1 || y == 8)
                            { stop = true; break; }

                        }
                    }

                    //вниз вправо
                    if (PositionX != 7 && PositionY != 7)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX + 1;
                        int y = PositionY + 1;
                        while (!stop)
                        {

                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop1 = true; }
                            y++;
                            x++;
                            if (x == 8 || y == 8)
                            { stop = true; break; }

                        }
                    }


                }
                if (move && Position[PositionX, PositionY].Id == "Черная дамка")
                {

                    if (PositionX != 0 && PositionY != 0)
                    {
                        bool stop = false;
                        bool stop1 = false;


                        int x = PositionX - 1;
                        int y = PositionY - 1;
                        while (!stop)
                        {

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                                { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if(!stop1)
                                Position[x, y].Id = "#";
                                else
                                Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop1 = true; }
                            x--;
                            y--;

                            if (x == -1 || y == -1)
                            { stop = true; break; }





                        }
                    }

                    //вверх вправо
                    if (PositionX != 7 && PositionY != 0)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX + 1;
                        int y = PositionY - 1;
                        while (!stop)
                        {
                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop1 = true; }
                            x++;
                            y--;
                            if (x == 8 || y == -1)
                            { stop = true; break; }

                        }
                    }

                    //вниз влево
                    if (PositionX != 0 && PositionY != 7)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX - 1;
                        int y = PositionY + 1;
                        while (!stop)
                        {

                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop1 = true; }
                            x--;
                            y++;
                            if (x == -1 || y == 8)
                            { stop = true; break; }

                        }
                    }

                    //вниз вправо
                    if (PositionX != 7 && PositionY != 7)
                    {
                        bool stop = false; bool stop1 = false;
                        int x = PositionX + 1;
                        int y = PositionY + 1;
                        while (!stop)
                        {
                            if (Position[x, y].Id == "Черная шашка" || Position[x, y].Id == "Черная дамка")
                            { stop = true; break; }
                            if (Position[x, y].Id == "Пусто")
                                if (!stop1)
                                    Position[x, y].Id = "#";
                                else
                                    Position[x, y].Id = "*";

                            if (Position[x, y].Id == "Белая шашка" || Position[x, y].Id == "Белая дамка")
                            { stop1 = true; }
                            y++;
                            x++;
                            if (x == 8 || y == 8)
                            { stop = true; break; }

                        }
                    }
                }
            }
            catch (Exception e )
            {
                MessageBox.Show(e.ToString() + " X" + PositionX + " Y" + PositionY);
            }
            return check;
        }
        
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                bool r = false;
                int x = e.X;
                int y = e.Y;
                int PositionX = (e.X - 20) / 75;
                int PositionY = (e.Y - 20) / 75;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {

                        if (Position[i, j].Possible == true)
                            Position[i, j].Possible = false;
                    }
                }
                List<Point> a = new List<Point>();
                for (int i = 0; i < 8; i++)
                    for (int f = 0; f < 8; f++)
                        a.AddRange(CheckOpponent1(i, f));


                if (a.Count == 0)
                {
                    if (Position[PositionX, PositionY].Id == "#" || Position[PositionX, PositionY].Id == "*" )
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (Position[i, j].Acive == true)
                                    CheckerMove(new Point(j, i), new Point(PositionX, PositionY));

                            }
                        }
                    }
                    Control();
                    CheckOpponent(PositionX, PositionY);
                    drawing();
                }
                else
                {
                    foreach (var t in a)
                    {
                        Position[t.X, t.Y].Possible = true;
                    }
                    

                    if (Position[PositionX, PositionY].Id == "*" )
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (Position[i, j].Acive == true)
                                {


                                    if (Position[i, j].Acive == true)
                                        CheckerMove(new Point(j, i), new Point(PositionX, PositionY));

                                }


                            }
                        }
                    }

                    Control();
                    
                    CheckOpponent(PositionX, PositionY);
                    drawing();
                }
                int countWhite = 0;
                int countBlack = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Position[i, j].Id == "Черная шашка" || Position[i, j].Id == "Черная шашка")
                            countWhite++;
                        if (Position[i, j].Id == "Белая шашка" || Position[i, j].Id == "Белая шашка")
                            countBlack++;
                    }
                }
                if (countWhite == 0)
                {  FinishGame = "Победа синих";Finish = true; }
                

                if (countBlack == 0)
                { FinishGame = "Победа красных"; Finish = true; }
                
            }
            catch (Exception ex)
            { }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
