using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IUserPropertiesDal
    {
        public List<UserPropertyTbl> GetUserPropertiesAllAsync();
        public List<UserPropertyTbl> AddUserPropertiesAsync(UserPropertyTbl userProperties);
        public void UpdateUserProperties(string id, UserPropertyTbl userProperties);
        public void DeleteUserProperties(string id);
        public UserPropertyTbl GetUserPropertiesById(string id);
    }
}
