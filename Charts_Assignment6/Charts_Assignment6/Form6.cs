using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Charts_Assignment6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int ageYears = 100;
            this.naps_chart.Titles.Add("Naps Enjoyment over course of life :)");

            this.naps_chart.Palette = ChartColorPalette.EarthTones;
            naps_chart.ChartAreas["ChartArea1"].AxisX.Title = "Years";
            naps_chart.ChartAreas["ChartArea1"].AxisY.Title = "Enjoyment";

            for (int i = 1; i < ageYears;  i+=10)
            {
                // Add series.
                this.naps_chart.Series["Naps Enjoyment"].Points.AddXY(i, i*2);
                
            }

        }
        //Back to portal button click event
        private void btn_BacktoPortal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drawing graph event
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 portalForm = new Form1();
            portalForm.Show();
        }
    }
}
