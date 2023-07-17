using controle_de_clientes.Classes;
using System.Globalization;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, sebem bem-vindo(a)! \n\n Para prosseguir com o cadastro do cliente, digite (F) para Pessoa Física ou (J) para Pessoa Jurídica: ");
            string tipoPessoa = Console.ReadLine();
            Console.WriteLine();

            if(tipoPessoa == "F" || tipoPessoa == "f")
            {
                Console.WriteLine("Certo, será um cliente pessoa física.");
                Console.WriteLine();
                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite agora o endereço do cliente (Contendo CEP, nome da rua/avenida, numero da casa/condomínio): ");
                string endereco = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o CPF do cliente: ");
                string cpf = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ótimo, agora digite por favor o RG do cliente: ");
                string rg = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Por fim, digite o valor da compra desse cliente: ");
                double valorCompra = double.Parse(Console.ReadLine());
                valorCompra.ToString("F2", CultureInfo.InvariantCulture);

                Console.WriteLine();

                PessoaFisica pessoaFisica = new PessoaFisica(nome, endereco, cpf, rg, valorCompra);
                pessoaFisica.PagarImposto(valorCompra);

                Console.WriteLine(pessoaFisica);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Certo, será um cliente pessoa jurídica.");
                Console.WriteLine();
                Console.Write("Digite o nome fantasia da empresa: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite agora o endereço da empresa (Contendo CEP, nome da rua/avenida, numero da casa/condomínio): ");
                string endereco = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o CNPJ da empresa: ");
                string cnpj = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ótimo, agora digite por favor a incrição estadual: ");
                string ie = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Por fim, digite o valor da compra dessa empresa: ");
                double valorCompra = double.Parse(Console.ReadLine());

                Console.WriteLine();

                PessoaJuridica pessoaJuridica = new PessoaJuridica(nome, endereco, cnpj, ie, valorCompra);
                pessoaJuridica.PagarImposto(valorCompra);

                Console.WriteLine(pessoaJuridica);
                Console.WriteLine();
            }
        }
    }
}
