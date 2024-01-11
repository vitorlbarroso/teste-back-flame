﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Entities.Enums
{
    public enum PaymentStatus 
    { 
        Paid, 
        WaitPayment, 
        Chargeback, 
        Refund 
    }
}