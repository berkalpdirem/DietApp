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
            return true;
            
        }

        public bool CheckPasswordInDb(string password)
        {
            return true;
        }

        public bool CheckEmailInDb(string email)
        {
            return true;
        }
    }
}
