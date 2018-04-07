using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeriLog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton2.Textcolor = Color.DimGray;
            bunifuFlatButton3.Textcolor = Color.DimGray;
            bunifuFlatButton4.Textcolor = Color.DimGray;
            bunifuFlatButton5.Textcolor = Color.DimGray;

            bunifuFlatButton1.Normalcolor = Color.Wheat;
            bunifuFlatButton2.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton3.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton4.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton5.Normalcolor = Color.FromArgb(253, 250, 254);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton1.Textcolor = Color.DimGray;
            bunifuFlatButton3.Textcolor = Color.DimGray;
            bunifuFlatButton4.Textcolor = Color.DimGray;
            bunifuFlatButton5.Textcolor = Color.DimGray;

            bunifuFlatButton2.Normalcolor = Color.Wheat;
            bunifuFlatButton1.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton3.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton4.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton5.Normalcolor = Color.FromArgb(253, 250, 254);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuFlatButton3.Textcolor = Color.White;
            bunifuFlatButton2.Textcolor = Color.DimGray;
            bunifuFlatButton1.Textcolor = Color.DimGray;
            bunifuFlatButton4.Textcolor = Color.DimGray;
            bunifuFlatButton5.Textcolor = Color.DimGray;

            bunifuFlatButton3.Normalcolor = Color.Wheat;
            bunifuFlatButton2.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton1.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton4.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton5.Normalcolor = Color.FromArgb(253, 250, 254);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.Normalcolor = Color.Wheat;
            bunifuFlatButton1.Textcolor = Color.White;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuFlatButton4.Textcolor = Color.White;
            bunifuFlatButton2.Textcolor = Color.DimGray;
            bunifuFlatButton3.Textcolor = Color.DimGray;
            bunifuFlatButton1.Textcolor = Color.DimGray;
            bunifuFlatButton5.Textcolor = Color.DimGray;

            bunifuFlatButton4.Normalcolor = Color.Wheat;
            bunifuFlatButton2.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton3.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton1.Normalcolor = Color.FromArgb(253, 250, 254);
            bunifuFlatButton5.Normalcolor = Color.FromArgb(253, 250, 254);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}