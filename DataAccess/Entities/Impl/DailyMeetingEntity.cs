using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Impl
{
    public class DailyMeetingEntity : IDailyMeetingEntity
    {

        public DateTime date {get; set;}
        public string todoYesterday {get; set;}
        public string todoToday {get; set;}
        public string roadblocks {get; set;}
        public IUserEntity user {get; set;}
    }
}
