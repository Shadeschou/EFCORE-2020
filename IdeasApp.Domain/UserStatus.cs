using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class UserStatus
    {
        [Key]
        public string UserStatusID { get; set; }
        public string Description { get; set; }
    }
}