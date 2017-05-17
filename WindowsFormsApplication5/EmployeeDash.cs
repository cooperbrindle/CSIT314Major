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
    public partial class EmployeeDash : @base
    {
        public EmployeeDash()
        {
            InitializeComponent();
        }

        private void main2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProjectControl projectControl = new AddProjectControl();
            projectControl.Location = new Point() { X = 175, Y = 35 };
            this.Controls.Add(projectControl);
        }
    }
}
