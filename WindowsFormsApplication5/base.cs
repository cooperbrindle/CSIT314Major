using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class @base : Form
    {
        public @base()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(start);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
            
        }

        private void start()
        {
            Application.Run(new LoginForm());
        }

        public void writeName(String n)
        {
            nameLbl.Text = "Welcome " +n;
        }
    }
}
