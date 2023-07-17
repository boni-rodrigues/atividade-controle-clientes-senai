using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_clientes.Classes
{
    internal class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Valor { get; protected set; }
        public double ValorImposto { get; protected set; }
        public double Total { get; protected set; }

        public Clientes()
        {

        }

        public virtual void PagarImposto (double valor)
        {
            Valor = valor;
            ValorImposto = Valor * 0.10;
            Total = Valor + ValorImposto;
        }
    }
}
