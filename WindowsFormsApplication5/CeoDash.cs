using System;
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
    public partial class CeoDash : @base
    {
        int employeeID;
        public CeoDash()
        {
            InitializeComponent();
            Database db = new Database();
            DataTable table = db.query("SELECT * FROM Policy");
            foreach (DataRow r in table.Rows)
            {
                Policy p = new Policy();
                p.policyID = Convert.ToInt32(r[2].ToString());
                p.name = r[0].ToString();
                p.statement = r[1].ToString();
                policyBox.Items.Add(p);
            }

            table = db.query("SELECT policyID, SUM(finalCost) FROM policyProject GROUP BY policyID");
            chart1.Series.Add("test");
            chart1.Series["test"].XValueMember = table.Columns[0].ColumnName;
            chart1.Series["test"].YValueMembers = table.Columns[1].ColumnName;
            chart1.Series["test"].ChartType = SeriesChartType.Pie;
            chart1.Series["test"].LegendText = "PolicyID";
            chart1.DataSource = table;
            chart1.DataBind();

            table = db.query("SELECT policyID, SUM(progress)/COUNT(policyProjectID) FROM policyProject GROUP BY policyID");
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

        public CeoDash(int id) : this() { employeeID = id; }

        private void CEO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.PolicyProject' table. You can move, or remove it, as needed.
            this.policyProjectTableAdapter2.Fill(this.dataDataSet.PolicyProject);
            // TODO: This line of code loads data into the 'projectDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.projectDataSet.Project);
            // TODO: This line of code loads data into the 'projectDataSet.PolicyProject' table. You can move, or remove it, as needed.
          //  this.policyProjectTableAdapter1.Fill(this.projectDataSet.PolicyProject);
            // TODO: This line of code loads data into the 'policyProject._PolicyProject' table. You can move, or remove it, as needed.
           // this.policyProjectTableAdapter.Fill(this.policyProject._PolicyProject);

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PolicyControl policyForm = new PolicyControl();
            policyForm.Location = new Point { X = 236, Y = 80 };
            mainPanel.Hide();
            policyForm.Disposed += new EventHandler(PanelDisposed);
            this.Controls.Add(policyForm);
            policyForm.Show();
        }

        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(policyBox.SelectedIndex >= 0)
            {

            }
        }
    }
}
