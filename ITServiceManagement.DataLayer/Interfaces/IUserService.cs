using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITServiceManagement.DataLayer.Interfaces
{
    public interface IUserService
    {
        #region User and Roles

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
        List<Users> FilterByUserName(string param);

        /// <summary>
        /// get list of users 
        /// </summary>
        /// <param name="roleId"> user role id </param>
        /// <returns></returns>
        List<Users> GetUserByRoleId(short roleId);

        #endregion

        #region Tickets

        /// <summary>
        /// get tickets of user by start date and end date
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        List<UserTickets> GetUserTickets(Guid id, DateTime startDate, DateTime endDate);

        #endregion
    }
}
