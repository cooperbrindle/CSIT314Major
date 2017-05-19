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
    public partial class pManager : @base
    {
        public pManager()
        {
            InitializeComponent();
        }

        private void pManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Process' table. You can move, or remove it, as needed.
            this.processTableAdapter.Fill(this.projectDataSet.Process);

        }
        private void button1_Click(object sender, EventArgs e)
        { }/*
        private void button1_Click(object sender, EventArgs e)
        {
            Controls.TaskControl task = new Controls.TaskControl();
            task.Location = new Point { X = 236, Y = 80 };
            mainPanel.Hide();
            task.Disposed += new EventHandler(PanelDisposed);
            this.Controls.Add(task);
            task.Show();
        }
        public void PanelDisposed(object sender, EventArgs e)
        {
            mainPanel.Show();
        }*/
    }
}
