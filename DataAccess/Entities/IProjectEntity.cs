using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public interface IProjectEntity
    {
        List<IBacklogEntity> BacklogitemsList { get; set; }
        int id { get; set; }
        string name { get; set; }
        List<IUserEntity> Users { get; set; }
        DateTime endDate { get; set; }

    }
}