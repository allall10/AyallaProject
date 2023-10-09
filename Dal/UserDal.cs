using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal : IUserDal
    {
        WorkContext _context;
        public UserDal(WorkContext context)
        {
            this._context = context;
        }
        public List<User1Tbl> AddUserAsync(User1Tbl user)
        {
            this._context.Users1.AddAsync(user);
            this._context.SaveChanges();
            return GetUserAllAsync();
        }
        public void DeleteUser(string id)
        {
            var user = this._context.Users1.First(x => x.UserId == id);
            this._context.Users1.Remove(user);
            this._context.SaveChanges();
        }

        public List<User1Tbl> GetUserAllAsync()
        {
            return this._context.Users1.ToList();
        }

        public User1Tbl GetUserById(string id)
        {
            return this._context.Users1.First(x => x.UserId == id);
        }

        public void UpdateUser(string id, User1Tbl user)
        {
            var user1 = this._context.Users1.FirstOrDefault(x => x.UserId != id);
            if (user1 != null)
            {
                user1.Name1 = user.Name1;
                user1.UserCity = user.UserCity;
            }
            this._context.SaveChanges();
        }
    }
}
