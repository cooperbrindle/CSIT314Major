using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Dep_head : @base
	{
        public Dep_head()
        {
            InitializeComponent();
        }

        private void Dep_head_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.projectDataSet.Project);

        }
    }
}
