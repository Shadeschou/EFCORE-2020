using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        public string Title { get; set; }
    }
}