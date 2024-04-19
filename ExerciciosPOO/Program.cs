using System.Globalization;
using System.Security.Cryptography;

namespace ExerciciosPOO
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.Nome} é mais velho(a)");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} é mais velho(a)");
            }
        }*/

        #region exercicio2
        /*static void Main(string[] args)
        {
            Funcionarios func1, func2;
            func1 = new Funcionarios();
            func2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (func1.Salario + func2.Salario) /2.0;

            Console.WriteLine("Salário médio: " +salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }*/
        #endregion

        #region exercicio3
        /*static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine(r1);
        }*/
        #endregion

        #region exercicio4
        /*static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f1.Nome + ", $" +f1.SalarioLiquido());
            

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f1.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine(f1);
        }*/
        #endregion

        #region exercicio5
        /* static void Main(string[] args)
         {
             Aluno aluno = new Aluno();

             Console.Write("Nome do Aluno: ");
             aluno.Nome = Console.ReadLine();

             Console.WriteLine();

             Console.Write("Digite as três notas do Aluno: ");
             aluno.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine(aluno);

         }*/
        #endregion

        #region exercicio 6
        /* static void Main(string[] args)
         {

             Console.Write("Entre o número da conta: ");
             int numero = int.Parse(Console.ReadLine());
             Console.Write("Entre o titular da conta: ");
             string titular = Console.ReadLine();
             Console.Write("Haverá deposito inicial? (s/n) ");
             char resp = char.Parse(Console.ReadLine());
             Conta c;

             if (resp == 's' || resp == 'S')
             {
                 Console.Write("Entre o valor de depósito inicial: ");
                 double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 c = new Conta (numero, titular, depositoInicial);
             }
             else
             {

                 c = new Conta(numero, titular);
             }

             Console.WriteLine();
             Console.WriteLine("Dados da conta: ");
             Console.WriteLine(c);

             Console.Write("Entre um valor para deposito: ");
             double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             c.Deposito(quantia);
             Console.WriteLine();
             Console.WriteLine("Dados da conta atualizados: ");
             Console.WriteLine(c);

             Console.Write("Entre um valor para saque: ");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             c.Saque(quantia);
             Console.WriteLine();
             Console.WriteLine("Dados da conta atualizados: ");
             Console.WriteLine(c);
         }*/
        #endregion
        #region exercicio 7
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] array = new Aluguel[10]; //Quartos com posições de 0-9 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1), ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                array[quarto-1] = new Aluguel { Name = name, Email = email};

            }

            for (int i = 0; i < 10; i++) 
            {                
                if (array[i] != null)
                {
                    Console.WriteLine("Quartos Ocupados: ");
                    Console.WriteLine(i+1 + ": " + array[i].Name + ", " + array[i].Email);
                }
            }  
        }
        #endregion
    }
}
