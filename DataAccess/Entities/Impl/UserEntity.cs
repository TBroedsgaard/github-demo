using System;
using System.Collections.Generic;

namespace DataAccess.Entities.Impl
{
    public class UserEntity : IUserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public List<IUserEntity> Friends { get; set; }
        public string Username { get; set; }
    }
}