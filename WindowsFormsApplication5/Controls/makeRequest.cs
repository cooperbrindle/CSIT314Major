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
    public partial class makeRequest : UserControl
    {

        public PolicyProjectModel proj;

        public makeRequest()
        {
            InitializeComponent();
        }

        public makeRequest(PolicyProjectModel p) : this()
        {
            proj = p;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(amountBox.Value > 0)
            {
                Database db = new Database();
                db.query("UPDATE PolicyProject SET finalCost = finalCost + (SELECT budget FROM Project WHERE projectID = " + proj.projectID + ") + " + amountBox.Value + " WHERE policyProjectID = "+ proj.policyProjectID);
                this.Dispose();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
