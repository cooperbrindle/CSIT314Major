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
        public String policyProjectID {get;set;}

        public TaskControl()
        {
            InitializeComponent();
        }

        public TaskControl(String id) : this()
        {
            policyProjectID = id;
            int total = 0;

            Database db = new Database();
            DataTable t = db.query("SELECT weight FROM Task WHERE policyProjectID = '" + policyProjectID + "'");
            foreach(DataRow r in t.Rows)
            {
                total += Convert.ToInt32(r[0].ToString());

            }
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100 - total;
            wtInput.Minimum = 1;
            wtInput.Maximum = 100 - total;

        }

        private void wtInput_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(wtInput.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wtInput.Value = trackBar1.Value;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                Database db = new Database();
                int id = Convert.ToInt32(db.query("SELECT COUNT(*) FROM Task").Rows[0][0].ToString()) + 1;
                String qry = "INSERT INTO Task VALUES (" + id + ", '" + taskTxt.Text + "', " + cstInput.Value + ", " + wrkrInput.Value + ", ";
                qry += timeInput.Value + ", " + ecoInput.Value + ", " + happyInput.Value + ", " + wtInput.Value + ", '"+policyProjectID+"')";
                db.query(qry);
                this.Dispose();
            }
        }

        private bool checkInputs()
        {
            return taskTxt.Text != String.Empty && wrkrInput.Value > 0 && 
                timeInput.Value > 0 && wtInput.Value > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
