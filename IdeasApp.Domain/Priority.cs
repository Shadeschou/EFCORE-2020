using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class Priority
    {
        [Key]
        public string PriorityID { get; set; }
        public string Description { get; set; }
    }
}