using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        [Required]
        public string ProductName { get; set; }

        public string Description { get; set; }
    }
}
