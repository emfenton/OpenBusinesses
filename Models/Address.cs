using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBusiness.Models
{
    public class Address
    {
        [RequiredAttribute]
        public int ID { get; set; }

        [RequiredAttribute]
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        
        [RequiredAttribute]        
        public string City { get; set; }
                
        [RequiredAttribute]        
        public string State { get; set; }
                
        [RequiredAttribute]        
        public string Zip { get; set; }
    }
}