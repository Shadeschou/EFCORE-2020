using System;
using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class Idea
    {
        [Key]
        public int IdeaID { get; set; }

        public string CompanyID { get; set; }

        public string UserID { get; set; }
        public int PriorityID { get; set; }
        public string IdeaStatusID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //Text was invalid so I had to change it to TextContent
        public string TextContent { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime MyProperty { get; set; }
    }
}