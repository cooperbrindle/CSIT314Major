﻿namespace WindowsFormsApplication5
{
    partial class pManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nEWdataDataSet = new WindowsFormsApplication5.NEWdataDataSet();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProcessTableAdapter();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.taskTableAdapter = new WindowsFormsApplication5.NEWdataDataSetTableAdapters.TaskTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 374);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "Make Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 150);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 75);
            this.button3.TabIndex = 10;
            this.button3.Text = "Task History";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 225);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 75);
            this.button4.TabIndex = 11;
            this.button4.Text = "Budget Overview";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 300);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 75);
            this.button5.TabIndex = 12;
            this.button5.Text = "View Report";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.chart2);
            this.mainPanel.Controls.Add(this.chart1);
            this.mainPanel.Location = new System.Drawing.Point(236, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(562, 316);
            this.mainPanel.TabIndex = 7;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(1, 13);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(272, 282);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Task Name";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(279, 13);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(272, 282);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataMember = "Task";
            this.taskBindingSource1.DataSource = this.nEWdataDataSet;
            // 
            // nEWdataDataSet
            // 
            this.nEWdataDataSet.DataSetName = "NEWdataDataSet";
            this.nEWdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.nEWdataDataSet;
            // 
            // processBindingSource1
            // 
            this.processBindingSource1.DataMember = "Process";
            this.processBindingSource1.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataMember = "Process";
            this.processBindingSource.DataSource = this.projectDataSet;
            // 
            // processTableAdapter
            // 
            this.processTableAdapter.ClearBeforeFill = true;
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(237, 52);
            this.projectBox.Margin = new System.Windows.Forms.Padding(1);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(166, 21);
            this.projectBox.TabIndex = 8;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // pManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 427);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "pManager";
            this.Load += new System.EventHandler(this.pManager_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.projectBox, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource processBindingSource;
        private ProjectDataSetTableAdapters.ProcessTableAdapter processTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.BindingSource processBindingSource1;
        private NEWdataDataSet nEWdataDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private NEWdataDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource taskBindingSource1;
    }
}