﻿using DietApp.BL.Services;
using DietApp.DAL.Concrete;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Managers
{
    public class UserManager : BaseManager<User>, IUserService
    {
        protected UserRepository _userRepository;

        public UserManager(GenericRepository<User> genericRepository, UserRepository userRepository) : base(genericRepository)
        {
            _userRepository = userRepository;
        }

        public string AddUser(string email, string password1, string password2)
        {
            //E-mail veritabanında mevcut mu?
            if (!_userRepository.CheckEmailInDb(email))
            {
                if (CheckPasswordParity(password1, password2))
                {
                    if (CheckPasswordComplexity(password1))
                    {
                        if (_userRepository.CreateUser(email, password1))
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
                        return "Parola bir büyük harf, bir küçük harf ve bir özel karakter ( . - ! _ + ) içermelidir";
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

        public bool CheckPasswordParity(string password1, string password2)
        {
            if (password1 == password2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool CheckPasswordComplexity(string password1)
        {
            bool HasUppercaseChar = false;
            bool HasLowercaseChar = false;
            bool HasSpecialChar = false;

            foreach (char c in password1)
            {
                if (Char.IsLower(c))
                {
                    HasLowercaseChar = true;
                    break;
                }
            }

            if (HasLowercaseChar)
            {
                foreach (char c in password1)
                {
                    if (Char.IsUpper(c))
                    {
                        HasUppercaseChar = true;
                        break;
                    }
                }
            }

            if (HasUppercaseChar)
            {
                foreach (char c in password1)
                {
                    if (c == '.' || c == '-' || c == ',' || c == '!' || c == '_' || c == '+')
                    {
                        HasSpecialChar = true;
                        break;
                    }
                }
            }

            if (HasLowercaseChar && HasUppercaseChar && HasSpecialChar)
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
