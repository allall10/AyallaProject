using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public partial class UserTblDto
    {
        public string userId { get; set; }
        public string name1 { get; set; }
        public string userCity { get; set; }
        public string mail { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public Boolean professionType { get; set; }
        public float expectationsSalary { get; set; }
        public float userSeniority { get; set; }

    }
}
