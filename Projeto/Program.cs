using Projeto;
using System;
using System.Globalization;
/* -Cadastro de conta bancária

. Número da conta ok
. Nome do titular da conta ok
. Valor depósito inicial (opcional) ok

obs: número da conta não altera ok / nome do titular altera ok / saldo da conta não altera ok 
/ saldo só aumenta com depositos e diminui com saques ok

obs: para cada saque o banco cobra uma taxa de $5,00 ok/ conta pode ficar negativa ok
*/

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadastro de conta
            Console.Write("Entre o número da conta: ");
            int n_Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string t_conta = Console.ReadLine();
            //Depósito inicial
            Console.Write("Haverá depósito inicial (s/n)? ");
            string dp_se = Console.ReadLine();
            double dp_inicial = 0;
            if (dp_se == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                dp_inicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            else if (dp_se == "n")
            {
                dp_inicial = 0;
            }
            else
            {
                Console.WriteLine("Dígito inválido");
            }
            //chamada de classe
            CadastroConta cC = new CadastroConta(n_Conta,t_conta,dp_inicial);
            //Primeira consulta
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(cC);
            //Primeiro Depósito
            Console.Write("Entre um valor para dépósito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cC.Deposito(deposito);
            //Segunda consulta
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cC);
            //Primeiro saque
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cC.Saque(saque);
            //Terceira consulta
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cC);
            Console.ReadLine();
        }
    }
}