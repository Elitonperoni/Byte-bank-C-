using byte_bank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_bank_ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get ; set ; }
       
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
