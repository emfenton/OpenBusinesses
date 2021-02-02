using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBusiness.Models
{
    public class BusinessType
    {
        [RequiredAttribute]
        public int ID { get; set; }

        [RequiredAttribute]
        public string Name { get; set; }
    
    }
}