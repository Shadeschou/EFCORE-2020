﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class Challenge
    {
        [Key]
        public int ChallengeID { get; set; }
        public int IdeaID { get; set; }
        public int UserID { get; set; }
        public string TextContent { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateTimeEdited { get; set; }
    }
}