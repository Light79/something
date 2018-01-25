using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class UserDAO
    {
        ManageDbContext db = null;
        public UserDAO()
        {
            db = new ManageDbContext();
        }
        public int Login(string account, string passWord)
        {
            var result = db.Users.SingleOrDefault(f => f.Account == account);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Password == passWord)
                    return 1;
                else
                    return -1;
            }
        }

        public User getAccount(string account)
        {
            return db.Users.SingleOrDefault(n => n.Account == account);
        }

        public int Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.UserID;
        }


        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public User Edit(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.UserID);
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                user.Email = entity.Email;
                user.Role = entity.Role;
                db.SaveChanges();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
