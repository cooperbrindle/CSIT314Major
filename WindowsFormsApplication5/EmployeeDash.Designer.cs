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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.policyProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProjectTableAdapter();
            this.policyProjectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.PolicyProjectTableAdapter();
            this.policyBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(16, 60);
            this.addProjectBtn.Margin = new System.Windows.Forms.Padding(0, 0, 16, 60);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(496, 100);
            this.addProjectBtn.TabIndex = 6;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.addProjectBtn);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16, 60, 27, 24);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 899);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 16, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(496, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 16, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(496, 100);
            this.button2.TabIndex = 8;
            this.button2.Text = "Project Summaries";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 540);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 16, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(496, 100);
            this.button3.TabIndex = 9;
            this.button3.Text = "Budget Overview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 700);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 16, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(496, 100);
            this.button4.TabIndex = 10;
            this.button4.Text = "View Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.chart2);
            this.mainPanel.Controls.Add(this.chart1);
            this.mainPanel.Location = new System.Drawing.Point(629, 191);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1499, 754);
            this.mainPanel.TabIndex = 8;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 31);
            this.chart2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(725, 672);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.policyProjectBindingSource;
            legend2.Name = "Legend1";
            legend2.Title = "Project Name";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(744, 31);
            this.chart1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Policy Budget";
            series2.XValueMember = "policyProjectID";
            series2.YValueMembers = "finalCost";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(725, 672);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // policyProjectBindingSource
            // 
            this.policyProjectBindingSource.DataMember = "PolicyProject";
            this.policyProjectBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.projectDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // policyProjectTableAdapter
            // 
            this.policyProjectTableAdapter.ClearBeforeFill = true;
            // 
            // policyBox
            // 
            this.policyBox.FormattingEnabled = true;
            this.policyBox.Location = new System.Drawing.Point(52, 64);
            this.policyBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.policyBox.Name = "policyBox";
            this.policyBox.Size = new System.Drawing.Size(436, 39);
            this.policyBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // EmployeeDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2157, 1018);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.policyBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeDash";
            this.Text = "nfprivilege";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main2_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.policyBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource policyProjectBindingSource;
        private ProjectDataSetTableAdapters.PolicyProjectTableAdapter policyProjectTableAdapter;
        private System.Windows.Forms.ComboBox policyBox;
        private System.Windows.Forms.Label label2;
    }
}