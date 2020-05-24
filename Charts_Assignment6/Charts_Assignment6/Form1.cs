using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts_Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        //Column chart button click event.
        private void btn_Chart1_Click(object sender, EventArgs e)
        {
            Form2 columnChart = new Form2();
            columnChart.Show();
            this.Visible = false;
        }

      
        //Closing application.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            System.Windows.Forms.Application.ExitThread();
        }
        //Pie chart button click event.
        private void btn_Chart2_Click(object sender, EventArgs e)
        {
            Form3 pieChart = new Form3();

            pieChart.Show();
            this.Visible = false;
        }
        //Line chart button click event.
        private void btn_Line_chart2_Click(object sender, EventArgs e)
        {
            Form4 lineChart = new Form4();

            lineChart.Show();
            this.Visible = false;
        }
        //BoxPlot chart button click event.
        private void btn_boxPlotchart_Click(object sender, EventArgs e)
        {
            Form5 boxChart = new Form5();

            boxChart.Show();
            this.Visible = false;
        }

        //Naps vs age chart button click event.
        private void btn_naps_chart_Click(object sender, EventArgs e)
        {
            Form6 napsChart = new Form6();

            napsChart.Show();
            this.Visible = false;
        }
        //Exit button click event.
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
