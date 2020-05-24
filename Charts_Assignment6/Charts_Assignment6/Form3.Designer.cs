namespace Charts_Assignment6
{
    partial class Form3
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
            this.btn_backToportal2 = new System.Windows.Forms.Button();
            this.pie_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backToportal2
            // 
            this.btn_backToportal2.Location = new System.Drawing.Point(97, 452);
            this.btn_backToportal2.Name = "btn_backToportal2";
            this.btn_backToportal2.Size = new System.Drawing.Size(123, 23);
            this.btn_backToportal2.TabIndex = 0;
            this.btn_backToportal2.Text = "Back to Portal";
            this.btn_backToportal2.UseVisualStyleBackColor = true;
            this.btn_backToportal2.Click += new System.EventHandler(this.btn_backToportal2_Click);
            // 
            // pie_chart2
            // 
            this.pie_chart2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pie_chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.pie_chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pie_chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.pie_chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pie_chart2.Legends.Add(legend1);
            this.pie_chart2.Location = new System.Drawing.Point(97, 109);
            this.pie_chart2.Name = "pie_chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.Name = "Mid1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Mid2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Label = "#PERCENT";
            series3.Legend = "Legend1";
            series3.LegendText = "#VALX";
            series3.Name = "Final";
            this.pie_chart2.Series.Add(series1);
            this.pie_chart2.Series.Add(series2);
            this.pie_chart2.Series.Add(series3);
            this.pie_chart2.Size = new System.Drawing.Size(524, 326);
            this.pie_chart2.TabIndex = 1;
            this.pie_chart2.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(326, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pie Chart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description: Graph showing stats of Students Final Grades Percentage";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pie_chart2);
            this.Controls.Add(this.btn_backToportal2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backToportal2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}