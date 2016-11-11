using DLL.Context;
using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class UserRepository : IRepository<User>
    {
        public User Create(User t)
        {
            using (var ctx = new FPContext())
            {
                ctx.Users.Add(t);
                ctx.SaveChanges();
                return t;
            }
        }

        public bool Delete(User t)
        {
            using (var ctx = new FPContext())
            {
                ctx.Entry(ctx.Users.FirstOrDefault(x => x.Id == t.Id)).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
                return ctx.Users.FirstOrDefault(x => x.Id == t.Id) == null;
            }
        }

        public User Get(int id)
        {
            using (var ctx = new FPContext())
            {
                return ctx.Users.FirstOrDefault(x => x.Id == id);

            }
        }

        public List<User> ReadAll()
        {
            using (var ctx = new FPContext())
            {
                return ctx.Users.ToList();
            }
        }

        public User Update(User t)
        {
            using (var ctx = new FPContext())
            {
                var userToUpdate = ctx.Users.FirstOrDefault(x => x.Id == t.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.FirstName = t.FirstName;
                    userToUpdate.LastName = t.LastName;
                    userToUpdate.Email = t.Email;
                    userToUpdate.Company = t.Company;
                    userToUpdate.Type = t.Type;
                    userToUpdate.Password = t.Password;
                }
                ctx.SaveChanges();
                return t;
            }
        }
    }
}
