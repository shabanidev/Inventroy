﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        public string BranchName { get; set; }

        public string Description { get; set; }
        [Display (Name ="Currency")]
        public int CurrencyId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }
        [Display (Name = "PersonContact")]
        public string Email { get; set; }


    }
}
