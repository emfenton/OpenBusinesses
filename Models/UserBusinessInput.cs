using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBusiness.Models
{
    public class UserBusinessInput
    {

        [RequiredAttribute]
        public string Name { get; set; }

        [RequiredAttribute]      
        public int BusinessTypeId { get; set; }

        [RequiredAttribute]        
        public string Website { get; set; }

        [RequiredAttribute]        
        public string Contact { get; set; }
    
    }
}