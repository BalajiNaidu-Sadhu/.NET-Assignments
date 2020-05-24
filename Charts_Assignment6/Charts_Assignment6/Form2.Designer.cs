namespace Charts_Assignment6
{
    partial class Form2
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
            this.btn_backToportal = new System.Windows.Forms.Button();
            this.col_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.col_chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backToportal
            // 
            this.btn_backToportal.Location = new System.Drawing.Point(53, 443);
            this.btn_backToportal.Name = "btn_backToportal";
            this.btn_backToportal.Size = new System.Drawing.Size(109, 23);
            this.btn_backToportal.TabIndex = 0;
            this.btn_backToportal.Text = "Back to portal";
            this.btn_backToportal.UseVisualStyleBackColor = true;
            this.btn_backToportal.Click += new System.EventHandler(this.btn_backToportal_Click);
            // 
            // col_chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.col_chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.col_chart1.Legends.Add(legend1);
            this.col_chart1.Location = new System.Drawing.Point(53, 93);
            this.col_chart1.Name = "col_chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Mid1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Mid2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Final";
            this.col_chart1.Series.Add(series1);
            this.col_chart1.Series.Add(series2);
            this.col_chart1.Series.Add(series3);
            this.col_chart1.Size = new System.Drawing.Size(711, 330);
            this.col_chart1.TabIndex = 1;
            this.col_chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column Chart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description: Graph showing stats of Grades of Students in 3 different exams held " +
    "in a semester(Mid Term1 ,Mid Term2,Final)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.col_chart1);
            this.Controls.Add(this.btn_backToportal);
            this.Name = "Form2";
            this.Text = "Chart1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.col_chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backToportal;
        private System.Windows.Forms.DataVisualization.Charting.Chart col_chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}