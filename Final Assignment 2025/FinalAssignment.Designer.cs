namespace Final_Assignment_2025
{
    partial class FinalAssignment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.chkExperience = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCombat = new System.Windows.Forms.RadioButton();
            this.rdbAdventure = new System.Windows.Forms.RadioButton();
            this.rdbSport = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblAccPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAveScore = new System.Windows.Forms.Label();
            this.lblValidReviewers = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tmsProcess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClear,
            this.tmsExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 29);
            this.toolStripMenuItem1.Text = "FILE";
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(270, 34);
            this.tsmClear.Text = "CLEAR";
            this.tsmClear.Click += new System.EventHandler(this.tsmClear_Click);
            // 
            // tmsExit
            // 
            this.tmsExit.Name = "tmsExit";
            this.tmsExit.Size = new System.Drawing.Size(270, 34);
            this.tmsExit.Text = "EXIT";
            this.tmsExit.Click += new System.EventHandler(this.tmsExit_Click);
            // 
            // tmsProcess
            // 
            this.tmsProcess.Name = "tmsProcess";
            this.tmsProcess.Size = new System.Drawing.Size(103, 30);
            this.tmsProcess.Text = "PROCESS";
            this.tmsProcess.Click += new System.EventHandler(this.tmsProcess_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(348, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "GO GAMING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "PHONE NUMBER:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(193, 134);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 26);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // chkExperience
            // 
            this.chkExperience.AutoSize = true;
            this.chkExperience.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkExperience.Location = new System.Drawing.Point(16, 217);
            this.chkExperience.Name = "chkExperience";
            this.chkExperience.Size = new System.Drawing.Size(143, 27);
            this.chkExperience.TabIndex = 5;
            this.chkExperience.Text = "EXPERIENCE";
            this.chkExperience.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCombat);
            this.groupBox1.Controls.Add(this.rdbAdventure);
            this.groupBox1.Controls.Add(this.rdbSport);
            this.groupBox1.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(527, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENRE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbCombat
            // 
            this.rdbCombat.AutoSize = true;
            this.rdbCombat.Location = new System.Drawing.Point(17, 128);
            this.rdbCombat.Name = "rdbCombat";
            this.rdbCombat.Size = new System.Drawing.Size(114, 27);
            this.rdbCombat.TabIndex = 2;
            this.rdbCombat.TabStop = true;
            this.rdbCombat.Text = "COMBAT";
            this.rdbCombat.UseVisualStyleBackColor = true;
            // 
            // rdbAdventure
            // 
            this.rdbAdventure.AutoSize = true;
            this.rdbAdventure.Location = new System.Drawing.Point(17, 84);
            this.rdbAdventure.Name = "rdbAdventure";
            this.rdbAdventure.Size = new System.Drawing.Size(138, 27);
            this.rdbAdventure.TabIndex = 1;
            this.rdbAdventure.TabStop = true;
            this.rdbAdventure.Text = "ADVENTURE";
            this.rdbAdventure.UseVisualStyleBackColor = true;
            // 
            // rdbSport
            // 
            this.rdbSport.AutoSize = true;
            this.rdbSport.Location = new System.Drawing.Point(17, 37);
            this.rdbSport.Name = "rdbSport";
            this.rdbSport.Size = new System.Drawing.Size(91, 27);
            this.rdbSport.TabIndex = 0;
            this.rdbSport.TabStop = true;
            this.rdbSport.Text = "SPORT";
            this.rdbSport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PAYMENT TO REVIEWER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PAYMENT TO ALL REVIEWERS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(373, 343);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(40, 20);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.Text = "0.00";
            // 
            // lblAccPayment
            // 
            this.lblAccPayment.AutoSize = true;
            this.lblAccPayment.Location = new System.Drawing.Point(372, 409);
            this.lblAccPayment.Name = "lblAccPayment";
            this.lblAccPayment.Size = new System.Drawing.Size(40, 20);
            this.lblAccPayment.TabIndex = 10;
            this.lblAccPayment.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "AVERAGE SCORE BY REVIEWER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "NUMBER OF VALID REVIWERS:";
            // 
            // lblAveScore
            // 
            this.lblAveScore.AutoSize = true;
            this.lblAveScore.Location = new System.Drawing.Point(882, 343);
            this.lblAveScore.Name = "lblAveScore";
            this.lblAveScore.Size = new System.Drawing.Size(18, 20);
            this.lblAveScore.TabIndex = 13;
            this.lblAveScore.Text = "0";
            // 
            // lblValidReviewers
            // 
            this.lblValidReviewers.AutoSize = true;
            this.lblValidReviewers.Location = new System.Drawing.Point(886, 408);
            this.lblValidReviewers.Name = "lblValidReviewers";
            this.lblValidReviewers.Size = new System.Drawing.Size(18, 20);
            this.lblValidReviewers.TabIndex = 14;
            this.lblValidReviewers.Text = "0";
            // 
            // FinalAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 491);
            this.Controls.Add(this.lblValidReviewers);
            this.Controls.Add(this.lblAveScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAccPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkExperience);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinalAssignment";
            this.Text = "FINAL ASSIGNMENT 2025";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmsProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.ToolStripMenuItem tmsExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox chkExperience;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCombat;
        private System.Windows.Forms.RadioButton rdbAdventure;
        private System.Windows.Forms.RadioButton rdbSport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblAccPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAveScore;
        private System.Windows.Forms.Label lblValidReviewers;
    }
}

