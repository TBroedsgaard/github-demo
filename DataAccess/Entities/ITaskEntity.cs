using System.Collections.Generic;

namespace DataAccess.Entities
{
    public interface ITaskEntity
    {
        int id { get; set; }
        int scrumBananer { get; set; }
        string description { get; set; }
        string title { get; set; }
        List<ITaskStatusEntity> status { get; set; }
        IUserEntity user { get; set; }

        //Hej med jer. Jeg ved ikke hvad jeg skal goere?
    }
}