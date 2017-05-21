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
    public partial class CreateProjectControl : UserControl
    {
        public CreateProjectControl()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String qry = "SELECT COUNT(*) FROM Project";
                Database db = new Database();
                DataTable table = db.query(qry);
                int id = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;
                qry = "INSERT INTO Project VALUES(" + id + ", '" + nameTxt.Text + "', '" + ObjectiveTxt.Text + "', ";
                qry += Convert.ToString(budgetInput.Value) + ", '" + stakeholderTxt.Text + "', '" + deptTxt.Text + "')";
                db.query(qry);
                this.Dispose();
            }
        }

        private bool checkInputs()
        {
            return (nameTxt.Text != String.Empty && ObjectiveTxt.Text != String.Empty &&
                stakeholderTxt.Text != String.Empty && deptTxt.Text != String.Empty);
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
