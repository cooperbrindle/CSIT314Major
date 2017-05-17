using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Employee
    {
        public String employeeID { get; set; }
        public String name { get; set; }
        public String phoneNumber { get; set; }
        public String address { get; set; }
        public String email { get; set; }
        public String department { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int privilege  { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
