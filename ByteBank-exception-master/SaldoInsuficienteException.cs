﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_exception_master
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem):base(mensagem)
        {
            
        }
    }
}
