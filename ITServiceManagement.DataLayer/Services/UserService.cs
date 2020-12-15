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

        
    }
}
