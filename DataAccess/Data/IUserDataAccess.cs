using DataAccess.Entities;

namespace DataAccess.Data
{
    public interface IUserDataAccess
    {
        IUserEntity Login(string username,string password);
    }
}