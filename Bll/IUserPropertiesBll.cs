using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    public interface IUserPropertiesBll
    {
        public List<UserPropertiesTblDto> GetUserPropertiesAllAsync();
        public List<UserPropertiesTblDto> AddUserPropertiesAsync(UserPropertiesTblDto userProperties);
        public void UpdateUserProperties(string id, UserPropertiesTblDto userProperties);
        public void DeleteUserProperties(string id);
        public UserPropertiesTblDto GetUserPropertiesById(string id);

    }
}

