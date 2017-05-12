using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoicePdf.Core.Model
{
    class Invoice
    {
        public string InvoiceTypeCode { get; set; }
        public string ID { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal TaxAmount { get; set; }
        public string Note { get; set; }



    }
}
