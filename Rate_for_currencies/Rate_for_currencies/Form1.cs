using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rate_for_currencies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random rnd = new Random();
        Boolean calculate = false;

        double dollar, euro;
        int days = 1;

        private void btnStartStop_Click(object sender, EventArgs e)
        {
           

            if (!calculate)
            {
                btnStartStop.Text = "Stop";
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                dollar = (double)inpDollar.Value;
                euro = (double)inpEuro.Value;
                days = 1;

                chart1.Series[0].Points.AddXY(0, dollar);
                chart1.Series[1].Points.AddXY(0, euro);

                timer1.Start();
                calculate = true;
            }
            else
            {
                btnStartStop.Text = "Launch";
                timer1.Stop();
                calculate = false;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dollar = dollar * (1 + k * (rnd.NextDouble() - 0.5));
            euro = euro * (1 + k * (rnd.NextDouble() - 0.5));

            chart1.Series[0].Points.AddXY(days, dollar);
            chart1.Series[1].Points.AddXY(days, euro);

            days++;

        }
    }
}
