using byte_bank_ADM.Funcionarios;
using byte_bank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_bank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao Futuro");
                return true;
            }
            
            Console.WriteLine("Senha incorreta");
            return false;                      
        }
        
    }
}
