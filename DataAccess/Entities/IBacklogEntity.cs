using System.Collections.Generic;

namespace DataAccess.Entities
{
    public interface IBacklogEntity
    {
        List<ISprintEntity> sprints { get; set; }
        int imp { get; set; }
        int est { get; set; }

    }
}