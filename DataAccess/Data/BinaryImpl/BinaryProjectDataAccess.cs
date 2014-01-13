using DataAccess.Entities.Impl;

namespace DataAccess.Data.BinaryImpl
{
    class BinaryProjectDataAccess : IDataAccess<ProjectEntity>
    {

        public ProjectEntity Load(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(ProjectEntity t)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(ProjectEntity t)
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

        public System.Collections.Generic.List<ProjectEntity> LoadAll(int start, int count, bool asc)
        {
            throw new System.NotImplementedException();
        }

        public void Flush()
        {
            throw new System.NotImplementedException();
        }
    }
}