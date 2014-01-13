using System;
using System.Collections.Generic;

namespace DataAccess.Entities.Impl
{
    public class ProjectEntity : IProjectEntity
    {
        public List<IBacklogEntity> BacklogitemsList { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<IUserEntity> Users { get; set; }
        public DateTime endDate { get; set; }

    }
}