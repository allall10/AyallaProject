using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IUserBll
    {
        public List<UserTblDto> GetUserAllAsync();
        public List<UserTblDto> AddUserAsync(UserTblDto user);
        public void UpdateUser(string id, UserTblDto user);
        public void DeleteUser(string id);
        public UserTblDto GetUserById(string id);
    }
}




