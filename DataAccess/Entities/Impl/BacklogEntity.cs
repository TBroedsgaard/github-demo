using System.Collections.Generic;

namespace DataAccess.Entities.Impl
{
    public class BacklogEntity : IBacklogEntity
    {
        public List<ISprintEntity> sprints { get; set; }
        public int imp { get; set; }
        public int est { get; set; } 
    }
}