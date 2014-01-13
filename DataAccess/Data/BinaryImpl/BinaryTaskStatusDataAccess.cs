using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Data.Helpers;

namespace DataAccess.Data.BinaryImpl
{
    class BinaryTaskStatusDataAccess : IDataAccess<ITaskStatusEntity>
    {
        private const string FILENAME = "TaskStatus";
        BinaryHelper<ITaskStatusEntity> binaryHelper = new BinaryHelper<ITaskStatusEntity>();

        public ITaskStatusEntity Load(int id)
        {
            var allTaskStatuses = loadAll();

            return allTaskStatuses.Single(task => task.Id == id);
        }

        public bool Save(ITaskStatusEntity taskStatus)
        {
            var allTaskStatuses = loadAll();
            allTaskStatuses.Add(taskStatus);

            return saveList(allTaskStatuses);
        }

        public bool Update(ITaskStatusEntity taskStatus)
        {
            var allTaskStatuses = loadAll();
            var taskStatusToUpdate = Load(taskStatus.Id);
            allTaskStatuses.Remove(taskStatusToUpdate);
            allTaskStatuses.Add(taskStatus);

            return saveList(allTaskStatuses);
        }

        public bool Delete(int id)
        {
            var allTaskStatuses = loadAll();
            var taskStatusToDelete = Load(id);
            allTaskStatuses.Remove(taskStatusToDelete);

            return saveList(allTaskStatuses);
        }

        public bool Delete(List<int> idList)
        {
            List<ITaskStatusEntity> taskStatusesToDelete = new List<ITaskStatusEntity>();
            foreach (int id in idList)
            {
                taskStatusesToDelete.Add(Load(id));
            }

            var allTaskStatuses = loadAll();
            foreach (ITaskStatusEntity taskStatus in taskStatusesToDelete)
            {
                allTaskStatuses.Remove(taskStatus);
            }

            return saveList(allTaskStatuses);
        }

        public List<ITaskStatusEntity> LoadAll(int start, int count, bool asc)
        {
            return loadAll();
        }

        private List<ITaskStatusEntity> loadAll()
        {
            return binaryHelper.LoadAll(FILENAME);
        }

        private bool saveList(List<ITaskStatusEntity> list)
        {
            return binaryHelper.SaveList(list, FILENAME);
        }

        public void Flush()
        {
            // Delete all?
            throw new NotImplementedException();
        }
    }
}
