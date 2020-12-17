using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBusiness.Models
{
    public class Business
    {
        [RequiredAttribute]
        public int ID { get; set; }

        [RequiredAttribute]
        public string Name { get; set; }

        [RequiredAttribute]
        public string Type { get; set; }
        
        [RequiredAttribute]        
        public string Website { get; set; }

        [RequiredAttribute]        
        public bool Verified { get; set; }
    
    }
}