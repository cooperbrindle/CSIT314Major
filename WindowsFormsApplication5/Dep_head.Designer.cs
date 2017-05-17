namespace WindowsFormsApplication5
{
    partial class Dep_head
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectDataSet = new WindowsFormsApplication5.ProjectDataSet();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new WindowsFormsApplication5.ProjectDataSetTableAdapters.ProjectTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dep_main = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.Dep_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea17.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea17);
            this.chart1.DataSource = this.projectBindingSource;
            legend17.Name = "Legend1";
            legend17.Title = "Project Names";
            this.chart1.Legends.Add(legend17);
            this.chart1.Location = new System.Drawing.Point(287, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.chart1.Name = "chart1";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series17.IsValueShownAsLabel = true;
            series17.Legend = "Legend1";
            series17.Name = "Budget";
            series17.XValueMember = "name";
            series17.YValueMembers = "budget";
            this.chart1.Series.Add(series17);
            this.chart1.Size = new System.Drawing.Size(272, 282);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart2
            // 
            chartArea18.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart2.Legends.Add(legend18);
            this.chart2.Location = new System.Drawing.Point(3, 20);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.chart2.Name = "chart2";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chart2.Series.Add(series18);
            this.chart2.Size = new System.Drawing.Size(272, 282);
            this.chart2.TabIndex = 2;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 25, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 377);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // Dep_main
            // 
            this.Dep_main.Controls.Add(this.chart1);
            this.Dep_main.Controls.Add(this.chart2);
            this.Dep_main.Location = new System.Drawing.Point(236, 85);
            this.Dep_main.Name = "Dep_main";
            this.Dep_main.Size = new System.Drawing.Size(562, 316);
            this.Dep_main.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 6, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "New Project";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 92);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 0, 6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 159);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 0, 6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "Project Summaries";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 226);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 0, 6, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 42);
            this.button5.TabIndex = 3;
            this.button5.Text = "Budget Overview";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 293);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 0, 6, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 42);
            this.button6.TabIndex = 4;
            this.button6.Text = "Reports";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Dep_head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(810, 424);
            this.Controls.Add(this.Dep_main);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Dep_head";
            this.Load += new System.EventHandler(this.Dep_head_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.Dep_main, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Dep_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Dep_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
