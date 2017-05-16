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
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Thread th;
        Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String queryStr = "SELECT username, privilege FROM Employee WHERE username = '" + textBox2.Text + "' and password = '" + textBox1.Text + "'";
            DataTable dt = db.query(queryStr);
            
            if(dt.Rows.Count > 0)
            {
                
                if (dt.Rows[0][1].ToString() == "1")
                    th = new Thread(openFullPrivilegeForm);

                else if (dt.Rows[0][1].ToString() == "2")
                    th = new Thread(openNonFullPrivilegeForm);

                this.Close();
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Incorret login, please check your username and password");
            }
        }

        private void openFullPrivilegeForm(object obj)
        {
            Application.Run(new main());
        }
        private void openNonFullPrivilegeForm(object obj)
        {
            Application.Run(new main2());
        }
    }
}
