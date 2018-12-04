using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        int a, b, c;
        int x = 0;
        int z = 0;
        Bitmap bit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGraph(picture);
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = int.Parse(znach_a.Text);
                b = int.Parse(znach_b.Text);
                c = int.Parse(znach_c.Text);
                x = int.Parse(znach.Text);
                z = int.Parse(znach_x.Text);
                CreateGraph(picture);
            }
            finally { }
        }

        private Color color;

        private void picture_Load(object sender, EventArgs e)
        {

        }

        private void CreateGraph(ZedGraphControl zgc)
        {            
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "График параболы";
            myPane.XAxis.Title.Text = "Ось X";
            myPane.YAxis.Title.Text = "Ось Y";
            myPane.CurveList.Clear();

            double x1, y;
            
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            for (int i = x; i <= z; i++)
            {
                    x1 = i;
                    y = a * Math.Pow(x1, 2) + b * x1 + c;
                    list1.Add(x1, y);
                    list2.Add(-x1, y);
            }
            LineItem myCurve = myPane.AddCurve("", list1, color, SymbolType.Star); // отрисовываем график
            LineItem my1Curve = myPane.AddCurve("", list2, color, SymbolType.None); // отрисовываем график
            myCurve.Line.IsVisible = false;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.DashOn = 10;// Длина штрихов равна 10 пикселям
            myPane.XAxis.MajorGrid.DashOff = 5; //5 пикселей - пропуск
            // Задаем вид пунктирной линии для крупных рисок по оси Y:
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.DashOn = 10;
            myPane.YAxis.MajorGrid.DashOff = 5;
            zgc.AxisChange();
            zgc.Refresh();   
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = Color.Black;
        }
    }
}

