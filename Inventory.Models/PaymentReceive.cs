using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class PaymentReceive
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int InvoiceId { get; set; }

        public DateTimeOffset DateOfpayment { get; set; }

        public int PaymentTypeId { get; set; }

        public int PaymentAmount { get; set; }

        public bool IsFullPayment { get; set; }
    }
}
