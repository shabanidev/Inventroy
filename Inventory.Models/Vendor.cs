using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Required]
        public string VendorName { get; set; }
        [Display(Name = "VendorType")]
        public int VendorTypeId { get; set; }
        [Display(Name = "Streetaddress")]
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        [Display(Name = "zipcode")]
        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }
        [Display(Name = "PersonContact")]
        public string Email { get; set; }
    }
}
