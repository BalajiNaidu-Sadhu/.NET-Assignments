namespace WindowsFormsApp2
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
            this.PrintGuildRoster = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchGuildName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplySearchCriteria = new System.Windows.Forms.Button();
            this.LeaveGuild = new System.Windows.Forms.Button();
            this.JoinGuild = new System.Windows.Forms.Button();
            this.DisbandGuild = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddGuild = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuildName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbGuilds = new System.Windows.Forms.ListBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintGuildRoster
            // 
            this.PrintGuildRoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintGuildRoster.Location = new System.Drawing.Point(6, 19);
            this.PrintGuildRoster.Name = "PrintGuildRoster";
            this.PrintGuildRoster.Size = new System.Drawing.Size(132, 23);
            this.PrintGuildRoster.TabIndex = 0;
            this.PrintGuildRoster.Text = "PrintGuildRoster";
            this.PrintGuildRoster.UseVisualStyleBackColor = true;
            this.PrintGuildRoster.Click += new System.EventHandler(this.PrintGuildRoster_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(472, 21);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(292, 355);
            this.lbPlayers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchGuildName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchPlayerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ApplySearchCriteria);
            this.groupBox1.Controls.Add(this.LeaveGuild);
            this.groupBox1.Controls.Add(this.JoinGuild);
            this.groupBox1.Controls.Add(this.DisbandGuild);
            this.groupBox1.Controls.Add(this.PrintGuildRoster);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management Functions";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSearchGuildName
            // 
            this.txtSearchGuildName.Location = new System.Drawing.Point(164, 90);
            this.txtSearchGuildName.Name = "txtSearchGuildName";
            this.txtSearchGuildName.Size = new System.Drawing.Size(155, 20);
            this.txtSearchGuildName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Guild(by Server)";
            // 
            // txtSearchPlayerName
            // 
            this.txtSearchPlayerName.Location = new System.Drawing.Point(164, 37);
            this.txtSearchPlayerName.Name = "txtSearchPlayerName";
            this.txtSearchPlayerName.Size = new System.Drawing.Size(155, 20);
            this.txtSearchPlayerName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Player(by Name)";
            // 
            // ApplySearchCriteria
            // 
            this.ApplySearchCriteria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplySearchCriteria.Location = new System.Drawing.Point(6, 132);
            this.ApplySearchCriteria.Name = "ApplySearchCriteria";
            this.ApplySearchCriteria.Size = new System.Drawing.Size(132, 23);
            this.ApplySearchCriteria.TabIndex = 4;
            this.ApplySearchCriteria.Text = "Apply Search Criteria";
            this.ApplySearchCriteria.UseVisualStyleBackColor = true;
            this.ApplySearchCriteria.Click += new System.EventHandler(this.ApplySearchCriteria_Click);
            // 
            // LeaveGuild
            // 
            this.LeaveGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeaveGuild.Location = new System.Drawing.Point(6, 103);
            this.LeaveGuild.Name = "LeaveGuild";
            this.LeaveGuild.Size = new System.Drawing.Size(132, 23);
            this.LeaveGuild.TabIndex = 3;
            this.LeaveGuild.Text = "Leave Guild";
            this.LeaveGuild.UseVisualStyleBackColor = true;
            this.LeaveGuild.Click += new System.EventHandler(this.LeaveGuild_Click);
            // 
            // JoinGuild
            // 
            this.JoinGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JoinGuild.Location = new System.Drawing.Point(6, 74);
            this.JoinGuild.Name = "JoinGuild";
            this.JoinGuild.Size = new System.Drawing.Size(132, 23);
            this.JoinGuild.TabIndex = 2;
            this.JoinGuild.Text = "Join Guild";
            this.JoinGuild.UseVisualStyleBackColor = true;
            // 
            // DisbandGuild
            // 
            this.DisbandGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisbandGuild.Location = new System.Drawing.Point(6, 48);
            this.DisbandGuild.Name = "DisbandGuild";
            this.DisbandGuild.Size = new System.Drawing.Size(132, 23);
            this.DisbandGuild.TabIndex = 1;
            this.DisbandGuild.Text = "Disband Guild";
            this.DisbandGuild.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddPlayer);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.cmbRole);
            this.groupBox2.Controls.Add(this.cmbRace);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPlayerName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(29, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // AddPlayer
            // 
            this.AddPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPlayer.Location = new System.Drawing.Point(291, 37);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(89, 23);
            this.AddPlayer.TabIndex = 13;
            this.AddPlayer.Text = "Add Player";
            this.AddPlayer.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(6, 76);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(132, 21);
            this.cmbClass.TabIndex = 12;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(164, 76);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.TabIndex = 11;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(164, 37);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 21);
            this.cmbRace.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Race";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(6, 37);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(132, 20);
            this.txtPlayerName.TabIndex = 6;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddGuild);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGuildName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(29, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 142);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
            // 
            // AddGuild
            // 
            this.AddGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddGuild.Location = new System.Drawing.Point(291, 37);
            this.AddGuild.Name = "AddGuild";
            this.AddGuild.Size = new System.Drawing.Size(89, 23);
            this.AddGuild.TabIndex = 13;
            this.AddGuild.Text = "Add Guild";
            this.AddGuild.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(164, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(164, 37);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Server";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtGuildName
            // 
            this.txtGuildName.Location = new System.Drawing.Point(6, 37);
            this.txtGuildName.Name = "txtGuildName";
            this.txtGuildName.Size = new System.Drawing.Size(132, 20);
            this.txtGuildName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Guild Name";
            // 
            // lbGuilds
            // 
            this.lbGuilds.FormattingEnabled = true;
            this.lbGuilds.Location = new System.Drawing.Point(802, 21);
            this.lbGuilds.Name = "lbGuilds";
            this.lbGuilds.Size = new System.Drawing.Size(269, 355);
            this.lbGuilds.TabIndex = 5;
            // 
            // rtOutput
            // 
            this.rtOutput.Location = new System.Drawing.Point(35, 575);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(977, 158);
            this.rtOutput.TabIndex = 6;
            this.rtOutput.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(32, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1083, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtOutput);
            this.Controls.Add(this.lbGuilds);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintGuildRoster;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchGuildName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplySearchCriteria;
        private System.Windows.Forms.Button LeaveGuild;
        private System.Windows.Forms.Button JoinGuild;
        private System.Windows.Forms.Button DisbandGuild;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddGuild;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGuildName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbGuilds;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.Label label8;
    }
}

