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
            this.startDateLbl = new System.Windows.Forms.Label();
            this.ProjManLbl = new System.Windows.Forms.Label();
            this.estEndLbl = new System.Windows.Forms.Label();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.ProjManList = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.ProjManList);
            this.panel1.Controls.Add(this.datePickEnd);
            this.panel1.Controls.Add(this.datePickStart);
            this.panel1.Controls.Add(this.estEndLbl);
            this.panel1.Controls.Add(this.ProjManLbl);
            this.panel1.Controls.Add(this.startDateLbl);
            this.panel1.Controls.Add(this.addProjectBtn);
            this.panel1.Location = new System.Drawing.Point(257, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 314);
            this.panel1.TabIndex = 2;
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(179, 281);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(120, 30);
            this.addProjectBtn.TabIndex = 2;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(13, 51);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(55, 13);
            this.startDateLbl.TabIndex = 8;
            this.startDateLbl.Text = "Start Date";
            // 
            // ProjManLbl
            // 
            this.ProjManLbl.AutoSize = true;
            this.ProjManLbl.Location = new System.Drawing.Point(13, 138);
            this.ProjManLbl.Name = "ProjManLbl";
            this.ProjManLbl.Size = new System.Drawing.Size(85, 13);
            this.ProjManLbl.TabIndex = 11;
            this.ProjManLbl.Text = "Project Manager";
            // 
            // estEndLbl
            // 
            this.estEndLbl.AutoSize = true;
            this.estEndLbl.Location = new System.Drawing.Point(13, 93);
            this.estEndLbl.Name = "estEndLbl";
            this.estEndLbl.Size = new System.Drawing.Size(73, 13);
            this.estEndLbl.TabIndex = 12;
            this.estEndLbl.Text = "Est. End Date";
            // 
            // datePickStart
            // 
            this.datePickStart.Location = new System.Drawing.Point(99, 44);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(200, 20);
            this.datePickStart.TabIndex = 13;
            // 
            // datePickEnd
            // 
            this.datePickEnd.Location = new System.Drawing.Point(99, 86);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(200, 20);
            this.datePickEnd.TabIndex = 14;
            // 
            // ProjManList
            // 
            this.ProjManList.FormattingEnabled = true;
            this.ProjManList.Location = new System.Drawing.Point(99, 129);
            this.ProjManList.Name = "ProjManList";
            this.ProjManList.Size = new System.Drawing.Size(121, 21);
            this.ProjManList.TabIndex = 15;
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectListView;
        private System.Windows.Forms.Button createProjectBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.ComboBox ProjManList;
        private System.Windows.Forms.DateTimePicker datePickEnd;
        private System.Windows.Forms.DateTimePicker datePickStart;
        private System.Windows.Forms.Label estEndLbl;
        private System.Windows.Forms.Label ProjManLbl;
        private System.Windows.Forms.Label startDateLbl;
    }
}
