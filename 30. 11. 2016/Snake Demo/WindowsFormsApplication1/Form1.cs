using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using Snake_Demo;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;

        Snake s;

        public Form1()
        {
            InitializeComponent();
            p = new Pen(Color.White);
            g = pbPictureBox.CreateGraphics();

            
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            //File.AppendAllText("qwe.txt", "fkwejewfiowejf");
            //string s = File.ReadAllText("qwe.txt");
            //MessageBox.Show(s);
            //string[] s = File.ReadAllLines("qwe.txt");
            //MessageBox.Show(s[2]);

            //File.ReadAllText("qwe.txt");

            //MessageBox.Show("qweqwe");
            //g.Clear(Color.Black);
            //g.DrawRectangle(p, new Rectangle(10,10,50,50));
            //g.DrawLine(p, 10, 10, 60, 60);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            s = new Snake(10, 10);
            timer1.Interval = s.delay;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("qwe");
            bool ok = s.step();
            if (!ok)
            {
                timer1.Stop();
                MessageBox.Show("You have lost");

            }
            else
            {
                timer1.Interval = s.delay;
                drawBoard();
            }
        }

        private void drawBoard()
        {
            g.Clear(Color.Black);

            for (int i = 0; i < s.height; i++)
            {
                for (int j = 0; j < s.width; j++)
                {
                    Color c = Color.Black;
                    if (s.board[j, i] == '#') c = Color.Green;
                    if (s.board[j, i] == '0') c = Color.Yellow;
                    if (s.board[j, i] == '$') c = Color.Blue;

                    g.FillRectangle(new SolidBrush(c), new Rectangle(i * 20, j * 20, 20, 20));
                    //Console.Write(board[i, j] + " ");
                }
                //Console.WriteLine();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (s == null) return;
            if (e.KeyChar == 'd')
                s.setDirection(MoveDirection.Right);
            else if (e.KeyChar == 'a')
                s.setDirection(MoveDirection.Left);
            else if (e.KeyChar == 'w')
                s.setDirection(MoveDirection.Up);
            else if (e.KeyChar == 's')
                s.setDirection(MoveDirection.Down);
        }
    }
}
