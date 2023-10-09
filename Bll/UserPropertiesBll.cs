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
    public class UserPropertiesBll
    {
        IUserPropertiesDal _userPropertiesDal;
        private readonly IMapper _mapper;
        public UserPropertiesBll(IUserPropertiesDal userPropertiesDal, IMapper mapper)
        {
            this._userPropertiesDal = userPropertiesDal;
            _mapper = mapper;
        }
        public List<UserPropertiesTblDto> AddUserPropertiesAsync(UserPropertiesTblDto userProperties)
        {
            this._userPropertiesDal.AddUserPropertiesAsync(_mapper.Map<UserPropertyTbl>(userProperties));
            return GetUserPropertiesAllAsync();

        }

        public void DeleteUserProperties(string id)
        {
            this._userPropertiesDal.DeleteUserProperties(id);
        }

        public List<UserPropertiesTblDto> GetUserPropertiesAllAsync()
        {
            return _mapper.Map<List<UserPropertiesTblDto>>(this._userPropertiesDal.GetUserPropertiesAllAsync());
        }

        public UserPropertiesTblDto GetUserPropertiesById(string id)
        {
            return _mapper.Map<UserPropertiesTblDto>(this._userPropertiesDal.GetUserPropertiesById(id));
        }

        public void UpdateUserProperties(string id, UserPropertiesTblDto userProperties)
        {
            this._userPropertiesDal.UpdateUserProperties(id, _mapper.Map<UserPropertyTbl>(userProperties));
        }
        //Task<List<CustomerTblDto>> ICustomerBll.AddCustomerAsync(CustomerTbl customer)
        //{
        //    throw new NotImplementedException();
            //}
        }
}


