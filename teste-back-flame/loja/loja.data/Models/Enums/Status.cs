using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Models.Enums
{
    public enum Status 
    { 
        Paid, 
        WaitPayment, 
        Chargeback, 
        Refund 
    }
}
