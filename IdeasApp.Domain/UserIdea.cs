using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class UserIdea
    {
        [Key]
        public int UserIdeaID { get; set; }
        public int IdeaID { get; set; }
        public int UserID { get; set; }
        public Idea Idea { get; set; }
        public User User { get; set; }
    }
}