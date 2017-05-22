namespace WindowsFormsApplication5
{
    partial class CeoDash
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new WindowsFormsApplication5.DataDataSet();
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.policyProjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyProject = new WindowsFormsApplication5.PolicyProject();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyBox = new System.Windows.Forms.ComboBox();
            this.policyProjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectTableAdapter = new WindowsFormsApplication5.PolicyProjectTableAdapters.PolicyProjectTableAdapter();
            this.policyProjectTableAdapter1 = new WindowsFormsApplication5.ProjectDataSetTableAdapters.PolicyProjectTableAdapter();
            this.projectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProjectTableAdapter();
            this.policyProjectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectTableAdapter2 = new WindowsFormsApplication5.DataDataSetTableAdapters.PolicyProjectTableAdapter();
            this.policyProjectBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProject)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 25, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 374);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 25, 6, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Define Policy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 25, 6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "View Project Progress";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 234);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 25, 6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "View Project Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Policy Name";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(281, 13);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(272, 282);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "Project";
            this.projectBindingSource1.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyProjectBindingSource1
            // 
            this.policyProjectBindingSource1.DataMember = "PolicyProject";
            this.policyProjectBindingSource1.DataSource = this.policyProjectBindingSource;
            // 
            // policyProjectBindingSource
            // 
            this.policyProjectBindingSource.DataSource = this.policyProject;
            this.policyProjectBindingSource.Position = 0;
            // 
            // policyProject
            // 
            this.policyProject.DataSetName = "PolicyProject";
            this.policyProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.chart1);
            this.mainPanel.Controls.Add(this.chart2);
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.mainPanel.Location = new System.Drawing.Point(236, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(0, 10, 6, 0);
            this.mainPanel.Size = new System.Drawing.Size(562, 316);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.WrapContents = false;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 13);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(272, 282);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.projectDataSet;
            // 
            // policyBox
            // 
            this.policyBox.FormattingEnabled = true;
            this.policyBox.Location = new System.Drawing.Point(236, 52);
            this.policyBox.Name = "policyBox";
            this.policyBox.Size = new System.Drawing.Size(166, 21);
            this.policyBox.TabIndex = 10;
            // 
            // policyProjectBindingSource2
            // 
            this.policyProjectBindingSource2.DataMember = "PolicyProject";
            this.policyProjectBindingSource2.DataSource = this.projectDataSet;
            // 
            // policyProjectTableAdapter
            // 
            this.policyProjectTableAdapter.ClearBeforeFill = true;
            // 
            // policyProjectTableAdapter1
            // 
            this.policyProjectTableAdapter1.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // policyProjectBindingSource3
            // 
            this.policyProjectBindingSource3.DataMember = "PolicyProject";
            this.policyProjectBindingSource3.DataSource = this.dataDataSet;
            // 
            // policyProjectTableAdapter2
            // 
            this.policyProjectTableAdapter2.ClearBeforeFill = true;
            // 
            // policyProjectBindingSource4
            // 
            this.policyProjectBindingSource4.DataMember = "PolicyProject";
            this.policyProjectBindingSource4.DataSource = this.dataDataSet;
            // 
            // policyProjectBindingSource5
            // 
            this.policyProjectBindingSource5.DataMember = "PolicyProject";
            this.policyProjectBindingSource5.DataSource = this.dataDataSet;
            // 
            // dataDataSetBindingSource1
            // 
            this.dataDataSetBindingSource1.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource1.Position = 0;
            // 
            // policyProjectBindingSource6
            // 
            this.policyProjectBindingSource6.DataMember = "PolicyProject";
            this.policyProjectBindingSource6.DataSource = this.dataDataSetBindingSource1;
            // 
            // CeoDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 424);
            this.Controls.Add(this.policyBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Name = "CeoDash";
            this.Text = "CEO";
            this.Load += new System.EventHandler(this.CEO_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.policyBox, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProject)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource policyProjectBindingSource;
        private PolicyProject policyProject;
        private System.Windows.Forms.BindingSource policyProjectBindingSource1;
        private PolicyProjectTableAdapters.PolicyProjectTableAdapter policyProjectTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource policyProjectBindingSource2;
        private ProjectDataSetTableAdapters.PolicyProjectTableAdapter policyProjectTableAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.ComboBox policyBox;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource policyProjectBindingSource3;
        private DataDataSetTableAdapters.PolicyProjectTableAdapter policyProjectTableAdapter2;
        private System.Windows.Forms.BindingSource policyProjectBindingSource4;
        private System.Windows.Forms.BindingSource policyProjectBindingSource5;
        private System.Windows.Forms.BindingSource policyProjectBindingSource6;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource1;
    }
}