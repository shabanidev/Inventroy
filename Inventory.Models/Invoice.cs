using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        [Display (Name = "InvoiceName")]
        public string InvoiceName { get; set; }
        [Display (Name = "Shipment")]
        public string ShipmentId { get; set;}

        public DateTimeOffset InvoiceDate { get; set; }

        public DateTimeOffset InvoiceDueDate { get;}

        public int InvoiceTypeId { get; set; }
    }
}