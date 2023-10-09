using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dto;

namespace Dal
{
    public class BusinessDal : IBusinessDal
    {
        WorkContext _context;
        public BusinessDal(WorkContext context)
        {
            this._context = context;
        }
        public List<BusinessTbl> AddBusinessAsync(BusinessTbl business)
        {
            this._context.Business.AddAsync(business);
            this._context.SaveChanges();
            return GetBusinessAllAsync();
        }

        public void DeleteBusiness(string id)
        {
            var business = this._context.Business.First(x => x.BusinessId == id);
            this._context.Business.Remove(business);
            this._context.SaveChanges();
        }

        public List<BusinessTbl> GetBusinessAllAsync()
        {
            var res=this._context.Business.ToList();
            return this._context.Business.ToList();
        }

        public BusinessTbl GetBusinessById(string id)
        {
            return this._context.Business.First(x => x.BusinessId == id);
        }

        public void UpdateBusiness(string id, BusinessTbl business)
        {
            var business1 = this._context.Business.FirstOrDefault(x => x.BusinessId != id);
            if (business1 != null)
            {
                business1.BusinessCity = business.BusinessCity;
                business1.BusinessName = business.BusinessName;
            }
            this._context.SaveChanges();
        }
    }
}
