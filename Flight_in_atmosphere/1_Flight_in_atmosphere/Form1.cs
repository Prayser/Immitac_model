using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1_Flight_in_atmosphere
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double height, angle, speed, size, weight, step;
        double x, y, t, k;

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Time step";   //текст в шапке
            column1.Width = 100;                //ширина колонки
            column1.ReadOnly = true;            //значение в этой колонке нельзя править
            column1.Name = "step";              //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true;              //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Distance";    //текст в шапке
            column2.ReadOnly = true;            //значение в этой колонке нельзя править
            column2.Frozen = true;              //флаг, что данная колонка всегда отображается на своем месте
            column2.Name = "distance";          //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Max Height";  //текст в шапке
            column3.ReadOnly = true;            //значение в этой колонке нельзя править
            column3.Frozen = true;              //флаг, что данная колонка всегда отображается на своем месте
            column3.Name = "height";            //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Speed";       //текст в шапке
            column4.ReadOnly = true;            //значение в этой колонке нельзя править
            column4.Frozen = true;              //флаг, что данная колонка всегда отображается на своем месте
            column4.Name = "speed";             //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dtMyTable.Columns.Add(column1); 
            dtMyTable.Columns.Add(column2);
            dtMyTable.Columns.Add(column3);
            dtMyTable.Columns.Add(column4);

            dtMyTable.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            
        }


        double cosA, sinA;
        double vx, vy, maxHeight;

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        private void button1_Click(object sender, EventArgs e)
        {
            height = (double)inpHeight.Value;
            angle = (double)inpAngle.Value;
            speed = (double)inpSpeed.Value;
            size = (double)inpSize.Value;
            weight = (double)inpWeight.Value;
            step = (double)inpStep.Value;

            cosA = Math.Cos(angle * Math.PI / 180);
            sinA = Math.Sin(angle * Math.PI / 180);

            k = 0.5 * C * size * rho / weight;

            t = 0;
            x = 0;
            y = height;
            maxHeight = y;

            vx = speed * cosA;
            vy = speed * sinA;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double root = Math.Sqrt(vx * vx + vy * vy);

            t = t + step;

            vx = vx - k * vx * root * step;
            vy = vy - (g + k * vy * root) * step;

            x = x + vx * step;
            y = y + vy * step;

            if (maxHeight < y) maxHeight = y;

            chart1.Series[0].Points.AddXY(x, y);

            if (y <= 0)
            {
                dtMyTable.Rows.Add(step, Math.Round(x, 4), Math.Round(maxHeight, 3), Math.Round(root, 2));
                timer1.Stop();
            }

        }


    }
}
