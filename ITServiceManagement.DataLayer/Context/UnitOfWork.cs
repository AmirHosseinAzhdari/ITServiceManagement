using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITServiceManagement.DataLayer.Interfaces;
using ITServiceManagement.DataLayer.Repositories;
using ITServiceManagement.DataLayer.Services;

namespace ITServiceManagement.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly ITServiceManagement_DBEntities _db = new ITServiceManagement_DBEntities();

        private IUserService userService;
        public IUserService UserService
        {
            get
            {
                return userService ?? (userService = new UserService(_db));
            }
        }

        private CommonGenericRepository<Users> userRepository;
        public CommonGenericRepository<Users> UserRepository
        {
            get
            {
                return userRepository ?? (userRepository = new CommonGenericRepository<Users>(_db));
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
