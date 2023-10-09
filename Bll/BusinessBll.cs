using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using Entity;
using AutoMapper;


namespace Bll
{
    public class BusinessBll : IBusinessBll
    {
        IBusinessDal _businessDal;
        private readonly IMapper _mapper;
        public BusinessBll(IBusinessDal businessDal, IMapper mapper)
        {
            this._businessDal = businessDal;
            _mapper = mapper;
        }
        public List<BusinessTblDto> AddBusinessAsync(BusinessTblDto business)
        {
            this._businessDal.AddBusinessAsync(_mapper.Map<BusinessTbl>(business)); 
            return GetBusinessAllAsync();

        }
        public void DeleteBusiness(string id)
        {
            this._businessDal.DeleteBusiness(id);
        }

        public List<BusinessTblDto> GetBusinessAllAsync()
        {
            return _mapper.Map<List<BusinessTblDto>>(this._businessDal.GetBusinessAllAsync());
        }

        public BusinessTblDto GetBusinessById(string id)
        {
            return _mapper.Map<BusinessTblDto>(this._businessDal.GetBusinessById(id));
        }

        public void UpdateBusiness(string id, BusinessTblDto business)
        {
            this._businessDal.UpdateBusiness(id,_mapper.Map<BusinessTbl>(business));
        }
    }
}



