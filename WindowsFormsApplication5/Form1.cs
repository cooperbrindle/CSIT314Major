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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dan\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From STAFF where USERNAME = '" + textBox2.Text + "' and PASSWORD = '" + textBox1 .Text + "' and FPRIVILEGE = 1", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Count(*) From STAFF where USERNAME = '" + textBox2.Text + "' and PASSWORD = '" + textBox1.Text + "' and FPRIVILEGE = 0", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Close();
                th = new Thread(openFullPrivilegeForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (dt2.Rows[0][0].ToString() == "1")
            {
                this.Close();
                th = new Thread(openNonFullPrivilegeForm);
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
