namespace WindowsFormsApplication5
{
    partial class PolicyControl
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.DescrLbl = new System.Windows.Forms.Label();
            this.polNameTxt = new System.Windows.Forms.TextBox();
            this.polDescTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.NameLbl.Location = new System.Drawing.Point(33, 47);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(141, 25);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Policy name: ";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrLbl.Location = new System.Drawing.Point(33, 98);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(132, 25);
            this.DescrLbl.TabIndex = 1;
            this.DescrLbl.Text = "Description: ";
            this.DescrLbl.Click += new System.EventHandler(this.DescrLbl_Click);
            // 
            // polNameTxt
            // 
            this.polNameTxt.Location = new System.Drawing.Point(36, 75);
            this.polNameTxt.Name = "polNameTxt";
            this.polNameTxt.Size = new System.Drawing.Size(198, 20);
            this.polNameTxt.TabIndex = 2;
            // 
            // polDescTxt
            // 
            this.polDescTxt.Location = new System.Drawing.Point(36, 132);
            this.polDescTxt.Multiline = true;
            this.polDescTxt.Name = "polDescTxt";
            this.polDescTxt.Size = new System.Drawing.Size(441, 126);
            this.polDescTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Policy";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(392, 264);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(157, 36);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // PolicyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polDescTxt);
            this.Controls.Add(this.polNameTxt);
            this.Controls.Add(this.DescrLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "PolicyControl";
            this.Size = new System.Drawing.Size(562, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.TextBox polNameTxt;
        private System.Windows.Forms.TextBox polDescTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create;
    }
}
