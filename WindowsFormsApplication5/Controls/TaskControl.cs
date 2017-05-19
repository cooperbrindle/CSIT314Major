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
    public partial class TaskControl : UserControl
    {
        public TaskControl()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //if (checkInputs())
            //{
                String qry = "SELECT COUNT(*) FROM Process";
                Database db = new Database();
                DataTable table = db.query(qry);
                int id = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;
                qry = "INSERT INTO Process VALUES(" + id + ", '" + taskTxt.Text + "', " + Convert.ToString(timeInput.Value) + ", ";
                qry += Convert.ToString(cstInput.Value) + ", " + Convert.ToString(wrkrInput.Value) + ", ";
                qry += Convert.ToString(ecoInput.Value) + ", " + Convert.ToString(happyInput.Value) + ", ";
                qry += Convert.ToString(wtInput.Value) + ")";
                db.query(qry);
                this.Dispose();
            //}
        }
        /*
        private bool checkInputs()
        {
            return (taskTxt.Text != String.Empty && timeInput.Text != String.Empty &&
                stakeholderTxt.Text != String.Empty && deptTxt.Text != String.Empty);

        }*/
    }
}
