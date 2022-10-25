using byte_bank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_bank_ADM.Utilitário
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.TotalDeBonificacao += diretor.GetBonificacao();

        }
        //public void Registrar(GerenteDeContas gerenteDeContas)
        //{
        //    this.TotalDeBonificacao += gerenteDeContas.GetBonificacao();

        //}

        //public void Registrar(Auxiliar auxiliar)
        //{
        //    this.TotalDeBonificacao += auxiliar.GetBonificacao();

        //}

        //public void Registrar(Designer designer)
        //{
        //    this.TotalDeBonificacao += designer.GetBonificacao();
        //}

    }
}
