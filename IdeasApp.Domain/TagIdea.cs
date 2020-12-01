using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class TagIdea
    {
        [Key]
        public int TagListID { get; set; }
        public int IdeaID { get; set; }
        public int TagID { get; set; }
        public Idea Idea { get; set; }
        public Tag Tag { get; set; }
    }
}