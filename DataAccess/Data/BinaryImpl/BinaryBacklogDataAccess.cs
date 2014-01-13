using DataAccess.Entities;

namespace DataAccess.Data.BinaryImpl
{
    public class BinaryBacklogDataAccess : IDataAccess<IBacklogEntity>
    {

        public IBacklogEntity Load(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(IBacklogEntity t)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(IBacklogEntity t)
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

        public System.Collections.Generic.List<IBacklogEntity> LoadAll(int start, int count, bool asc)
        {
            throw new System.NotImplementedException();
        }

        public void Flush()
        {
            throw new System.NotImplementedException();
        }
    }
}