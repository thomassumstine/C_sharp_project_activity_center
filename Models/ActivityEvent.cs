using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivityCenter.Models
{
    public class ActivityEvent
    {
        [Key]
        public int ActivityEventId { get; set; }
        [Required]
        [Display(Name = "Activity Type")]
        [MinLength(2, ErrorMessage = "Field has to contain at least 2 characters and more")]
        public string ActivityType { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string DurationTimeUnit { get; set; }
        [DataType(DataType.Duration)]
        public uint Duration { get; set; }
        public User EventCoordinator {get; set;}
        public int EventCoordinatorId {get; set;}
        public List<Join> Participants {get; set;}
        

    }
}