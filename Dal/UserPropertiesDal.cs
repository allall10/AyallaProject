using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserPropertiesDal 
    {
        WorkContext _context;
        public UserPropertiesDal(WorkContext context)
        {
            WorkContext context1 = context;
            this._context = context1;
        }
        public List<UserPropertyTbl> AddUserPropertiesAsync(UserPropertyTbl userProperties)
        {
            this._context.UserProperties.AddAsync(userProperties);
            this._context.SaveChanges();
            return GetUserPropertiesAllAsync();
        }
        public void DeleteUserProperties(string id)
        {
            var userProperties = this._context.UserProperties.First(x => x.UserPropertiesId == id);
            this._context.UserProperties.Remove(userProperties);
            this._context.SaveChanges();
        }

        public List<UserPropertyTbl> GetUserPropertiesAllAsync()
        {
            return _context.UserProperties.ToList();
        }

        public UserPropertyTbl GetUserPropertiesById(string id)
        {
            return this._context.UserProperties.First(x => x.UserPropertiesId == id);
        }

        public void UpdateUserProperties(string id, UserPropertyTbl userProperties)
        {
            var userProperties1 = this._context.UserProperties.FirstOrDefault(x => x.UserPropertiesId != id);
            if (userProperties1 != null)
            {
                userProperties1.UserId = userProperties.UserId;
                userProperties1.LanguageId = userProperties.LanguageId;
            }
            this._context.SaveChanges();
        }
    }
}
