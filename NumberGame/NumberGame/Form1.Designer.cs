namespace NumberGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.PlayGround = new System.Windows.Forms.Panel();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.grpTimer = new System.Windows.Forms.GroupBox();
            this.currentTime_elapsed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTime_elapsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinTime = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.resultPane = new System.Windows.Forms.Panel();
            this.grpTimer.SuspendLayout();
            this.resultPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty Level";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "-Select-",
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(146, 43);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(131, 28);
            this.cmbDifficulty.TabIndex = 1;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(308, 43);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(105, 40);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(432, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // PlayGround
            // 
            this.PlayGround.Location = new System.Drawing.Point(13, 169);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(887, 453);
            this.PlayGround.TabIndex = 3;
            // 
            // _timer
            // 
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // grpTimer
            // 
            this.grpTimer.Controls.Add(this.currentTime_elapsed);
            this.grpTimer.Controls.Add(this.label3);
            this.grpTimer.Controls.Add(this.totalTime_elapsed);
            this.grpTimer.Controls.Add(this.label2);
            this.grpTimer.Location = new System.Drawing.Point(17, 96);
            this.grpTimer.Name = "grpTimer";
            this.grpTimer.Size = new System.Drawing.Size(646, 67);
            this.grpTimer.TabIndex = 4;
            this.grpTimer.TabStop = false;
            this.grpTimer.Visible = false;
            // 
            // currentTime_elapsed
            // 
            this.currentTime_elapsed.AutoSize = true;
            this.currentTime_elapsed.Location = new System.Drawing.Point(499, 22);
            this.currentTime_elapsed.Name = "currentTime_elapsed";
            this.currentTime_elapsed.Size = new System.Drawing.Size(0, 20);
            this.currentTime_elapsed.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Time :";
            // 
            // totalTime_elapsed
            // 
            this.totalTime_elapsed.AutoSize = true;
            this.totalTime_elapsed.Location = new System.Drawing.Point(103, 26);
            this.totalTime_elapsed.Name = "totalTime_elapsed";
            this.totalTime_elapsed.Size = new System.Drawing.Size(0, 20);
            this.totalTime_elapsed.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Time :";
            // 
            // lblMinTime
            // 
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Location = new System.Drawing.Point(59, 24);
            this.lblMinTime.Name = "lblMinTime";
            this.lblMinTime.Size = new System.Drawing.Size(0, 20);
            this.lblMinTime.TabIndex = 5;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(448, 24);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 20);
            this.lblAverage.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Best :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Average :";
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(585, 43);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(65, 40);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // resultPane
            // 
            this.resultPane.Controls.Add(this.label6);
            this.resultPane.Controls.Add(this.lblMinTime);
            this.resultPane.Controls.Add(this.lblAverage);
            this.resultPane.Controls.Add(this.label5);
            this.resultPane.Location = new System.Drawing.Point(10, 628);
            this.resultPane.Name = "resultPane";
            this.resultPane.Size = new System.Drawing.Size(890, 70);
            this.resultPane.TabIndex = 7;
            this.resultPane.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 729);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grpTimer);
            this.Controls.Add(this.PlayGround);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultPane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Number Game";
            this.grpTimer.ResumeLayout(false);
            this.grpTimer.PerformLayout();
            this.resultPane.ResumeLayout(false);
            this.resultPane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.GroupBox grpTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentTime_elapsed;
        private System.Windows.Forms.Label totalTime_elapsed;
        private System.Windows.Forms.Label lblMinTime;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel resultPane;
    }
}

