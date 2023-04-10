using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        [Display (Name = "Bill / InvoiceNumber")]

        public string BillName { get; set;}
        [Display(Name = "GRN")]
        public string GoodReciveNoteId { get; set;}

        [Display(Name = "Vendor Delivery Order")]

        public string VendorDoNumber { get; set;}
        [Display(Name = "Vendor Bill/ Invoice")]
        public string VendorInvoiceNumber { get; set;}

        [Display(Name = "Vendor Bill/ Invoice")]

        public DateTimeOffset BillDate { get; set;}

        [Display(Name = "Bill due date")]

        public DateTimeOffset BillDueDate { get;}

        [Display(Name = " Bill Type")]
        public int BillTypeId { get; set;}
    }
}
