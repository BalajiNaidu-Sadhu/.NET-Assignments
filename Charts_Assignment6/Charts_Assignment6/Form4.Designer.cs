namespace Charts_Assignment6
{
    partial class Form4
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
            this.line_chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_backToportal3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.line_chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // line_chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.line_chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.line_chart3.Legends.Add(legend1);
            this.line_chart3.Location = new System.Drawing.Point(33, 95);
            this.line_chart3.Name = "line_chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Mid1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Mid2";
            series2.ShadowColor = System.Drawing.Color.Red;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Final";
            this.line_chart3.Series.Add(series1);
            this.line_chart3.Series.Add(series2);
            this.line_chart3.Series.Add(series3);
            this.line_chart3.Size = new System.Drawing.Size(682, 300);
            this.line_chart3.TabIndex = 0;
            // 
            // btn_backToportal3
            // 
            this.btn_backToportal3.Location = new System.Drawing.Point(33, 401);
            this.btn_backToportal3.Name = "btn_backToportal3";
            this.btn_backToportal3.Size = new System.Drawing.Size(110, 23);
            this.btn_backToportal3.TabIndex = 1;
            this.btn_backToportal3.Text = "Back to Portal";
            this.btn_backToportal3.UseVisualStyleBackColor = true;
            this.btn_backToportal3.Click += new System.EventHandler(this.btn_backToportal3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line Graph";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description: Graph showing stats of Grades of Students in 3 different exams held " +
    "in a semester(Mid Term1 ,Mid Term2,Final)";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_backToportal3);
            this.Controls.Add(this.line_chart3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.line_chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart line_chart3;
        private System.Windows.Forms.Button btn_backToportal3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}