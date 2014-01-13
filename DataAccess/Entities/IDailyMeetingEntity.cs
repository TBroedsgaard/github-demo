using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public interface IDailyMeetingEntity
    {
        DateTime date { get; set; }
        string todoYesterday { get; set; }
        string todoToday { get; set; }
        string roadblocks { get; set; }
        IUserEntity user { get; set; }
    }
}
