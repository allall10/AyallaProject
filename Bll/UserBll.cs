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
    public class UserBll
    {
        IUserDal _userDal;
        private readonly IMapper _mapper;
        public UserBll(IUserDal userDal, IMapper mapper)
        {
            this._userDal = userDal;
            _mapper = mapper;
        }
        public List<UserTblDto> AddUserAsync(UserTblDto user)
        {
            this._userDal.AddUserAsync(_mapper.Map<User1Tbl>(user));
            return GetUserAllAsync();

        }

        public void DeleteUser(string id)
        {
            this._userDal.DeleteUser(id);
        }

        public List<UserTblDto> GetUserAllAsync()
        {
            return _mapper.Map<List<UserTblDto>>(_userDal.GetUserAllAsync());
        }

        public UserTblDto GetUserById(string id)
        {
            return _mapper.Map<UserTblDto>(this._userDal.GetUserById(id));
        }

        public void UpdateUser(string id, UserTblDto user)
        {
            this._userDal.UpdateUser(id, this._mapper.Map<User1Tbl>(user));
        }
        //Task<List<CustomerTblDto>> ICustomerBll.AddCustomerAsync(CustomerTblDto customer)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

