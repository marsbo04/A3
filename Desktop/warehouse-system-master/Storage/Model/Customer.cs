using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }




        public Customer(string Name, String Address, string Phone, String Email) {
            this.Name = Name; 
            this.Address = Address; 
            this.Phone = Phone;
            this.Email = Email;
        
        }
    }
}
