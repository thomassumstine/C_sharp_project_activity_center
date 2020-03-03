using System.ComponentModel.DataAnnotations;

namespace DojoActivityCenter.Models
{
    public class LogModel{
        [Required]
        [EmailAddress]
        public string LEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }

}