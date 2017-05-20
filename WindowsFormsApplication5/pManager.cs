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
        }

        public void WriteTextBoxTextToLabel(string txt)
        {
            label2.Text = txt;
        }
        private void pManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Process' table. You can move, or remove it, as needed.
           // this.processTableAdapter.Fill(this.projectDataSet.Process);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.TaskControl task = new Controls.TaskControl();
            task.Location = new Point { X = 236, Y = 80 };
            mainPanel.Hide();
            task.Disposed += new EventHandler(PanelDisposed);
            this.Controls.Add(task);
            task.Show();
        }
        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }
    }
}
