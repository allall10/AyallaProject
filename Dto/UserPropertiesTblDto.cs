using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public partial class UserPropertiesTblDto
    {
        public string UserPropertiesId { get; set; }
        public string userId { get; set; }
        public string languageId { get; set; }
        public int seniorityLanguage { get; set; }
        public float numMonthLearn { get; set; }
        public string diploma { get; set; }
    }
}
