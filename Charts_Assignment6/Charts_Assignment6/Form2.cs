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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Back to portal button click event
        private void btn_backToportal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //Form closed event 
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 portalForm = new Form1();
            portalForm.Show();
        }
        //Drawing graph event
        private void Form2_Load(object sender, EventArgs e)
        {
            // Data arrays.
            string[] seriesArray = { "A","A-", "B","B-","C",
                                        "C-","D","D-","E","F"};
            uint[] pointsArrayMid1 = new uint[10];
            uint[] pointsArrayMid2 = new uint[10]; 
            uint[] pointsArrayFinal = new uint[10]; 
            //Loading data points from input files
            string[] inputData = System.IO.File.ReadAllLines(@"C:\Dot_Net\Assignment6\ColumnGraphData.txt");
             string[] valuesMid1 = inputData[0].Split(' ');
                
            for (int i = 0; i < seriesArray.Length; i++)
            {
                 pointsArrayMid1[i]= Convert.ToUInt32(valuesMid1[i]);
            }

            string[] valuesMid2 = inputData[1].Split(' ');
            //Loading data points from input files
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid2[i] = Convert.ToUInt32(valuesMid2[i]);
            }

            string[] valuesFinal = inputData[2].Split(' ');
            //Loading data points from input files
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayFinal[i] = Convert.ToUInt32(valuesFinal[i]);
            }

            // Set palette.
            this.col_chart1.Palette = ChartColorPalette.Berry;

            // Set title.
            this.col_chart1.Titles.Add("Students Grades for a particular course");

            col_chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            col_chart1.ChartAreas["ChartArea1"].AxisX.Title = "Grades";
            col_chart1.ChartAreas["ChartArea1"].AxisY.Title = "Number of students";
            
            for (int i = 0; i < seriesArray.Length; i++)
            {

                // Add points to 3 types of series.
                this.col_chart1.Series["Mid1"].Points.AddXY(seriesArray[i], pointsArrayMid1[i]);
                this.col_chart1.Series["Mid2"].Points.AddXY(seriesArray[i], pointsArrayMid2[i]);
                this.col_chart1.Series["Final"].Points.AddXY(seriesArray[i], pointsArrayFinal[i]);
            }
            
        }
    }
}
