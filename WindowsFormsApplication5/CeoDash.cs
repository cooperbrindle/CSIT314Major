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
        }

        public CeoDash(int id) : this() { employeeID = id; }

        private void CEO_Load(object sender, EventArgs e)
        {
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
