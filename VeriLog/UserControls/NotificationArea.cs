using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeriLog.UserControls
{
    public partial class NotificationArea : UserControl
    {
        public NotificationArea()
        {
            InitializeComponent();
        }

        public NotificationArea(string notification, DateTime dater)
        {
            InitializeComponent();
            notlab.Text = notification;
            datelab.Text = dater.ToShortTimeString();
        }

        private void NotificationArea_Load(object sender, EventArgs e)
        {
        }

        public event EventHandler OnDelete;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Tomato;
            pictureBox7.Visible = false;
            notlab.Text = @"Deleted";
            datelab.Text = "";
            bunifuFlatButton1.Enabled = false;
            OnDelete?.Invoke(this, new EventArgs());
        }
    }
}