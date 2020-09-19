using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class Payment
    {
        public string PaymentId { get; set; }
        public string Due { get; set; }
        public string Paid { get; set; }
        public string Balance { get; set; }
        public string PaymentDueDate { get; set; }
        public string PaymentDate { get; set; }
        public string TenantId { get; set; }
    }
}
