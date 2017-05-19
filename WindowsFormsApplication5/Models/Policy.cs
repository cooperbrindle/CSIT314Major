using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Policy
    {
        public int policyID {get; set;}
        public String name {get; set;}
        public String statement{get; set;}

        public Policy()
        {

        }

        public override string ToString()
        {
            return name;
        }

    }
}
