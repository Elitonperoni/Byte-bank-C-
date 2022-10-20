// using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo += value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo
                -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
