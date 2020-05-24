namespace WindowsFormsAssignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.allClassTypes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPercentageServer = new System.Windows.Forms.ComboBox();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAllRoll = new System.Windows.Forms.Button();
            this.cbAllRollServer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAllRoll = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMinAllRoll = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudMaxAllRoll = new System.Windows.Forms.NumericUpDown();
            this.cbGuildTypes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAllGuildType = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.rbDamage = new System.Windows.Forms.RadioButton();
            this.pRoles = new System.Windows.Forms.Panel();
            this.rbTank = new System.Windows.Forms.RadioButton();
            this.rbHealer = new System.Windows.Forms.RadioButton();
            this.btnAllPlayersArenot = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPercentageAllGuilds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAllRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAllRoll)).BeginInit();
            this.pRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Class Types from a Single Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(533, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Query";
            // 
            // rtbQuery
            // 
            this.rtbQuery.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuery.Location = new System.Drawing.Point(464, 57);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(590, 588);
            this.rtbQuery.TabIndex = 2;
            this.rtbQuery.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(178, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(29, 94);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 5;
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(181, 94);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(121, 21);
            this.cbServer.TabIndex = 6;
            // 
            // allClassTypes
            // 
            this.allClassTypes.Location = new System.Drawing.Point(356, 94);
            this.allClassTypes.Name = "allClassTypes";
            this.allClassTypes.Size = new System.Drawing.Size(102, 23);
            this.allClassTypes.TabIndex = 7;
            this.allClassTypes.Text = "Show Results";
            this.allClassTypes.UseVisualStyleBackColor = true;
            this.allClassTypes.Click += new System.EventHandler(this.allClassTypes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(26, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Percentage of Each race From a Single Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(178, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Server";
            // 
            // cbPercentageServer
            // 
            this.cbPercentageServer.FormattingEnabled = true;
            this.cbPercentageServer.Location = new System.Drawing.Point(181, 200);
            this.cbPercentageServer.Name = "cbPercentageServer";
            this.cbPercentageServer.Size = new System.Drawing.Size(121, 21);
            this.cbPercentageServer.TabIndex = 10;
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(356, 200);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(102, 23);
            this.btnPercentage.TabIndex = 11;
            this.btnPercentage.Text = "Show Results";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(26, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "All Roll Types from a Single Server With in a Level Range";
            // 
            // btnAllRoll
            // 
            this.btnAllRoll.Location = new System.Drawing.Point(356, 300);
            this.btnAllRoll.Name = "btnAllRoll";
            this.btnAllRoll.Size = new System.Drawing.Size(102, 23);
            this.btnAllRoll.TabIndex = 15;
            this.btnAllRoll.Text = "Show Results";
            this.btnAllRoll.UseVisualStyleBackColor = true;
            this.btnAllRoll.Click += new System.EventHandler(this.btnAllRoll_Click);
            // 
            // cbAllRollServer
            // 
            this.cbAllRollServer.FormattingEnabled = true;
            this.cbAllRollServer.Location = new System.Drawing.Point(181, 300);
            this.cbAllRollServer.Name = "cbAllRollServer";
            this.cbAllRollServer.Size = new System.Drawing.Size(121, 21);
            this.cbAllRollServer.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(178, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Server";
            // 
            // cbAllRoll
            // 
            this.cbAllRoll.FormattingEnabled = true;
            this.cbAllRoll.Location = new System.Drawing.Point(29, 300);
            this.cbAllRoll.Name = "cbAllRoll";
            this.cbAllRoll.Size = new System.Drawing.Size(121, 21);
            this.cbAllRoll.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(26, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Role";
            // 
            // nudMinAllRoll
            // 
            this.nudMinAllRoll.Location = new System.Drawing.Point(29, 354);
            this.nudMinAllRoll.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinAllRoll.Name = "nudMinAllRoll";
            this.nudMinAllRoll.Size = new System.Drawing.Size(44, 20);
            this.nudMinAllRoll.TabIndex = 18;
            this.nudMinAllRoll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinAllRoll.ValueChanged += new System.EventHandler(this.nudMinAllRoll_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(26, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(101, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Max";
            // 
            // nudMaxAllRoll
            // 
            this.nudMaxAllRoll.Location = new System.Drawing.Point(104, 354);
            this.nudMaxAllRoll.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxAllRoll.Name = "nudMaxAllRoll";
            this.nudMaxAllRoll.Size = new System.Drawing.Size(44, 20);
            this.nudMaxAllRoll.TabIndex = 20;
            this.nudMaxAllRoll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxAllRoll.ValueChanged += new System.EventHandler(this.nudMaxAllRoll_ValueChanged);
            // 
            // cbGuildTypes
            // 
            this.cbGuildTypes.FormattingEnabled = true;
            this.cbGuildTypes.Location = new System.Drawing.Point(27, 432);
            this.cbGuildTypes.Name = "cbGuildTypes";
            this.cbGuildTypes.Size = new System.Drawing.Size(121, 21);
            this.cbGuildTypes.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(26, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "All Guilds of a Single Type";
            // 
            // btnAllGuildType
            // 
            this.btnAllGuildType.Location = new System.Drawing.Point(351, 430);
            this.btnAllGuildType.Name = "btnAllGuildType";
            this.btnAllGuildType.Size = new System.Drawing.Size(102, 23);
            this.btnAllGuildType.TabIndex = 24;
            this.btnAllGuildType.Text = "Show Results";
            this.btnAllGuildType.UseVisualStyleBackColor = true;
            this.btnAllGuildType.Click += new System.EventHandler(this.btnAllGuildType_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(27, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(396, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "All Players Who Could Fill a Role But Presently Aren\'t";
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamage.ForeColor = System.Drawing.SystemColors.Window;
            this.rbDamage.Location = new System.Drawing.Point(152, 17);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(79, 21);
            this.rbDamage.TabIndex = 28;
            this.rbDamage.TabStop = true;
            this.rbDamage.Text = "Damage";
            this.rbDamage.UseVisualStyleBackColor = false;
            // 
            // pRoles
            // 
            this.pRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRoles.Controls.Add(this.rbTank);
            this.pRoles.Controls.Add(this.rbHealer);
            this.pRoles.Controls.Add(this.rbDamage);
            this.pRoles.Location = new System.Drawing.Point(29, 511);
            this.pRoles.Name = "pRoles";
            this.pRoles.Size = new System.Drawing.Size(232, 55);
            this.pRoles.TabIndex = 29;
            // 
            // rbTank
            // 
            this.rbTank.AutoSize = true;
            this.rbTank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTank.ForeColor = System.Drawing.SystemColors.Window;
            this.rbTank.Location = new System.Drawing.Point(3, 17);
            this.rbTank.Name = "rbTank";
            this.rbTank.Size = new System.Drawing.Size(58, 21);
            this.rbTank.TabIndex = 30;
            this.rbTank.TabStop = true;
            this.rbTank.Text = "Tank";
            this.rbTank.UseVisualStyleBackColor = false;
            // 
            // rbHealer
            // 
            this.rbHealer.AutoSize = true;
            this.rbHealer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbHealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHealer.ForeColor = System.Drawing.SystemColors.Window;
            this.rbHealer.Location = new System.Drawing.Point(75, 17);
            this.rbHealer.Name = "rbHealer";
            this.rbHealer.Size = new System.Drawing.Size(68, 21);
            this.rbHealer.TabIndex = 29;
            this.rbHealer.TabStop = true;
            this.rbHealer.Text = "Healer";
            this.rbHealer.UseVisualStyleBackColor = false;
            // 
            // btnAllPlayersArenot
            // 
            this.btnAllPlayersArenot.Location = new System.Drawing.Point(351, 526);
            this.btnAllPlayersArenot.Name = "btnAllPlayersArenot";
            this.btnAllPlayersArenot.Size = new System.Drawing.Size(102, 23);
            this.btnAllPlayersArenot.TabIndex = 30;
            this.btnAllPlayersArenot.Text = "Show Results";
            this.btnAllPlayersArenot.UseVisualStyleBackColor = true;
            this.btnAllPlayersArenot.Click += new System.EventHandler(this.btnAllPlayersArenot_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(24, 584);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(338, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // btnPercentageAllGuilds
            // 
            this.btnPercentageAllGuilds.Location = new System.Drawing.Point(351, 613);
            this.btnPercentageAllGuilds.Name = "btnPercentageAllGuilds";
            this.btnPercentageAllGuilds.Size = new System.Drawing.Size(102, 23);
            this.btnPercentageAllGuilds.TabIndex = 32;
            this.btnPercentageAllGuilds.Text = "Show Results";
            this.btnPercentageAllGuilds.UseVisualStyleBackColor = true;
            this.btnPercentageAllGuilds.Click += new System.EventHandler(this.btnPercentageAllGuilds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1058, 657);
            this.Controls.Add(this.btnPercentageAllGuilds);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAllPlayersArenot);
            this.Controls.Add(this.pRoles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAllGuildType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbGuildTypes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudMaxAllRoll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudMinAllRoll);
            this.Controls.Add(this.cbAllRoll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAllRoll);
            this.Controls.Add(this.cbAllRollServer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.cbPercentageServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.allClassTypes);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1074, 696);
            this.MinimumSize = new System.Drawing.Size(1074, 696);
            this.Name = "Form1";
            this.Text = "World of ConflictCraft:Query System";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAllRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAllRoll)).EndInit();
            this.pRoles.ResumeLayout(false);
            this.pRoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Button allClassTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPercentageServer;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAllRoll;
        private System.Windows.Forms.ComboBox cbAllRollServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAllRoll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMinAllRoll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudMaxAllRoll;
        private System.Windows.Forms.ComboBox cbGuildTypes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAllGuildType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbDamage;
        private System.Windows.Forms.Panel pRoles;
        private System.Windows.Forms.RadioButton rbTank;
        private System.Windows.Forms.RadioButton rbHealer;
        private System.Windows.Forms.Button btnAllPlayersArenot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPercentageAllGuilds;
    }
}

