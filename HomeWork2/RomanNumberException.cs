﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}
