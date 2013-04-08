using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 簡易カラーピッカー
{
    public partial class Form1 : Form
    {
        int r, g, b;
        bool isDownPic1, isDownPic2;
        Graphics pic1grfx, pic2grfx, picOutGrfx;
        int pic2SelX;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // R,G
            pic1.Image = new Bitmap(pic1.Width, pic1.Height);
            pic1grfx = Graphics.FromImage(pic1.Image);
            Bitmap bitmap = (Bitmap)pic1.Image;
            for (int x = 0; x < pic1.Width; x++)
            {
                for (int y = 0; y < pic1.Height; y++)
                {
                    Color color = Color.FromArgb(
                        x * 256 / pic1.Width,
                        y * 256 / pic1.Height,
                        0);
                    bitmap.SetPixel(x, y, color);
                }
            }
            Pen pen = new Pen(Color.FromArgb(29, 32, 30));
            int cirX = r * pic1.Width / 256;
            int cirY = g * pic1.Height / 256;
            pic1grfx.DrawEllipse(pen, cirX - 5, cirY - 5, 10, 10);

            // B
            pic2.Image = new Bitmap(pic2.Width, pic2.Height);
            pic2grfx = Graphics.FromImage(pic2.Image);
            for (int i = 0; i < pic2.Height; i++)
            {
                pen = new Pen(Color.FromArgb(0, 0, i * 256 / pic1.Height));
                pic2grfx.DrawLine(
                    pen,
                    0, i, pic2.Width, i);
            }

            picOut.Image = new Bitmap(picOut.Width, picOut.Height);
            picOutGrfx = Graphics.FromImage(picOut.Image);

            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));
            picOutGrfx.FillRectangle(
                brush,
                0, 0, picOut.Width, picOut.Height);
            reTextRGB();
        }
        
        private void pic1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pic1.Image;
            for (int x = 0; x < pic1.Width; x++)
            {
                for (int y = 0; y < pic1.Height; y++)
                {
                    Color color = Color.FromArgb(
                        x * 256 / pic1.Width,
                        y * 256 / pic1.Height,
                        b);
                    bitmap.SetPixel(x, y, color);
                }
            }
            Pen pen = new Pen(Color.FromArgb(29,32,30));
            int cirX = r * pic1.Width / 256;
            int cirY = g * pic1.Height / 256;
            pic1grfx.DrawEllipse(pen, cirX - 5, cirY - 5, 10, 10);
        }
        
        private void pic2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen;
            for (int i = 0; i < pic2.Height; i++)
            {
                pen = new Pen(Color.FromArgb(r, g, i * 256 / pic1.Height));
                pic2grfx.DrawLine(
                    pen,
                    0, i, pic2.Width, i);
            }
            pen = new Pen(Color.FromArgb(29, 32, 30));
            int cirX = pic2SelX;
            int cirY = b * pic2.Height / 256;
            pic2grfx.DrawEllipse(pen, cirX - 5, cirY - 5, 10, 10);

        }


        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDownPic1)
            {
                r = e.X * 256 / pic1.Width;
                g = e.Y * 256 / pic1.Height;
                if (r > 255)
                    r = 255;
                if (g > 255)
                    g = 255;
                if (r < 0)
                    r = 0;
                if (g < 0)
                    g = 0;
                pic1.Refresh();
                pic2.Refresh();
                picOut.Refresh();
                reTextRGB();
            }
        }
        void reTextRGB()
        {
            dR.Text = r.ToString("d");
            dG.Text = g.ToString("d");
            dB.Text = b.ToString("d");
            xR.Text = r.ToString("X");
            xG.Text = g.ToString("X");
            xB.Text = b.ToString("X");
            dR.Refresh();
            dG.Refresh();
            dB.Refresh();
            xR.Refresh();
            xG.Refresh();
            xB.Refresh();
            rrggbb.Text = "0x" + r.ToString("X") + g.ToString("X") + b.ToString("X");
            int xr = r / 16;
            int xg = g / 16;
            int xb = b / 16;
            rgb.Text = "0x" + xr.ToString("X") + xg.ToString("X") + xb.ToString("X");
            rrggbb.Refresh();
            rgb.Refresh();
            OutTextChange();
        }
        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            isDownPic1 = true;
            pic1_MouseMove(sender, e);
        }


        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {

            isDownPic1 = false;
            pic1_MouseMove(sender, e);
        }

        private void pic1_MouseClick(object sender, MouseEventArgs e)
        {
            pic1_MouseMove(sender, e);
        }

        private void pic2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDownPic2)
            {
                pic2SelX = e.X;
                b = e.Y * 256 / pic2.Height;
                if (b > 255)
                    b = 255;
                if (b < 0)
                    b = 0;
                if (pic2SelX > pic2.Width)
                    pic2SelX = pic2.Width;
                if (pic2SelX < 0)
                    pic2SelX = 0;
                pic1.Refresh();
                pic2.Refresh();
                picOut.Refresh();
                reTextRGB();
            }
        }

        private void pic2_MouseUp(object sender, MouseEventArgs e)
        {

            isDownPic2 = false;
            pic2_MouseMove(sender, e);
        }

        private void pic2_MouseDown(object sender, MouseEventArgs e)
        {
            isDownPic2 = true;
            pic2_MouseMove(sender, e);
        }

        private void pic2_MouseClick(object sender, MouseEventArgs e)
        {
            pic2_MouseMove(sender, e);
        }

        private void picOut_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));
            picOutGrfx.FillRectangle(
                brush,
                0, 0, picOut.Width, picOut.Height);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "\\r,\\g,\\bで10進数でRGB出力\n"
                + "\\xr、\\xg、\\xbで16進数出力、xを大文字にすると大文字で出力\n"
                + "\\x1r、\\x1g、\\x1bで上1桁のみ16進数で出力\n"
                + "\\x2r、\\x2g、\\2bで2桁固定で16進数で出力\n",
                "マクロのヘルプ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OutTextChange();
        }

        private void OutTextChange()
        {
            string macroOut = textBox1.Text;
            int xr = r / 16;
            int xg = g / 16;
            int xb = b / 16;
            macroOut = macroOut.Replace("\\X1r", xr.ToString("X"));
            macroOut = macroOut.Replace("\\X1g", xg.ToString("X"));
            macroOut = macroOut.Replace("\\X1b", xb.ToString("X"));
            macroOut = macroOut.Replace("\\x1r", xr.ToString("x"));
            macroOut = macroOut.Replace("\\x1g", xg.ToString("x"));
            macroOut = macroOut.Replace("\\x1b", xb.ToString("x"));

            macroOut = macroOut.Replace("\\X2r", r.ToString("X2"));
            macroOut = macroOut.Replace("\\X2g", g.ToString("X2"));
            macroOut = macroOut.Replace("\\X2b", b.ToString("X2"));
            macroOut = macroOut.Replace("\\x2r", r.ToString("x2"));
            macroOut = macroOut.Replace("\\x2g", g.ToString("x2"));
            macroOut = macroOut.Replace("\\x2b", b.ToString("x2"));

            macroOut = macroOut.Replace("\\r", r.ToString("D"));
            macroOut = macroOut.Replace("\\g", g.ToString("D"));
            macroOut = macroOut.Replace("\\b", b.ToString("D"));
            macroOut = macroOut.Replace("\\dr", r.ToString("D"));
            macroOut = macroOut.Replace("\\dg", g.ToString("D"));
            macroOut = macroOut.Replace("\\db", b.ToString("D"));
            macroOut = macroOut.Replace("\\xr", r.ToString("x"));
            macroOut = macroOut.Replace("\\xg", g.ToString("x"));
            macroOut = macroOut.Replace("\\xb", b.ToString("x"));
            macroOut = macroOut.Replace("\\Xr", r.ToString("X"));
            macroOut = macroOut.Replace("\\Xg", g.ToString("X"));
            macroOut = macroOut.Replace("\\Xb", b.ToString("X"));

            textBox2.Text = macroOut;
            textBox2.Refresh();
        }


    }
}
