namespace WindowsFormsApplication5.Controls
{
    partial class ProjectProgress
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PolicyLbl = new System.Windows.Forms.Label();
            this.projectsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // PolicyLbl
            // 
            this.PolicyLbl.AutoSize = true;
            this.PolicyLbl.Location = new System.Drawing.Point(51, 28);
            this.PolicyLbl.Name = "PolicyLbl";
            this.PolicyLbl.Size = new System.Drawing.Size(35, 13);
            this.PolicyLbl.TabIndex = 1;
            this.PolicyLbl.Text = "label1";
            // 
            // projectsLbl
            // 
            this.projectsLbl.AutoSize = true;
            this.projectsLbl.Location = new System.Drawing.Point(54, 150);
            this.projectsLbl.Name = "projectsLbl";
            this.projectsLbl.Size = new System.Drawing.Size(45, 13);
            this.projectsLbl.TabIndex = 4;
            this.projectsLbl.Text = "Projects";
            // 
            // ProjectProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.projectsLbl);
            this.Controls.Add(this.PolicyLbl);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProjectProgress";
            this.Size = new System.Drawing.Size(457, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label PolicyLbl;
        private System.Windows.Forms.Label projectsLbl;
    }
}
