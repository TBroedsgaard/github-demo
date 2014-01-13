using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data.Helpers;
using DataAccess.Entities;
using DataAccess.Entities.Impl;

namespace DataAccess.Data.BinaryImpl
{
    class BinaryUserDataAccess : IDataAccess<IUserEntity>,IUserDataAccess
    {
        private const string FILENAME = "UserData";
        BinaryHelper<IUserEntity> binaryHelper = new BinaryHelper<IUserEntity>();

        public IUserEntity Load(int id)
        {
            var allUsers = LoadAll();
            return allUsers.Single(user => user.Id == id);
        }

        public bool Save(IUserEntity user)
        {
            var allUsers = LoadAll();
            allUsers.Add(user);
            return SaveList(allUsers);
        }

        public bool Update(IUserEntity user)
        {
            var allUsers = LoadAll();
            var userToUpdate = Load(user.Id);
            allUsers.Remove(userToUpdate);
            allUsers.Add(user);
            return SaveList(allUsers);
        }

        public bool Delete(int id)
        {
            var allUsers = LoadAll();
            var userToDelete = Load(id);
            allUsers.Remove(userToDelete); 
            return SaveList(allUsers);
        }

        public bool Delete(List<int> idList)
        {
            List<IUserEntity> usersToDelete = new List<IUserEntity>();
            foreach (int id in idList)
            {
                usersToDelete.Add(Load(id));
            }
            var allUsers = LoadAll();
            foreach(IUserEntity user in usersToDelete)
            {
                allUsers.Remove(user); 
            }

            return SaveList(allUsers);
        }

        public List<IUserEntity> LoadAll(int start, int count, bool asc)
        {
            // Snyder lidt her fordi binary ikke rigtig understøtter sortering
            return LoadAll();
        }

        private List<IUserEntity> LoadAll()
        {
            // Henter alle users med binaryhelperen
            return binaryHelper.LoadAll(FILENAME);
        }

        private bool SaveList(List<IUserEntity> list)
        {
            // Gemmer listen
            return binaryHelper.SaveList(list, FILENAME);
        }
        
        public IUserEntity Login(string username, string password)
        {
            var allUsers = LoadAll();
            // hvad retunere den hvis brugeren ikke er rigtig?
            return allUsers.Single(user => user.Username == username && user.Password == password);
        }
    }
}
