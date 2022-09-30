using System;
using YukselenWebAPI.BL.Repositories.User;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace YukselenWebAPI.BL.Services
{
    public class UserCreate
    {
        readonly IUserWriteRepository _userWrite;

        public UserCreate(IUserWriteRepository userWrite)
        {
            _userWrite = userWrite;
        }

        public async Task<int>  NewUserCreate(object user)
        {
            string gender;
            if (user.GetType().GetProperty("Gender").GetValue(user, null).ToString() == "KADIN")
            {
                gender = "K";
            }
            if (user.GetType().GetProperty("Gender").GetValue(user, null).ToString() == "ERKEK")
            {
                gender = "E";
            }
            else
            {
                gender = "K";
            }


            EntityLayer.Entities.Users newuser = new EntityLayer.Entities.Users
            {
                NameSurname = user.GetType().GetProperty("Name").GetValue(user, null).ToString(),
                MailAdress = user.GetType().GetProperty("Email").GetValue(user, null).ToString(),
                Gender = gender.ToString(),
                BirthDate = DateTime.ParseExact(user.GetType().GetProperty("BirthDate").GetValue(user, null).ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
            };

            await _userWrite.AddAsync(newuser);
            int id = newuser.Id;

            return newuser.Id;
        }
    }
}
