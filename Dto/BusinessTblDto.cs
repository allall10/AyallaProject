using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class BusinessTblDto
    {
        public string businessId { get; set; }
        public string businessName { get; set; }
        public string businessIdCity { get; set; }
        public Boolean professionType { get; set; }
        public string languageId { get; set; }
        public float numWeekHours { get; set; }
        public int seniorityBusiness { get; set; }
        public float salaryHour { get; set; }
    }
}

