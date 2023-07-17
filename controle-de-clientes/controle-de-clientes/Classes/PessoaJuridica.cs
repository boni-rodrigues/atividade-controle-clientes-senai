using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_clientes.Classes
{
    internal class PessoaJuridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE {get; set;}

        public PessoaJuridica() { } 

        public PessoaJuridica(string nome, string endereco, string cnpj, string ie, double valorCompra)
        {
            Nome = nome;
            Endereco = endereco;
            CNPJ = cnpj;
            IE = ie;
            Valor = valorCompra;
        }

        public override void PagarImposto(double valor)
        {
            Valor = valor;
            ValorImposto = Valor * 0.20;
            Total = Valor + ValorImposto;
        }

        public override string ToString()
        {
            return $"Confirmação dos dados da empresa: \n\n Nome: {Nome} \n Endereço: {Endereco} \n CNPJ: {CNPJ} \n Inscrição Estadual: {IE} \n Valor do produto: {Valor.ToString("C")} \n Valor em impostos: {ValorImposto.ToString("C")} \n Total: {Total.ToString("C")}.";
        }
    }
}
