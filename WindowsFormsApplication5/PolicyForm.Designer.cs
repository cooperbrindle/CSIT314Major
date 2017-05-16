namespace WindowsFormsApplication5
{
    partial class PolicyForm
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
            this.NameLbl.Location = new System.Drawing.Point(29, 46);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(70, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Policy name: ";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Location = new System.Drawing.Point(32, 90);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(66, 13);
            this.DescrLbl.TabIndex = 1;
            this.DescrLbl.Text = "Description: ";
            // 
            // polNameTxt
            // 
            this.polNameTxt.Location = new System.Drawing.Point(99, 46);
            this.polNameTxt.Name = "polNameTxt";
            this.polNameTxt.Size = new System.Drawing.Size(100, 20);
            this.polNameTxt.TabIndex = 2;
            // 
            // polDescTxt
            // 
            this.polDescTxt.Location = new System.Drawing.Point(99, 90);
            this.polDescTxt.Name = "polDescTxt";
            this.polDescTxt.Size = new System.Drawing.Size(100, 20);
            this.polDescTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Policy";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(35, 132);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // PolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polDescTxt);
            this.Controls.Add(this.polNameTxt);
            this.Controls.Add(this.DescrLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "PolicyForm";
            this.Size = new System.Drawing.Size(329, 209);
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
