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
    public partial class LoginForm : Form
    {
        string name;
        Thread th;
        Database db;
        int id, priv;
        public LoginForm()
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
            name = textBox2.Text;
            String queryStr = "SELECT username, privilege, employeeID FROM Employee WHERE username = '" + textBox2.Text + "' and password = '" + textBox1.Text + "'";
            DataTable dt = db.query(queryStr);
            
            if(dt.Rows.Count > 0)
            {
                id = Convert.ToInt32(dt.Rows[0][2].ToString());
                priv = Convert.ToInt32(dt.Rows[0][1].ToString());
                /*if (dt.Rows[0][1].ToString() == "1")
                    th = new Thread(openCeoForm);

                else if (dt.Rows[0][1].ToString() == "2")
                    th = new Thread(openDeptForm);
                else if (dt.Rows[0][1].ToString() == "3")
                    th = new Thread(openManForm);
                */

                th = new Thread(openForm);
                
                this.Close();
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Incorret login, please check your username and password");
            }
        }

        private void loggedOut(object obj, EventArgs e)
        {
            th.Join();
            this.Activate();
        }

        private void openForm(object obj)
        {
            @base form = new @base();
            switch (priv)
            {
                case 1: form = new CeoDash(id);
                    break;
                case 2: form = new EmployeeDash(id);
                    break;
                case 3: form = new pManager(id);
                    break;
            }
            //form.WriteTextBoxTextToLabel(name);
            form.Disposed += new EventHandler(loggedOut);
            form.writeName(name);
            Application.Run(form);
        }
        /*private void openCeoForm(object obj)
        {
            CeoDash EmployeeDash = new CeoDash(id);
            EmployeeDash.WriteTextBoxTextToLabel(name);
            Application.Run(EmployeeDash);
        }
        private void openDeptForm(object obj)
        {
            EmployeeDash EmployeeDash = new EmployeeDash(id);
            EmployeeDash.WriteTextBoxTextToLabel(name);
            Application.Run(EmployeeDash);
        }
        private void openManForm(object obj)
        {
            pManager pManager = new pManager(id);
            pManager.WriteTextBoxTextToLabel(name);
            Application.Run(pManager);
        }*/
    }
}
