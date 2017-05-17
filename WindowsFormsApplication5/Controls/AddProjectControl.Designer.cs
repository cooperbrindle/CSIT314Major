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
            this.ProjManList = new System.Windows.Forms.ComboBox();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.estEndLbl = new System.Windows.Forms.Label();
            this.ProjManLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectListView
            // 
            this.ProjectListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ProjectListView.FormattingEnabled = true;
            this.ProjectListView.ItemHeight = 17;
            this.ProjectListView.Location = new System.Drawing.Point(22, 34);
            this.ProjectListView.Name = "ProjectListView";
            this.ProjectListView.Size = new System.Drawing.Size(120, 242);
            this.ProjectListView.TabIndex = 0;
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Location = new System.Drawing.Point(22, 283);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(120, 30);
            this.createProjectBtn.TabIndex = 1;
            this.createProjectBtn.Text = "Create New Project";
            this.createProjectBtn.UseVisualStyleBackColor = true;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
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
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 310);
            this.panel1.TabIndex = 2;
            // 
            // ProjManList
            // 
            this.ProjManList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ProjManList.FormattingEnabled = true;
            this.ProjManList.Location = new System.Drawing.Point(99, 200);
            this.ProjManList.Name = "ProjManList";
            this.ProjManList.Size = new System.Drawing.Size(121, 25);
            this.ProjManList.TabIndex = 15;
            // 
            // datePickEnd
            // 
            this.datePickEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.datePickEnd.Location = new System.Drawing.Point(99, 132);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(234, 23);
            this.datePickEnd.TabIndex = 14;
            // 
            // datePickStart
            // 
            this.datePickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.datePickStart.Location = new System.Drawing.Point(99, 68);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(234, 23);
            this.datePickStart.TabIndex = 13;
            // 
            // estEndLbl
            // 
            this.estEndLbl.AutoSize = true;
            this.estEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.estEndLbl.Location = new System.Drawing.Point(13, 106);
            this.estEndLbl.Name = "estEndLbl";
            this.estEndLbl.Size = new System.Drawing.Size(95, 17);
            this.estEndLbl.TabIndex = 12;
            this.estEndLbl.Text = "Est. End Date";
            // 
            // ProjManLbl
            // 
            this.ProjManLbl.AutoSize = true;
            this.ProjManLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ProjManLbl.Location = new System.Drawing.Point(13, 174);
            this.ProjManLbl.Name = "ProjManLbl";
            this.ProjManLbl.Size = new System.Drawing.Size(112, 17);
            this.ProjManLbl.TabIndex = 11;
            this.ProjManLbl.Text = "Project Manager";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.startDateLbl.Location = new System.Drawing.Point(13, 43);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(72, 17);
            this.startDateLbl.TabIndex = 8;
            this.startDateLbl.Text = "Start Date";
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(179, 277);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(120, 30);
            this.addProjectBtn.TabIndex = 2;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(19, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Projects";
            // 
            // AddProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(this.ProjectListView);
            this.Name = "AddProjectControl";
            this.Size = new System.Drawing.Size(562, 316);
            this.Load += new System.EventHandler(this.AddProjectControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}
