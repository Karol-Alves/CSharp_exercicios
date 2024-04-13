using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosPOO
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double PontosParaAprovacao()
        {
            return 60.0 - NotaFinal(); 
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60.00) {
                return  "NOTA FINAL = " +NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\n"
                    +"APROVADO";
            }
            else
            {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\n"
                    + "REPROVADO " + "\n"
                    + "FALTARAM " + PontosParaAprovacao().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
