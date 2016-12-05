using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1fsdf
{
    public partial class Form1 : Form
    {
        Graphics g;
        
        public Form1()
        {
            InitializeComponent();

            g = pbPicture.CreateGraphics();
        }

        private void bWrite_Click(object sender, EventArgs e)
        {

            //tbNotepad.Text += "qweqwe";
            File.WriteAllText("myFile.txt", tbNotepad.Text);
            //tbNotepad.Text = File.ReadAllText("myFile.txt");



            //string s = "";
            //if(File.Exists("myFile.txt")) s = File.ReadAllText("myFile.txt");
            //string s = File.ReadAllText("myFile.txt");
            //tbNotepad.Text = s;
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            //g.DrawRectangle(new Pen(Color.White), new Rectangle(1, 1, 50, 50));
            g.DrawLine(new Pen(Color.White), 10, 10, 50, 100);
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            
            tbNotepad.Text = "";
            //string s = "";
            //if(File.Exists("myFile.txt")) s = File.ReadAllText("myFile.txt");
            //string s = File.ReadAllText("myFile.txt");
            //tbNotepad.Text = s;
            string[] lines = File.ReadAllLines("myFile.txt");
            g.Clear(Color.Black);

            List<Point> vertices = new List<Point>();
            List<int> f = new List<int>();

            foreach (string s in lines)
            {
                string[] vals = s.Split(' ');
                if(vals[0]=="f")
                {
                    /*
                    f.Add(int.Parse(vals[1]));
                    f.Add(int.Parse(vals[2]));
                    f.Add(int.Parse(vals[3]));
                    */
                    f.Add(int.Parse(vals[1].Split('/')[0]));
                    f.Add(int.Parse(vals[2].Split('/')[0]));
                    f.Add(int.Parse(vals[3].Split('/')[0]));
                }
                else if (vals[0] == "v")
                {
                    //vertices.Add(new Point(int.Parse(vals[1]), int.Parse(vals[2])));
                    vertices.Add(new Point(int.Parse(vals[1]), int.Parse(vals[2])));
                }

                /*
                int x1 = int.Parse(vals[0]);
                int y1 = int.Parse(vals[1]);
                int x2 = int.Parse(vals[2]);
                int y2 = int.Parse(vals[3]);
                g.DrawLine(new Pen(Color.White), x1, y1, x2, y2);
                */
                tbNotepad.Text += s + "\r\n";
            }

            for (int i = 0; i < f.Count / 3; i++)
            {
                Point t1 = vertices[f[i * 3 + 0]-1];
                Point t2 = vertices[f[i * 3 + 1]-1];
                Point t3 = vertices[f[i * 3 + 2]-1];

                Point[] arr = {t1, t2, t3};
                g.DrawPolygon(new Pen(Color.White), arr);
                /*
                g.DrawLine(new Pen(Color.White), t1, t2);
                g.DrawLine(new Pen(Color.White), t1, t3);
                g.DrawLine(new Pen(Color.White), t2, t3);
                */
            }

        }
    }
}
