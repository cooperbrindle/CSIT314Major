﻿namespace WindowsFormsApplication5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProjectTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.policyProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyProjectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.PolicyProjectTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(6, 25);
            this.addProjectBtn.Margin = new System.Windows.Forms.Padding(0, 0, 6, 25);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(186, 42);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 25, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 377);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 6, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Project Summaries";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 226);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Budget Overview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 293);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "View Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(236, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 316);
            this.panel1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataSource = this.policyProjectBindingSource;
            legend3.Name = "Legend1";
            legend3.Title = "Project Name";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(279, 13);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Policy Budget";
            series3.XValueMember = "policyProjectID";
            series3.YValueMembers = "finalCost";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(272, 282);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
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
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(1, 13);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(272, 282);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // policyProjectBindingSource
            // 
            this.policyProjectBindingSource.DataMember = "PolicyProject";
            this.policyProjectBindingSource.DataSource = this.projectDataSet;
            // 
            // policyProjectTableAdapter
            // 
            this.policyProjectTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 427);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "EmployeeDash";
            this.Text = "nfprivilege";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main2_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource policyProjectBindingSource;
        private ProjectDataSetTableAdapters.PolicyProjectTableAdapter policyProjectTableAdapter;
    }
}