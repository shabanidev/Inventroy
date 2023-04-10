﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "CustomerType")]
        public int CustomerTypeId { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; } 

        public string City { get; set; }

        public string State { get; set; }
        [Display(Name = "zipcode")]
        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ContactPerson { get; set; }

    }
}
