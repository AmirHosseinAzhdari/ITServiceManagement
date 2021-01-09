using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITServiceManagement.DataLayer.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// get image url as string from data base
        /// </summary>
        /// <param name="id"> user id as GUID </param>
        /// <returns></returns>
        string GetImageNameById(Guid id);

        /// <summary>
        /// update user in data base
        /// </summary>
        /// <param name="user"> <see cref="Users"/> </param>
        /// <returns> True or False </returns>
        bool UpdateUser(Users user);

        /// <summary>
        /// get list of users filter by username
        /// </summary>
        /// <param name="param"> parameter for filter </param>
        /// <returns>list of users</returns>
        List<Users> filterByUserName(string param);
    }
}
