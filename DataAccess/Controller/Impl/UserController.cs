using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Impl;

namespace DataAccess.Controller.Impl
{
    class UserController : ICRUDController<UserEntity>, IUserController
    {
        UserEntity ICRUDController<UserEntity>.Load(int id)
        {
            throw new NotImplementedException();
        }

        bool ICRUDController<UserEntity>.Save(UserEntity t)
        {
            throw new NotImplementedException();
        }

        bool ICRUDController<UserEntity>.Update(UserEntity t)
        {
            throw new NotImplementedException();
        }

        bool ICRUDController<UserEntity>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool ICRUDController<UserEntity>.Delete(List<int> idList)
        {
            throw new NotImplementedException();
        }

        List<UserEntity> ICRUDController<UserEntity>.LoadAll(int start, int count, bool asc)
        {
            throw new NotImplementedException();
        }

        public UserEntity Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
