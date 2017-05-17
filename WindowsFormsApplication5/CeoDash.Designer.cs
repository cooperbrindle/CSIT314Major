﻿namespace WindowsFormsApplication5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.policyProjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyProject = new WindowsFormsApplication5.PolicyProject();
            this.label1 = new System.Windows.Forms.Label();
            this.policyProjectTableAdapter = new WindowsFormsApplication5.PolicyProjectTableAdapters.PolicyProjectTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.policyProjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectTableAdapter1 = new WindowsFormsApplication5.ProjectDataSetTableAdapters.PolicyProjectTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProjectTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProject)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 25, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 377);
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
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.DataSource = this.policyProjectBindingSource2;
            legend5.Name = "Legend1";
            legend5.Title = "Policy Name";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(279, 13);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Policy Budget";
            series5.XValueMember = "policyProjectID";
            series5.YValueMembers = "finalCost";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(272, 282);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DAD PUT USERNAMES HERE";
            // 
            // policyProjectTableAdapter
            // 
            this.policyProjectTableAdapter.ClearBeforeFill = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyProjectBindingSource2
            // 
            this.policyProjectBindingSource2.DataMember = "PolicyProject";
            this.policyProjectBindingSource2.DataSource = this.projectDataSet;
            // 
            // policyProjectTableAdapter1
            // 
            this.policyProjectTableAdapter1.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.DataSource = this.projectBindingSource;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(1, 13);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.XValueMember = "projectID";
            series6.YValueMembers = "budget";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(272, 282);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
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
            // CeoDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 424);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.Name = "CeoDash";
            this.Text = "CEO";
            this.Load += new System.EventHandler(this.CEO_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProject)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
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
    }
}