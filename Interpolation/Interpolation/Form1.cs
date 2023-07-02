using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonNewton.Checked = true;
        }

        private void BuildGraph_Click(object sender, EventArgs e)
        {
            Solving.Func func = Solving.Function;
            double x1, x2, h;
            int count = 0, n;
            x1 = Convert.ToDouble(textBoxX1.Text);
            x2 = Convert.ToDouble(textBoxX2.Text);
            h = Convert.ToDouble(textBoxH.Text);
            n = (int)((x2 - x1) / h) + 1;
            double[] X = new double[n];
            double[] Y = new double[n];

            chart1.Series.Clear();
            chart1.Series.Add("График 1");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            for (double i = x1; i <= x2; i += h, count++)
            {
                chart1.Series[0].Points.AddXY(i, func(i));
                X[count] = i;
                Y[count] = func(i);
            }

            chart1.Series.Add("График 2");
            chart1.Series[1].ChartType = SeriesChartType.Line;
            switch (true)
            {
                case true when radioButtonNewton.Checked:
                    double[,] mas = InterpolatiomLibrary.Interpolation.Divided(X, Y);
                    for (double i = x1; i < x2; i += h)
                        chart1.Series[1].Points.AddXY(i, InterpolatiomLibrary.Interpolation.Newton(i, X, Y, mas));
                    break;
                case true when radioButtonLagrange.Checked:
                    for (double i = x1; i < x2; i += h)
                        chart1.Series[1].Points.AddXY(i, InterpolatiomLibrary.Interpolation.Lagrange(i, X, Y));
                    break;
                case true when radioButtonSplain.Checked:
                    double[] a, b, c, d;
                    InterpolatiomLibrary.Interpolation.CalculateSplineCoefficients(X, Y, out a, out b, out c, out d);
                    for (double i = x1; i < x2 - h; i += h)
                        chart1.Series[1].Points.AddXY(i, InterpolatiomLibrary.Interpolation.Splain(i, X, a, b, c, d));
                    break;
                default:
                    break;
            }
        }
    }
}
