﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication5
{
    public partial class pManager : @base
    {
        int employeeID;
        public pManager()
        {
            InitializeComponent();
        }

        public pManager(int id) : this() {
            employeeID = id;
            Database db = new Database();
            DataTable table = db.query("SELECT * FROM PolicyProject WHERE projectManagerID = '" + employeeID + "'");
            //DataTable table = db.query("SELECT * FROM PolicyProject");
            foreach (DataRow r in table.Rows)
            {
                PolicyProjectModel p = new PolicyProjectModel
                {
                    policyProjectID = r[0].ToString(),
                    startDate = r[1].ToString(),
                    estEndDate = r[2].ToString(),
                    endDate = r[3].ToString(),
                    finalCost = Convert.ToInt32(r[4].ToString()),
                    progress = Convert.ToInt32(r[5].ToString()),
                    departmentHeadID = r[6].ToString(),
                    projectManagerID = r[7].ToString(),
                    policyID = Convert.ToInt32(r[8].ToString()),
                    projectID = Convert.ToInt32(r[9].ToString()),
                    weighting = Convert.ToInt32(r[10].ToString())
                };
                projectBox.Items.Add(p);
            }

            table = db.query("SELECT policyID, finalCost FROM policyProject WHERE projectManagerID = " +employeeID);
            chart1.Series.Add("test");
            chart1.Series["test"].XValueMember = table.Columns[0].ColumnName;
            chart1.Series["test"].YValueMembers = table.Columns[1].ColumnName;
            chart1.Series["test"].ChartType = SeriesChartType.Pie;
            chart1.Series["test"].LegendText = "PolicyID";
            chart1.DataSource = table;
            chart1.DataBind();

            table = db.query("SELECT policyProjectID, progress FROM policyProject WHERE projectManagerID = "+employeeID);
            chart2.Series.Add("test");
            chart2.Series["test"].XValueMember = table.Columns[0].ColumnName;
            chart2.Series["test"].YValueMembers = table.Columns[1].ColumnName;
            chart2.Series["test"].ChartType = SeriesChartType.Column;
            chart2.Series["test"].LegendText = "PolicyID";
            chart2.Series["test"].IsValueShownAsLabel = true;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.DataSource = table;
            chart2.DataBind();
        }
        
        private void pManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWdataDataSet.Task' table. You can move, or remove it, as needed.
            //this.taskTableAdapter.Fill(this.nEWdataDataSet.Task);
            // TODO: This line of code loads data into the 'projectDataSet.Process' table. You can move, or remove it, as needed.
            //this.processTableAdapter.Fill(this.projectDataSet.Process);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(projectBox.SelectedIndex >= 0)
            {
                PolicyProjectModel p = projectBox.SelectedItem as PolicyProjectModel;
                Controls.TaskControl task = new Controls.TaskControl(p.policyProjectID);
                task.Location = mainPanel.Location;
                mainPanel.Hide();
                task.Disposed += new EventHandler(PanelDisposed);
                this.Controls.Add(task);
                task.Show();
            }
            
        }
        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (projectBox.SelectedIndex >= 0)
            {
                Controls.makeRequest req = new Controls.makeRequest(projectBox.SelectedItem as PolicyProjectModel);
                req.Location = mainPanel.Location;
                req.Size = mainPanel.Size;
                req.Disposed += new EventHandler(PanelDisposed);
                this.Controls.Add(req);
                mainPanel.Hide();
                req.Show();
            }
        }
    }
}
