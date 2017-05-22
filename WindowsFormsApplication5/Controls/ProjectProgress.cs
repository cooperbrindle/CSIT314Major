using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Controls
{
    public partial class ProjectProgress : UserControl
    {
        int policyID;

        public ProjectProgress()
        {
            InitializeComponent();
            
        }
        public ProjectProgress(int id) : this()
        {
            policyID = id;
            Database db = new Database();
            DataTable t = db.query("SELECT * FROM PolicyProject WHERE policyID = " + policyID);
            foreach(DataRow r in t.Rows)
            {

                PolicyProjectModel p = new PolicyProjectModel
                {
                    policyProjectID = r[0].ToString(),
                    startDate = r[1].ToString(),
                    estEndDate = r[2].ToString(),
                    endDate = r[3].ToString(),
                    finalCost = Convert.ToInt32(r[4].ToString()),
                    progress = Convert.ToInt32(r[5].ToString()),
                    departmentHeadID = r[6].ToString(),
                    projectManagerID = r[7].ToString(),
                    policyID = Convert.ToInt32(r[8].ToString()),
                    projectID = Convert.ToInt32(r[9].ToString()),
                    weighting = Convert.ToInt32(r[10].ToString())
                };
                
            }
        }
    }
}
