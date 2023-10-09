using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IBusinessBll
    {
        public List<BusinessTblDto> GetBusinessAllAsync();
        public List<BusinessTblDto> AddBusinessAsync(BusinessTblDto business);
        public void UpdateBusiness(string id, BusinessTblDto business);
        public void DeleteBusiness(string id);
        public BusinessTblDto GetBusinessById(string id);
    }
}







