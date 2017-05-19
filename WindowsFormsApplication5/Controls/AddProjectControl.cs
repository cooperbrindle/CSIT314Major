using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class AddProjectControl : UserControl
    {
        Database db;
        DataTable table;
        Policy policy;

        public AddProjectControl()
        {
            InitializeComponent();
            db = new Database();
            panel1.Hide();
            ProjectListView.SelectedIndexChanged += new EventHandler(itemSelected);
        }

        public AddProjectControl(Policy p) : this()
        {
            policy = p;
        }

        private void AddProjectControl_Load(object sender, EventArgs e)
        {
            load();            
        }

        public void load()
        {
            String queryStr = "SELECT projectID, name FROM Project";
            table = db.query(queryStr);

            ProjectListView.Items.Clear();
            ProjManList.Items.Clear();

            LinkedList<Project> projectList = new LinkedList<Project>();
            if (table.Rows.Count >= 1)
            {
                Project p;
                foreach (DataRow r in table.Rows)
                {
                    p = new Project();
                    p.projectID = Convert.ToInt32(r[0].ToString());
                    p.name = r[1].ToString();
                    projectList.AddLast(p);
                    ProjectListView.Items.Add(p);
                }
            }

            queryStr = "SELECT employeeID, name FROM Employee WHERE privilege = 3";
            table = db.query(queryStr);

            if (table.Rows.Count >= 1)
            {
                Employee man;
                foreach (DataRow r in table.Rows)
                {
                    man = new Employee();
                    man.employeeID = r[0].ToString();
                    man.name = r[1].ToString();
                    ProjManList.Items.Add(man);
                }
            }
        }

        public void itemSelected(Object sender, EventArgs e)
        {
            if (ProjectListView.SelectedIndex >= 0)
                panel1.Show();
            else panel1.Hide();
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            CreateProjectControl projControl = new CreateProjectControl();
            //projControl.Location = this.Location;
            //projControl.Size = this.Size;
            projControl.Disposed += new EventHandler(createControlDisposed);
            foreach (Control c in this.Controls)
                c.Hide();
            this.Controls.Add(projControl);
            projControl.Show();
            projControl.BringToFront();
            //this.Hide();
        }

        public void createControlDisposed(Object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                c.Show();
            panel1.Hide();
            load();
            //this.Show();
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            
            String qry = "SELECT COUNT(*) FROM PolicyProject";
            int id = db.query(qry).Rows.Count + 1;
            Employee pman = ProjManList.SelectedItem as Employee;
            Project proj = ProjectListView.SelectedItem as Project;
            qry = "INSERT INTO PolicyProject VALUES(" + id + ", '" + datePickStart.Value.ToShortDateString() + "', ";
            qry += "'" + datePickEnd.Value.ToShortDateString() + "', null, 0, 0, null, ";
            qry += "'" + pman.employeeID + "', " + policy.policyID + ", " + proj.projectID + ", 0)";
            db.query(qry);
            this.Dispose();
        }
    }


}
