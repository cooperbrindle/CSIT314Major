﻿using System;
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
        {

        }
    }
}
