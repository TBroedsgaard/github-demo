﻿using DataAccess.Entities;

namespace DataAccess.Data.BinaryImpl
{
    public class BinaryTaskDataAccess : IDataAccess<ITaskEntity>
    {

        public ITaskEntity Load(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(ITaskEntity t)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(ITaskEntity t)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(System.Collections.Generic.List<int> idList)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<ITaskEntity> LoadAll(int start, int count, bool asc)
        {
            throw new System.NotImplementedException();
        }

        public void Flush()
        {
            throw new System.NotImplementedException();
        }
    }
}