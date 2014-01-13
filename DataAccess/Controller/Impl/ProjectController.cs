using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Impl;

namespace DataAccess.Controller.Impl
{
    class ProjectController : ICRUDController<ProjectEntity>
    {
        public ProjectEntity Load(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(ProjectEntity t)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProjectEntity t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<int> idList)
        {
            throw new NotImplementedException();
        }

        public List<ProjectEntity> LoadAll(int start, int count, bool asc)
        {
            throw new NotImplementedException();
        }
    }
}
