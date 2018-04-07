using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.DataViz;

namespace VeriLog.UserControls
{
    public partial class Dashboard : UserControl
    {
        private int _poss = 10;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel13.Text = @"Copyright © " + DateTime.Now.Year + @" RUN INSODET.";
            var m = (panel19.Size.Width - bunifuCustomLabel13.Size.Width) / 2;
            bunifuCustomLabel13.Location = new Point(m, bunifuCustomLabel13.Location.Y);
            var j = 10;
            for (var i = 0; i < j; i++)
            {
                Additem("Notifier " + i, DateTime.Now);
            }
        }

        public void Additem(string notification, DateTime dater)
        {
            var notifier = new NotificationArea(notification, dater);
            panel17.Controls.Add(notifier);
            notifier.Top = _poss;
            _poss = (notifier.Top + notifier.Height + 10);
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {
        }

        private void bunifuDataViz1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var data1 = new Canvas();

            var datapoint1 = new DataPoint(BunifuDataViz._type.Bunifu_line);

            bunifuDataViz1.colorSet = new List<Color> {Color.White};

            datapoint1.addLabely("Mon", "10");
            datapoint1.addLabely("Tue", "30");
            datapoint1.addLabely("Wed", "150");
            datapoint1.addLabely("Thu", "80");
            datapoint1.addLabely("Fri", "20");
            data1.addData(datapoint1);

            bunifuDataViz1.Render(data1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Additem();
        }
    }
}