using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemenatry_Cellular_Automaton
{
    public partial class Form1 : Form
    {
        const int maxGens = 10, maxCells = 10;

        Dictionary<string, bool> Rules = new Dictionary<string, bool>();
        bool[,] CellularMatrix;

        Bitmap bitmap;
        Graphics graph;
        int lastGeneration;
        bool action = false;

        public Form1()
        {
            InitializeComponent();
            InitCellGrid();
        }
        private void CreateFirstGeneration()
        {
            CellularMatrix = new bool[maxGens, maxCells];
            lastGeneration = 0;
            CellularMatrix[0, 1] = true;
            CellularMatrix[0, 3] = true;
            CellularMatrix[0, 5] = true;
            CellularMatrix[0, 7] = true;
            CellularMatrix[0, 9] = true;
        }

        private void InitCellGrid()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(bitmap);

            DrawLeftColumn();
            DrawGridTemplate();
        }

        private void DrawCells()
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            for (int genNum = 0; genNum < maxGens; genNum++)
            {
                for (int cellNum = 0; cellNum < maxCells; cellNum++)
                {
                    if (CellularMatrix[genNum, cellNum])
                    {
                        graph.FillRectangle(solidBrush, 30 + cellNum * 30, genNum * 30, 30, 30);
                    }
                }
            }
        }

        private void DrawLeftColumn()
        {
            graph.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 30, 300));

            Font font = new Font("Calibri", 14);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < maxGens; i++)
            {
                graph.DrawString(i.ToString(), font, solidBrush, 6, i * 30 + 4);
            }
        }

        private void DrawGridTemplate()
        {
            Pen pen = new Pen(Color.Black);

            for (int i = 0; i < maxGens + 1; i++)
            {
                graph.DrawLine(pen, 0, i * 30, 330, i * 30);
            }

            for (int i = 0; i < maxCells + 2; i++)
            {
                graph.DrawLine(pen, i * 30, 0, i * 30, 300);
            }
        }

        private string IntToFullBinString(int input, int length)
        {
            string l = Convert.ToString(input, 2);
            while (l.Length < length) l = '0' + l;
            return l;
        }

        private void SetRules()
        {
            string rule = IntToFullBinString((int)inpRule.Value, 8);

            for (int i = 0; i < 8; i++)
            {
                Rules[IntToFullBinString(i, 3)] = Convert.ToBoolean(Convert.ToInt32(rule.Substring(7 - i, 1)));
            }
        }

        private void CreateNextGeneration()
        {
            int prevGen = lastGeneration;
            lastGeneration++;
            for (int i = 0; i < maxCells; i++)
            {
                string rule = (CellularMatrix[prevGen, mod(i - 1, maxCells - 1)] ? "1" : "0")
                    + (CellularMatrix[prevGen, i] ? "1" : "0")
                    + (CellularMatrix[prevGen, mod(i + 1, maxCells - 1)] ? "1" : "0");

                CellularMatrix[lastGeneration, i] = Rules[rule];
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (action)
            {
                timer1.Stop();
            }
            else
            {
                CreateFirstGeneration();
                graph.Clear(Color.White);
                SetRules();
                timer1.Start();
            }
            action = !action;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lastGeneration >= maxGens - 1)
            {
                timer1.Stop();
                action = !action;
                return;
            }

            CreateNextGeneration();
            DrawLeftColumn();
            DrawGridTemplate();
            DrawCells();
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
