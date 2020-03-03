using System;
using System.ComponentModel.DataAnnotations;

namespace DojoActivityCenter.Models
{
    public class Join{
        [Key]
        public int JoinId {get;set;}
        public int UserId {get;set;}
        public int ActivityEventId {get;set;}
        public ActivityEvent activityEvent {get;set;}
        public User user {get;set;}
    }
}