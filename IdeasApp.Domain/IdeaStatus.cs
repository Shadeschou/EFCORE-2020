using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class IdeaStatus
    {
        [Key]
        public string IdeaStatusID { get; set; }
        public string Description { get; set; }
    }
}