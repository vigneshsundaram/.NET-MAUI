using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Model
{
     public class Team
    {
        public int id { set; get; }
        public string name { set; get; }

        public string location { set; get; }

        public int teamMembers { set; get; }
    }
}
