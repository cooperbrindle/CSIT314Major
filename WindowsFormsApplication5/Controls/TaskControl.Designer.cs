namespace WindowsFormsApplication5.Controls
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.Proj_Name = new System.Windows.Forms.Label();
            this.taskLbl = new System.Windows.Forms.Label();
            this.taskTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cstInput = new System.Windows.Forms.NumericUpDown();
            this.cstLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeInput = new System.Windows.Forms.NumericUpDown();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.wtLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.wrkrInput = new System.Windows.Forms.NumericUpDown();
            this.wrkrLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ecoInput = new System.Windows.Forms.NumericUpDown();
            this.ecoLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.happyInput = new System.Windows.Forms.NumericUpDown();
            this.happyLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.wtInput = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cstInput)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrkrInput)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecoInput)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.titleLbl.Location = new System.Drawing.Point(197, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(129, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Create Task";
            // 
            // Proj_Name
            // 
            this.Proj_Name.AutoSize = true;
            this.Proj_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Proj_Name.Location = new System.Drawing.Point(16, 34);
            this.Proj_Name.Name = "Proj_Name";
            this.Proj_Name.Size = new System.Drawing.Size(123, 20);
            this.Proj_Name.TabIndex = 1;
            this.Proj_Name.Text = "*Project Name*";
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.taskLbl.Location = new System.Drawing.Point(9, 10);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(136, 20);
            this.taskLbl.TabIndex = 2;
            this.taskLbl.Text = "Task Description";
            // 
            // taskTxt
            // 
            this.taskTxt.Location = new System.Drawing.Point(13, 33);
            this.taskTxt.Name = "taskTxt";
            this.taskTxt.Size = new System.Drawing.Size(479, 20);
            this.taskTxt.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.taskLbl);
            this.panel1.Controls.Add(this.taskTxt);
            this.panel1.Location = new System.Drawing.Point(20, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(525, 63);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cstInput);
            this.panel2.Controls.Add(this.cstLbl);
            this.panel2.Location = new System.Drawing.Point(20, 140);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(263, 43);
            this.panel2.TabIndex = 5;
            // 
            // cstInput
            // 
            this.cstInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cstInput.Location = new System.Drawing.Point(103, 10);
            this.cstInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cstInput.Name = "cstInput";
            this.cstInput.Size = new System.Drawing.Size(120, 20);
            this.cstInput.TabIndex = 3;
            // 
            // cstLbl
            // 
            this.cstLbl.AutoSize = true;
            this.cstLbl.BackColor = System.Drawing.SystemColors.Control;
            this.cstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cstLbl.Location = new System.Drawing.Point(9, 10);
            this.cstLbl.Name = "cstLbl";
            this.cstLbl.Size = new System.Drawing.Size(44, 20);
            this.cstLbl.TabIndex = 2;
            this.cstLbl.Text = "Cost";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.timeInput);
            this.panel3.Controls.Add(this.timeLbl);
            this.panel3.Location = new System.Drawing.Point(20, 189);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(263, 43);
            this.panel3.TabIndex = 6;
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(103, 10);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(120, 20);
            this.timeInput.TabIndex = 3;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.SystemColors.Control;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.timeLbl.Location = new System.Drawing.Point(9, 10);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(94, 20);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "TimeFrame";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.wtInput);
            this.panel4.Controls.Add(this.wtLbl);
            this.panel4.Location = new System.Drawing.Point(20, 238);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel4.Size = new System.Drawing.Size(263, 43);
            this.panel4.TabIndex = 6;
            // 
            // wtLbl
            // 
            this.wtLbl.AutoSize = true;
            this.wtLbl.BackColor = System.Drawing.SystemColors.Control;
            this.wtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.wtLbl.Location = new System.Drawing.Point(9, 10);
            this.wtLbl.Name = "wtLbl";
            this.wtLbl.Size = new System.Drawing.Size(83, 20);
            this.wtLbl.TabIndex = 2;
            this.wtLbl.Text = "Weighting";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.wrkrInput);
            this.panel5.Controls.Add(this.wrkrLbl);
            this.panel5.Location = new System.Drawing.Point(289, 140);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel5.Size = new System.Drawing.Size(256, 43);
            this.panel5.TabIndex = 6;
            // 
            // wrkrInput
            // 
            this.wrkrInput.Location = new System.Drawing.Point(103, 10);
            this.wrkrInput.Name = "wrkrInput";
            this.wrkrInput.Size = new System.Drawing.Size(120, 20);
            this.wrkrInput.TabIndex = 3;
            // 
            // wrkrLbl
            // 
            this.wrkrLbl.AutoSize = true;
            this.wrkrLbl.BackColor = System.Drawing.SystemColors.Control;
            this.wrkrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.wrkrLbl.Location = new System.Drawing.Point(9, 10);
            this.wrkrLbl.Name = "wrkrLbl";
            this.wrkrLbl.Size = new System.Drawing.Size(72, 20);
            this.wrkrLbl.TabIndex = 2;
            this.wrkrLbl.Text = "Workers";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ecoInput);
            this.panel6.Controls.Add(this.ecoLbl);
            this.panel6.Location = new System.Drawing.Point(289, 189);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel6.Size = new System.Drawing.Size(256, 43);
            this.panel6.TabIndex = 6;
            // 
            // ecoInput
            // 
            this.ecoInput.Location = new System.Drawing.Point(103, 10);
            this.ecoInput.Name = "ecoInput";
            this.ecoInput.Size = new System.Drawing.Size(120, 20);
            this.ecoInput.TabIndex = 3;
            // 
            // ecoLbl
            // 
            this.ecoLbl.AutoSize = true;
            this.ecoLbl.BackColor = System.Drawing.SystemColors.Control;
            this.ecoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ecoLbl.Location = new System.Drawing.Point(9, 10);
            this.ecoLbl.Name = "ecoLbl";
            this.ecoLbl.Size = new System.Drawing.Size(93, 20);
            this.ecoLbl.TabIndex = 2;
            this.ecoLbl.Text = "Eco Impact";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.happyInput);
            this.panel7.Controls.Add(this.happyLbl);
            this.panel7.Location = new System.Drawing.Point(289, 238);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.panel7.Size = new System.Drawing.Size(256, 43);
            this.panel7.TabIndex = 6;
            // 
            // happyInput
            // 
            this.happyInput.Location = new System.Drawing.Point(103, 10);
            this.happyInput.Name = "happyInput";
            this.happyInput.Size = new System.Drawing.Size(120, 20);
            this.happyInput.TabIndex = 3;
            // 
            // happyLbl
            // 
            this.happyLbl.AutoSize = true;
            this.happyLbl.BackColor = System.Drawing.SystemColors.Control;
            this.happyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.happyLbl.Location = new System.Drawing.Point(9, 10);
            this.happyLbl.Name = "happyLbl";
            this.happyLbl.Size = new System.Drawing.Size(89, 20);
            this.happyLbl.TabIndex = 2;
            this.happyLbl.Text = "Happiness";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(447, 286);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(98, 10);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(116, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // wtInput
            // 
            this.wtInput.Location = new System.Drawing.Point(220, 10);
            this.wtInput.Name = "wtInput";
            this.wtInput.Size = new System.Drawing.Size(42, 20);
            this.wtInput.TabIndex = 3;
            this.wtInput.ValueChanged += new System.EventHandler(this.wtInput_ValueChanged);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Proj_Name);
            this.Controls.Add(this.titleLbl);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(558, 312);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cstInput)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrkrInput)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecoInput)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label Proj_Name;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.TextBox taskTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cstLbl;
        private System.Windows.Forms.NumericUpDown cstInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown timeInput;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label wtLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown wrkrInput;
        private System.Windows.Forms.Label wrkrLbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown ecoInput;
        private System.Windows.Forms.Label ecoLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown happyInput;
        private System.Windows.Forms.Label happyLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown wtInput;
    }
}
