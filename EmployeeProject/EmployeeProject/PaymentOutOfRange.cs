﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    class PaymentOutOfRange : Exception
    {
        public PaymentOutOfRange(string message) : base(message)
        {

        }
    }
}
