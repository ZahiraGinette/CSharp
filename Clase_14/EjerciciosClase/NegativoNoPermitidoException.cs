﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{ 
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string message) : base(message)
        {
        }
    }
}
