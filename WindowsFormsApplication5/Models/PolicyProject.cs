using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class PolicyProjectModel
    {
        public String policyProjectID {get; set;}
        public String startDate {get; set;}
        public String estEndDate {get; set;}
        public String endDate {get; set;}
        public int finalCost {get; set;}
        public int progress {get; set;}
        public String departmentHeadID {get; set;}
        public String projectManagerID {get; set;}
        public int policyID {get; set;}
        public int projectID {get; set;}
        public int weighting {get; set;}
        public String name { get; set; }

        public PolicyProjectModel() { }

        public override string ToString()
        {
            return policyProjectID;
        }
    }
}
