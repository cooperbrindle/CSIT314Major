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
    public partial class PolicyControl : Controls.baseControl
    {
        public PolicyControl()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(polNameTxt.Text != String.Empty && polDescTxt.Text != String.Empty)
            {
                Database db = new Database();
                DataTable table = db.query("SELECT Count(*) FROM Policy");

                int id = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;
                table = db.query("INSERT INTO Policy VALUES ('" + polNameTxt.Text + "', '" + polDescTxt.Text + "', " + Convert.ToString(id) + ")");
                this.Dispose();
            }
        }

        private void DescrLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
