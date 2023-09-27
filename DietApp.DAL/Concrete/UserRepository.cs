using DietApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Concrete
{
    public class UserRepository :GenericRepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
            
        }

        public bool CreateUser(string email, string password)
        {
            User user = new User() { 
                Email = email,
                Password = password
            };

            try
            {
                Add(user);

                if (Get(user.ID) != null)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }  
        }

        public bool CheckEmailInDb(string email)
        {
            foreach (var user in DbSet)
            {
                if (user.Email == email)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
