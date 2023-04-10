using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class PaymentVoucher
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public int BillId { get; set; }

        public DateTimeOffset PaymentDate { get; set; }

        public int PaymentTypeId { get; set; }

        public int PaymentAmount { get; set; }

        public int CashBankId { get; set; }

        public bool IsFullPayment { get; set; }

    }
}
