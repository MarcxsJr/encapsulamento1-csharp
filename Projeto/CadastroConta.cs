using System.Globalization;
namespace Projeto
{
    class CadastroConta
    {
        public int N_Conta { get; private set; }
        public string T_conta;
        public double S_conta { get; private set;}
        public CadastroConta(int n_conta, string t_conta, double dp_inicial)
        {
            N_Conta = n_conta;
            T_conta = t_conta;
            S_conta = dp_inicial;
        }
        public void Deposito(double deposito)
        {
            S_conta += deposito;
        }
        public void Saque(double saque)
        {
            S_conta = S_conta - saque - 5;
        }
        public override string ToString()
        {
            return "Conta "
                + N_Conta
                + ", Titular: "
                + T_conta
                + ", Saldo: $"
                + S_conta.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}