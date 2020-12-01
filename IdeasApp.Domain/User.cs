using System;
using System.ComponentModel.DataAnnotations;

namespace IdeasApp.Domain
{
    public class User
    {
        [Key]
        public string CompanyID { get; set; }
        public string UserStatusID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //Stating that for one Company one MainContact works. 
        public Company Company { get; set; }
    }
}