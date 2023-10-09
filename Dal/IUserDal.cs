using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IUserDal
    {

        public List<User1Tbl> GetUserAllAsync();
        public List<User1Tbl> AddUserAsync(User1Tbl user);
        public void UpdateUser(string id, User1Tbl user);
        public void DeleteUser(string id);
        public User1Tbl GetUserById(string id);
    }
}

