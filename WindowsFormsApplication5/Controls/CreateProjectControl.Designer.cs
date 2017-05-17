namespace WindowsFormsApplication5
{
    partial class CreateProjectControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.stakeholderTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ObjectiveTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.deptTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.budgetInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(114, 40);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // stakeholderTxt
            // 
            this.stakeholderTxt.Location = new System.Drawing.Point(114, 130);
            this.stakeholderTxt.Name = "stakeholderTxt";
            this.stakeholderTxt.Size = new System.Drawing.Size(100, 20);
            this.stakeholderTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stakeholders";
            // 
            // ObjectiveTxt
            // 
            this.ObjectiveTxt.Location = new System.Drawing.Point(114, 86);
            this.ObjectiveTxt.Name = "ObjectiveTxt";
            this.ObjectiveTxt.Size = new System.Drawing.Size(100, 20);
            this.ObjectiveTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Objective";
            // 
            // budgetInput
            // 
            this.budgetInput.Location = new System.Drawing.Point(114, 172);
            this.budgetInput.Name = "budgetInput";
            this.budgetInput.Size = new System.Drawing.Size(100, 20);
            this.budgetInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Budget";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(37, 253);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "button1";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deptTxt
            // 
            this.deptTxt.Location = new System.Drawing.Point(114, 214);
            this.deptTxt.Name = "deptTxt";
            this.deptTxt.Size = new System.Drawing.Size(100, 20);
            this.deptTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department";
            // 
            // CreateProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deptTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.budgetInput);
            this.Controls.Add(this.ObjectiveTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stakeholderTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "CreateProjectControl";
            this.Size = new System.Drawing.Size(562, 316);
            ((System.ComponentModel.ISupportInitialize)(this.budgetInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox stakeholderTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ObjectiveTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown budgetInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox deptTxt;
        private System.Windows.Forms.Label label5;
    }
}
