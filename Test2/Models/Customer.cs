﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public byte MembershipTypeId { get; set; }

        //Data Annotation
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribetToNewletter { get; set; }
        public MembershipType MembershipType { get; set; }
        
        //[Display (Name="Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}