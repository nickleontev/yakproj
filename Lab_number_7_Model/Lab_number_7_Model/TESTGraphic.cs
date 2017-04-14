using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_number_7_Model
{
    public partial class TESTGraphic : Form
    {
        public TESTGraphic()
        {
            InitializeComponent();



        }

        private void TESTGraphic_Load(object sender, EventArgs e)
        {

            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] y = { 1, 2, 3, 4, 5, 4, 6, 8, 5 };
            int[] y1 = { 1, 6, 3, 4, 5, 4,4, 1, 5 };
            int[] y2 = { 22, 2, 3, 4, 5, 4, 6, 8, 5 };



            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика

            for (int i = 0; i < x.Length; i++) {
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                chart1.Series[1].Points.AddXY(x[i], y1[i]);
                chart1.Series[2].Points.AddXY(x[i], y2[i]);}
        }
    }
}
