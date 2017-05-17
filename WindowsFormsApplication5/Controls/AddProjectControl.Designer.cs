namespace WindowsFormsApplication5
{
    partial class AddProjectControl
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
            this.ProjectListView = new System.Windows.Forms.ListBox();
            this.createProjectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectListView
            // 
            this.ProjectListView.FormattingEnabled = true;
            this.ProjectListView.Location = new System.Drawing.Point(41, 35);
            this.ProjectListView.Name = "ProjectListView";
            this.ProjectListView.Size = new System.Drawing.Size(120, 277);
            this.ProjectListView.TabIndex = 0;
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Location = new System.Drawing.Point(41, 319);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(120, 30);
            this.createProjectBtn.TabIndex = 1;
            this.createProjectBtn.Text = "Create Project";
            this.createProjectBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProjectBtn);
            this.panel1.Location = new System.Drawing.Point(257, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 277);
            this.panel1.TabIndex = 2;
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(144, 244);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(120, 30);
            this.addProjectBtn.TabIndex = 2;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            // 
            // AddProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(this.ProjectListView);
            this.Name = "AddProjectControl";
            this.Size = new System.Drawing.Size(572, 395);
            this.Load += new System.EventHandler(this.AddProjectControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectListView;
        private System.Windows.Forms.Button createProjectBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addProjectBtn;
    }
}
