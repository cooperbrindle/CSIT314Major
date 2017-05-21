using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Controls
{
    public partial class ProjectReport : UserControl
    {
        public PolicyProjectModel proj;
        public int policyID;
        private Database db;

        public ProjectReport()
        {
            InitializeComponent();

        }

        public ProjectReport(int id) : this()
        {
            policyID = id;
            db = new Database();
            String qry = "SELECT name FROM Project WHERE projectID IN ";
            qry += "(SELECT projectID FROM PolicyProject WHERE policyID = " + policyID + ")";
            DataTable t = db.query(qry);
            foreach(DataRow r in t.Rows)
            {
                ProjectComboBox.Items.Add(r[0].ToString());
            }
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            String qry = "SELECT * FROM PolicyProject WHERE policyID = "+policyID+" AND projectID = ";
            qry += "(SELECT projectID FROM Project WHERE name = '" + ProjectComboBox.SelectedItem.ToString() + "')";
            DataTable t = db.query(qry);
                
            DataRow r = t.Rows[0];
            startDateBox.Text = r[1].ToString();
            estDateBox.Text = r[2].ToString();
            complDateBox.Text = r[3].ToString();
            costBox.Text = r[4].ToString();
            progressBar1.Value = Convert.ToInt32(r[5].ToString());
            pManBox.Text = r[7].ToString();
            weightBox.Text = r[10].ToString();

            String projID = r[9].ToString();

            t = db.query("SELECT name, objective, budget FROM Project WHERE projectID = " + projID);
            r = t.Rows[0];
            projName.Text = r[0].ToString();
            descBox.Text = r[1].ToString();
            budgetBox.Text = r[2].ToString();

            t = db.query("SELECT policyName FROM Policy WHERE policyID = " + policyID);
            polName.Text = t.Rows[0][0].ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
