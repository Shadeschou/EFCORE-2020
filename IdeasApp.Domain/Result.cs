﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }
        public int IdeaID { get; set; }
        public string UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TextContent { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastDateTimeEdited { get; set; }
    }
}