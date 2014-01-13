using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess.Entities
{
    public interface IUserEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        DateTime Created { get; set; }
        string Email { get; set; }
        List<IUserEntity> Friends { get; set; }


    }
}