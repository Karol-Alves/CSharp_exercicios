using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosPOO
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario()
        {
            double aumento = SalarioBruto * (Porcentagem / 100.0);
            SalarioBruto += aumento;

        }

        public override string ToString()
        {
            AumentarSalario();
            return "Dados atualizados: " + Nome + ", $" + SalarioLiquido();
        }
    }
}

