using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;


namespace IdeasApp.Domain
{
    public class Company
    {
        [Key]
        public string CompanyID { get; set; }
        public string UserID { get; set; }
        public string Label { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }//This might break EFCore.
    }
}