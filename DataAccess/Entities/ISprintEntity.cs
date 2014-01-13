using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public interface ISprintEntity
    {
        List<ITaskEntity> tasks { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        int scrumBananer { get; set; }
        List<IDailyMeetingEntity> dailyMeetings { get; set; }
 

        // din mor
    }
}
