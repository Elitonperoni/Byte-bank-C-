﻿using byte_bank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_bank_ADM.SistemaInterno
{
    public interface IAutenticavel  
    {
        public string Senha { get; set; }

        public abstract bool Autenticar(string senha);      
     
    }
}
