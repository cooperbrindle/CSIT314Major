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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent(); 
        }

        private void CreatePolicy_Click(object sender, EventArgs e)
        {
            PolicyForm policyForm = new PolicyForm();
            policyForm.Location = new Point { X = 165, Y = 35 };
            mainPanel.Hide();
            policyForm.Disposed += new EventHandler(PanelDisposed);
            this.Controls.Add(policyForm);
            policyForm.Show();

        }

        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }
    }
}
