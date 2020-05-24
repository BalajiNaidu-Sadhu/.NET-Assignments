namespace Charts_Assignment6
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_backToportal4 = new System.Windows.Forms.Button();
            this.box_chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backToportal4
            // 
            this.btn_backToportal4.Location = new System.Drawing.Point(45, 406);
            this.btn_backToportal4.Name = "btn_backToportal4";
            this.btn_backToportal4.Size = new System.Drawing.Size(105, 23);
            this.btn_backToportal4.TabIndex = 0;
            this.btn_backToportal4.Text = "Back To Portal";
            this.btn_backToportal4.UseVisualStyleBackColor = true;
            this.btn_backToportal4.Click += new System.EventHandler(this.btn_backToportal4_Click);
            // 
            // box_chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.box_chart4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.box_chart4.Legends.Add(legend1);
            this.box_chart4.Location = new System.Drawing.Point(45, 100);
            this.box_chart4.Name = "box_chart4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series1.Legend = "Legend1";
            series1.Name = "Mid1";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series2.Legend = "Legend1";
            series2.Name = "Mid2";
            series2.YValuesPerPoint = 6;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series3.Legend = "Legend1";
            series3.Name = "Final";
            series3.YValuesPerPoint = 6;
            this.box_chart4.Series.Add(series1);
            this.box_chart4.Series.Add(series2);
            this.box_chart4.Series.Add(series3);
            this.box_chart4.Size = new System.Drawing.Size(671, 300);
            this.box_chart4.TabIndex = 1;
            this.box_chart4.Text = "Box Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(347, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Box Plot Graph";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description: Graph showing stats of Grades of Students in 3 different exams held " +
    "in a semester(Mid Term1 ,Mid Term2,Final)";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_chart4);
            this.Controls.Add(this.btn_backToportal4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backToportal4;
        private System.Windows.Forms.DataVisualization.Charting.Chart box_chart4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}