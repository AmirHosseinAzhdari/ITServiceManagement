using ITServiceManagement.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITServiceManagement.DataLayer.Services
{
    public class UserService : IUserService
    {
        private readonly ITServiceManagement_DBEntities db;
        public UserService(ITServiceManagement_DBEntities context)
        {
            db = context;
        }

        public List<Users> filterByUserName(string param)
        {
            return db.Users.Where(u => u.UserName.Contains(param)).ToList();
        }

        public string GetImageNameById(Guid id)
        {
            try
            {
                string imageName = db.Users.Where(u => u.UserId == id)
                    .Select(u => u.ImageUrl).FirstOrDefault();
                return imageName;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateUser(Users user)
        {
            try
            {
                Guid userId = user.UserId;
                var existUser = db.Users.Find(userId);
                existUser.UserId = userId;
                existUser.UserName = user.UserName;
                existUser.Gender = user.Gender;
                existUser.ImageUrl = user.ImageUrl;
                existUser.BirthDay = user.BirthDay;
                existUser.Address = user.Address;
                existUser.PhoneNumber = user.PhoneNumber;
                existUser.Email = user.Email;
                existUser.NationalCode = user.NationalCode;
                if (user.PasswordHash != null)
                    existUser.PasswordHash = user.PasswordHash;
                if (user.IsLocked == true)
                {
                    existUser.IsLocked = true;
                    existUser.LockedTime = DateTime.Now;
                }
                existUser.EmployeeId = user.EmployeeId;
                existUser.RoleId = user.RoleId;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
