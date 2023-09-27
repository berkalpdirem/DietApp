using DietApp.DAL.Concrete;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Managers
{
    public class UserManager : BaseManager<User>
    {
        protected UserRepository _userRepository;

        public UserManager(GenericRepository<User> genericRepository, UserRepository userRepository) : base(genericRepository)
        {
            _userRepository = userRepository;
        }

        public string AddUser(string email, string password1, string password2)
        {
            //E-mail veritabanında mevcut mu?
            if(!_userRepository.CheckEmailInDb(email))
            {
                if (CheckPassword(password1, password2))
                {
                    if(_userRepository.CreateUser(email, password1))
                    {
                        return "Kullanıcı ekleme başarılı.";
                    }
                    else
                    {
                        return "Kullanıcı ekleme başarısız. Servis sağlayıcınıza müracaat ediniz.";
                    }
                }
                else
                {
                    return "Parolalar eşleşmiyor.";
                }
            }
            else
            {
                return "Bu e-mail kullanımda.";
            }
        }

        public bool CheckPassword(string password1, string password2)
        {
            if(password1 == password2)
            {
                return true;
            }
            else 
            { 
                return false; 
            } 
        }
    }
}
