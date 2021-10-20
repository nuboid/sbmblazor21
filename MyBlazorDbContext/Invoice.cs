using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDbContext
{
    public class Invoice
    {
        public string Id { get; set; }

        public Int32 InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; }
    }
}
