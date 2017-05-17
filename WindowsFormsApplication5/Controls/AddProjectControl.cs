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
        public AddProjectControl()
        {
            InitializeComponent();
            db = new Database();
            panel1.Hide();
            ProjectListView.SelectedIndexChanged += new EventHandler(itemSelected);
        }

        private void AddProjectControl_Load(object sender, EventArgs e)
        {
            String queryStr = "SELECT projectID, name FROM Project";
            table = db.query(queryStr);

            LinkedList<Project> projectList = new LinkedList<Project>();
            if(table.Rows.Count >= 1)
            {
                Project p;
                foreach(DataRow r in table.Rows)
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

            if(table.Rows.Count >= 1)
            {
                Employee man;
                foreach(DataRow r in table.Rows)
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
    }


}
