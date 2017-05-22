using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class EmployeeDash : @base
    {
        int employeeID;
        public EmployeeDash()
        {
            InitializeComponent();
            Database db = new Database();
            DataTable table = db.query("SELECT * FROM Policy");
            foreach(DataRow r in table.Rows)
            {
                Policy p = new Policy();
                p.policyID = Convert.ToInt32(r[2].ToString());
                p.name = r[0].ToString();
                p.statement = r[1].ToString();
                policyBox.Items.Add(p);
            }
        }

        public EmployeeDash(int id) : this() { employeeID = id; }

        private void main2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWdataDataSet.Task' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet.PolicyProject' table. You can move, or remove it, as needed.
            this.policyProjectTableAdapter.Fill(this.projectDataSet.PolicyProject);
            // TODO: This line of code loads data into the 'projectDataSet.Project' table. You can move, or remove it, as needed.
            //this.projectTableAdapter.Fill(this.projectDataSet.Project);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (policyBox.SelectedItem != null)
            {
                AddProjectControl projectControl = new AddProjectControl(policyBox.SelectedItem as Policy);
                projectControl.Location = new Point() { X = 236, Y = 80 };
                mainPanel.Hide();
                projectControl.Disposed += new EventHandler(PanelDisposed);
                this.Controls.Add(projectControl);
                projectControl.Show();
            }
            
        }
        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(policyBox.SelectedIndex >= 0)
            {
                Policy p = policyBox.SelectedItem as Policy;
                Controls.ProjectReport pr = new Controls.ProjectReport(p.policyID);
                pr.Location = mainPanel.Location;
                pr.Size = mainPanel.Size;
                pr.Disposed += new EventHandler(PanelDisposed);
                this.Controls.Add(pr);
                mainPanel.Hide();
                pr.Show();
            }
            
        }
    }
}
