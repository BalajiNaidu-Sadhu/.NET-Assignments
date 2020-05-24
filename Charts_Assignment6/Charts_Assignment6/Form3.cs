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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Back to portal button click event.
        private void btn_backToportal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drawing graph click event.
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 portalForm = new Form1();
            portalForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Data arrays.
            string[] seriesArray = { "A","A-", "B","B-","C",
                                        "C-","D","D-","E","F"};
            uint[] pointsArrayMid1 = new uint[10];
            uint[] pointsArrayMid2 = new uint[10];
            uint[] pointsArrayFinal = new uint[10]; 
            string[] inputData = System.IO.File.ReadAllLines(@"C:\Dot_Net\Assignment6\ColumnGraphData.txt");
            string[] valuesMid1 = inputData[0].Split(' ');
            int[] finalPercentage = new int[10];
            int totalStudents = 60;

           
            //Loading data points from input files.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                pointsArrayMid1[i] = Convert.ToUInt32(valuesMid1[i]);
            }

            string[] valuesMid2 = inputData[1].Split(' ');

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
            for (int i = 0; i < seriesArray.Length; i++)
            {
                finalPercentage[i] = Convert.ToInt32((pointsArrayFinal[i] / totalStudents) * 100);
            }

            // Set palette.
            this.pie_chart2.Palette = ChartColorPalette.Fire;

            // Set title.
            this.pie_chart2.Titles.Add("Students Final Grade Percentage");
            

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add points.
                this.pie_chart2.Series["Final"].Points.AddXY(seriesArray[i], pointsArrayFinal[i]);

                
            }
        }
    }
}
