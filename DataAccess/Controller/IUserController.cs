using DataAccess.Entities.Impl;

namespace DataAccess.Controller
{
    public interface IUserController
    {
        UserEntity Login(string username,string password);
        //Test. GitHub.
    }
}