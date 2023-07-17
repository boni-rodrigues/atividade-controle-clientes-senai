using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace controle_de_clientes.Classes
{
    internal class PessoaFisica : Clientes
    {
        public string CPF { get; set; }
        public string RG { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, string endereco, string cpf, string rg, double valorCompra)
        {
            Nome = nome;
            Endereco = endereco;
            CPF = cpf;
            RG = rg;
            Valor = valorCompra;
        }

        public override string ToString()
        {
            return $"Confirmação dos dados do cliente: \n\n Nome: {Nome} \n Endereço: {Endereco} \n CPF: {CPF} \n RG: {RG} \n Valor do produto: {Valor.ToString("C")} \n Valor em impostos: {ValorImposto.ToString("C")} \n Total: {Total.ToString("C")}.";
        }
    }
}

