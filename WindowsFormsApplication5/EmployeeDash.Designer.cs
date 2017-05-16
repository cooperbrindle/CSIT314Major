namespace WindowsFormsApplication5
{
    partial class EmployeeDash
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
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(9, 100);
            this.addProjectBtn.Margin = new System.Windows.Forms.Padding(0, 25, 6, 25);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(186, 42);
            this.addProjectBtn.TabIndex = 6;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 427);
            this.Controls.Add(this.addProjectBtn);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EmployeeDash";
            this.Text = "nfprivilege";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main2_Load);
            this.Controls.SetChildIndex(this.addProjectBtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProjectBtn;
    }
}