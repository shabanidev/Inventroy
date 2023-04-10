using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class RecivedNote
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PurchaseOrderId { get; set; }

        public DateTimeOffset GRNDate { get; set; }

        public int VendorNumber { get; set; }
        public int VendorInvoiceNumber { get; set; }

        public int WarehouseId { get; set; } 

        public bool IsFullReceive { get; set; }

    }
}
