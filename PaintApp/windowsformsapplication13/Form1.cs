using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        int sinxronos = 0;
        Pen mypen = new Pen(Color.Black);
        Pen mypen2 = new Pen(Color.DarkSeaGreen);
        Pen mypen3 = new Pen(Color.AliceBlue);
        Graphics myg;
        bool line1 = false, rect1 = false, cir1 = false, rub = false, rubber = false;
        public int lx1, ly1, house = 1, ship = 1, robot = 1;

        Class1 obj1 = new Class1();
        Class2 obj2 = new Class2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                mypen.Color = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myg = this.CreateGraphics();
            mypen2.Width = 10;
            mypen3.Width = 10;
            timer4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mypen.Width = obj1.WidthSelection(numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cir1 = false;
            rect1 = false;
            rub = false;

            if (line1 == false)
            {
                line1 = true;
                this.Cursor = Cursors.Cross;
            }
            else
            {
                line1 = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (line1 || rect1 || cir1)
            {
                lx1 = e.X;
                ly1 = e.Y;
            }

            if (rub)
            {
                lx1 = e.X;
                ly1 = e.Y;
                rubber = true;
            }

            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (line1)
                myg.DrawLine(mypen, lx1, ly1, e.X, e.Y);
            else if (rect1)
            {
                myg.DrawLine(mypen, lx1, ly1, lx1, e.Y);
                myg.DrawLine(mypen, lx1, ly1, e.X, ly1);
                myg.DrawLine(mypen, e.X, ly1, e.X, e.Y);
                myg.DrawLine(mypen, e.X, e.Y, lx1, e.Y);
            }
            else if(cir1)
            {
                myg.DrawEllipse(mypen, lx1, ly1, e.X - lx1, e.Y - ly1);
            }

            rubber = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (house==1)
           {
               myg.DrawLine(mypen2, 250, 215, 250, 305);
               house++;
           }
           else if (house==2)
           {
               myg.DrawLine(mypen2, 250, 305, 340, 305);
               house++;
           }
           else if(house==3)
           {
               myg.DrawLine(mypen2, 340, 305, 340, 215);
               house++;
           }
           else if(house==4)
           {
               myg.DrawLine(mypen2, 340, 215, 250, 215);
               house++;
           }
            else if (house==5)
           {
               myg.DrawLine(mypen2, 250, 215, 295, 170);
               house++;
           }
           else
           {
               myg.DrawLine(mypen2, 295, 170, 340, 215);
               timer1.Enabled = false;
               house = 1;
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            house = 1;
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
            myg.Clear(this.BackColor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ship = 1;
            timer2.Enabled = true;
            timer1.Enabled = false;
            timer3.Enabled = false;
            myg.Clear(this.BackColor);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ship==1)
            {
                myg.DrawLine(mypen2, 250, 215, 300, 265);
                ship++;
            }
            else if (ship==2)
            {
                myg.DrawLine(mypen2, 300, 265, 500, 265);
                ship++;
            }
            else if (ship==3)
            {
                myg.DrawLine(mypen2, 500, 265, 550, 215);
                ship++;
            }
            else if (ship==4)
            {
                myg.DrawLine(mypen2, 550, 215, 250, 215);
                ship++;
            }
            else if (ship==5)
            {
                myg.DrawLine(mypen2, 400, 215, 400, 115);
                ship++;
            }
            else if (ship==6)
            {
                myg.DrawLine(mypen2, 400, 115, 430, 145);
                ship++;
            }
            else
            {
                myg.DrawLine(mypen2, 430, 145, 400, 175);
                timer2.Enabled = false;
                ship = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            robot = 1;
            timer3.Enabled = true;
            timer2.Enabled = false;
            timer1.Enabled = false;
            myg.Clear(this.BackColor);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (robot == 1)
            {
                myg.DrawLine(mypen2, 250, 215, 250, 125);
                robot++;
            }
            else if (robot == 2)
            {
                myg.DrawLine(mypen2, 250, 125, 340, 125);
                robot++;
            }
            else if (robot == 3)
            {
                myg.DrawLine(mypen2, 340, 125, 340, 215);
                robot++;
            }
            else if (robot == 4)
            {
                myg.DrawLine(mypen2, 340, 215, 250, 215);
                robot++;
            }
            else if (robot == 5)
            {
                myg.DrawLine(mypen2, 280, 150, 280, 160);
                robot++;
            }
            else if (robot == 6)
            {
                myg.DrawLine(mypen2, 310, 150, 310, 160);
                robot++;
            }
            else if (robot == 7)
            {
                myg.DrawLine(mypen2, 295, 170, 295, 185);
                robot++;
            }
            else if (robot == 8)
            {
                myg.DrawLine(mypen2, 280, 200, 310, 200);
                robot++;
            }
            else if (robot == 9)
            {
                myg.DrawLine(mypen2, 295, 215, 295, 245);
                robot++;
            }
            else if (robot == 10)
            {
                myg.DrawLine(mypen2, 220, 245, 370, 245);
                robot++;
            }
            else if (robot == 11)
            {
                myg.DrawLine(mypen2, 370, 245, 370, 325);
                robot++;
            }
            else if (robot == 12)
            {
                myg.DrawLine(mypen2, 370, 325, 220, 325);
                robot++;
            }
            else if (robot == 13)
            {
                myg.DrawLine(mypen2, 220, 325, 220, 245);
                robot++;
            }
            else if (robot == 14)
            {
                myg.DrawLine(mypen2, 220, 285, 150, 205);
                robot++;
            }
            else if (robot == 15)
            {
                myg.DrawLine(mypen2, 370, 285, 440, 205);
                robot++;
            }
            else if (robot == 16)
            {
                myg.DrawLine(mypen2, 250, 325, 250, 380);
                robot++;
            }
            else
            {
                myg.DrawLine(mypen2, 340, 325, 340, 380);
                timer3.Enabled = false;
                robot = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rub = false;
            line1 = false;
            cir1 = false;

            if (rect1 == false)
            {
                rect1 = true;
                this.Cursor = Cursors.Hand;
            }
            else
            {
                rect1 = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rub = false;
            line1 = false;
            rect1 = false;

            if (cir1 == false)
            {
                cir1 = true;
                this.Cursor = Cursors.Hand;
            }
            else
            {
                cir1 = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myg.Clear(this.BackColor);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            line1 = false;
            rect1 = false;
            cir1 = false;

            if (rub == false)
            {
                rub = true;
                this.Cursor = Cursors.No;
                mypen3.Color = this.BackColor;
            }
            else
            {
                rub = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rubber)
            {
                myg.DrawLine(mypen3, lx1, ly1, e.X, e.Y);
                lx1 = e.X;
                ly1 = e.Y;
            }
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Silver;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSpringGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumSpringGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Silver;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Yellow;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Silver;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightSalmon;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Silver;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightSalmon;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightSalmon;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Silver;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.Azure;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Silver;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myg.Clear(this.BackColor);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj2.GetTime(sinxronos);

            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: \n\n Teodoro Gomes \n Panagiotis Mountouris \n Thodoris Glampedakis");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sinxronos++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj2.GetTime(sinxronos);
        }
        
    }
}
