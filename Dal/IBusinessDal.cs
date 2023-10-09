using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IBusinessDal
    {
        public List<BusinessTbl> GetBusinessAllAsync();
        public List<BusinessTbl> AddBusinessAsync(BusinessTbl business);
        public void UpdateBusiness(string id, BusinessTbl business);
        public void DeleteBusiness(string id);
        public BusinessTbl GetBusinessById(string id);
    }
}
