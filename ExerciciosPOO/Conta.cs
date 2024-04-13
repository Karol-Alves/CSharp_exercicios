using System.Globalization;

namespace ExerciciosPOO
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; private set; } 

        public Conta( int numeroconta, string nome)
        {
            NomeCliente = nome;
            NumeroConta = numeroconta;
        }
        public Conta(int numeroconta, string nome, double depositoInicial) : this (numeroconta,nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;  
        }

        public void Saque (double quantia) 
        {
          
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta
                + ", Titular: " + NomeCliente
                + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
