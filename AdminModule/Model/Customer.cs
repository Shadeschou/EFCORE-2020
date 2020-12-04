using System;
using System.Collections.Generic;
using System.Text;
using AdminModule.Annotations;

namespace AdminModule.Model
{
    class Customer : Bindable
    {
        

        public string CompanyID { get; set; }
        public string UserID { get; set; }
        public string Label { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserStatusID { get; set; }
        public string Name { get; set; }


    }
}
