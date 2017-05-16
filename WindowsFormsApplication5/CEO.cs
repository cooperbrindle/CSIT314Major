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
    public partial class CEO : @base
    {
        public CEO()
        {
            InitializeComponent();
        }

        private void CEO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policyProject._PolicyProject' table. You can move, or remove it, as needed.
            this.policyProjectTableAdapter.Fill(this.policyProject._PolicyProject);

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
