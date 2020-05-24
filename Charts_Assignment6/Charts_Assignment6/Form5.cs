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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //Back to portal button click event.
        private void btn_backToportal4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            string[] seriesArray = { "A","A-", "B","B-","C",
                                        "C-","D","D-","E","F"};
            uint[] minStrength = new uint[10];
            uint[] maxStrength = new uint[10];
            uint[] pointsArrayMid1 = new uint[10];
            uint[] pointsArrayMid2 = new uint[10];
            uint[] pointsArrayFinal = new uint[10]; 
            uint[] pointsArrayMid1min = new uint[10];
            uint[] pointsArrayMid2min = new uint[10];
            uint[] pointsArrayFinalmin = new uint[10];
            string[] inputData = System.IO.File.ReadAllLines(@"C:\Dot_Net\Assignment6\ColumnGraphData.txt");
            string[] inputData2 = System.IO.File.ReadAllLines(@"C:\Dot_Net\Assignment6\BoxPlot_GraphData.txt");

            string[] valuesMid1 = inputData[0].Split(' ');
            //Loading data points from input files.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid1[i] = Convert.ToUInt32(valuesMid1[i]);
            }

            string[] valuesMid2 = inputData[1].Split(' ');
            //Loading data points from input files.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid2[i] = Convert.ToUInt32(valuesMid2[i]);
            }
            //Loading data points from input files.
            string[] valuesFinal = inputData[2].Split(' ');

            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayFinal[i] = Convert.ToUInt32(valuesFinal[i]);
            }
            string[] valuesMinstrength = inputData2[0].Split(' ');

            for (int i = 0; i < seriesArray.Length; i++)
            {
                minStrength[i] = Convert.ToUInt32(valuesMinstrength[i]);
            }
            string[] valuesMaxstrength = inputData2[1].Split(' ');

            for (int i = 0; i < seriesArray.Length; i++)
            {
                maxStrength[i] = Convert.ToUInt32(valuesMaxstrength[i]);
            }

            string[] valuesMid1min = inputData2[2].Split(' ');
            //Loading data points from input files.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid1min[i] = Convert.ToUInt32(valuesMid1min[i]);
            }
            string[] valuesMid2min = inputData2[3].Split(' ');

            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid2min[i] = Convert.ToUInt32(valuesMid2min[i]);
            }
            string[] valuesFinalmin = inputData2[4].Split(' ');

            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayFinalmin[i] = Convert.ToUInt32(valuesFinalmin[i]);
            }

            box_chart4.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Set title
            box_chart4.ChartAreas["ChartArea1"].AxisX.Title= "Grades";

            box_chart4.Titles.Add("Students Grades for a particular course");
            box_chart4.ChartAreas["ChartArea1"].AxisY.Title = "Number of students";
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add points.
                this.box_chart4.Series["Mid1"].Points.AddXY(seriesArray[i],minStrength[i],maxStrength[i], pointsArrayMid1min[i], pointsArrayMid1[i]);
                this.box_chart4.Series["Mid2"].Points.AddXY(seriesArray[i], minStrength[i], maxStrength[i], pointsArrayMid2min[i],pointsArrayMid2[i]);
                this.box_chart4.Series["Final"].Points.AddXY(seriesArray[i], minStrength[i], maxStrength[i], pointsArrayFinalmin[i],pointsArrayFinal[i]);
               
            }
        }
        //Form closing event.
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 portalForm = new Form1();
             portalForm.Show();
        }
    }
}
