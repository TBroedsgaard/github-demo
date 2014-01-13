using System;
using DataAccess.Entities.Enum;

namespace DataAccess.Entities
{
    public interface ITaskStatusEntity
    {
        int Id { get; set; }
        TaskStatusEnum status { get; set; }
        DateTime statusChanged { get; set; }
        IUserEntity userChanged { get; set; }
        string comment { get; set; }
        string description { get; set; }
         
    }
}