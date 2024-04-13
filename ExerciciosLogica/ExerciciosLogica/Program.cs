using System.Globalization;

namespace ExerciciosLogica
{
    internal class Program
    {
        #region exercicio1
        /*static void Main(string[] args)
        {
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos. 
            int n1, n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine("SOMA: " +soma);
        }*/

        #endregion

        #region exercicio2
        /* static void Main(string[] args)
         {
             Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
             casas decimais conforme exemplos.

             double raio = double.Parse(Console.ReadLine());

             double area = 3.14159 * raio * raio;

             Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
         }*/
        #endregion

        #region exercicio3
        /*static void Main(string[] args)
        {
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
              de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int A,B,C,D;
            Console.Write("Digite um valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            D = int.Parse(Console.ReadLine());

            int diferenca = (A * B) - (C * D);
            Console.WriteLine("DIFERENCA: " +diferenca);
        }*/
        #endregion

        #region exercicio4
        /*static void Main(string[] args)
        {
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.

            int numFunc, horasTrab;
            double valorHoras, salario;

            Console.Write("Digite o numero do funcionário: ");
            numFunc = int.Parse(Console.ReadLine());

            Console.Write("Digite as horas trabalhadas: ");
            horasTrab = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que recebe por hora: ");
            valorHoras = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrab * valorHoras;

            Console.WriteLine($"NUMBER: {numFunc}\nSALARY: U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }*/
        #endregion

        #region exercicio5
        /*static void Main(string[] args)
        {
           Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
           código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. 

            int codP1, codP2, numP1, numP2; 
            double valorP1, valorP2, total;

            Console.WriteLine("Digite o código da peça 1, a quantidade de peças, o valor de cada unidade: ");

            string[] peca1 = Console.ReadLine().Split(' ');
            codP1= int.Parse(peca1[0]);
            numP1 = int.Parse(peca1[1]);
            valorP1 = int.Parse(peca1[2]);

            Console.WriteLine("Digite o código da peça 2, a quantidade de peças, o valor de cada unidade: ");

            string[] peca2 = Console.ReadLine().Split(' ');
            codP2 = int.Parse(peca2[0]);
            numP2 = int.Parse(peca2[1]);
            valorP2 = int.Parse(peca2[2]);

            total = numP1 * valorP1 + numP2 * valorP2;
            Console.WriteLine("VALOR A PAGAR: R$" +total.ToString("F2", CultureInfo.InvariantCulture));
        }*/
        #endregion

        #region exercicio6
        /*static void Main(string[] args)
        {
            Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.

            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            Console.WriteLine("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());

            areaTriangulo = (A * A) * C;
            areaCirculo = 3.14159 * C * C;
            areaTrapezio = (A + B) * C / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}\nCIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}\nTRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\nQUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\nRETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
         }*/
        #endregion

        #region exercicio1
        /*static void Main(string[] args)
        {
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            } else
            {
                Console.WriteLine("NEGATIVO");
            }
        }*/
        #endregion

        #region exercicio2
        /*static void Main(string[] args)
        {
            Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0 ) {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            
        }*/
        #endregion

        #region exercicio3
        /*static void Main(string[] args)
        {
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ordem crescente ou decrescente.

            Console.WriteLine("Digite o valor de A e B: ");
            string[] valores = Console.ReadLine().Split(' ');
            int a, b;
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NAO MULTIPLOS");
            }
        }*/
        #endregion

        #region exercicio4
        /*static void Main(string[] args)
        {
            Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Console.WriteLine("Digite a hora inicial e final do jogo: ");
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial, horaFinal, duracaoJogo;
            horaInicial = int.Parse(horas[0]);
            horaFinal = int.Parse(horas[1]);

            if (horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;
            }
            else
            {
                duracaoJogo = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {duracaoJogo} horas");

        }*/
        #endregion

        #region exercicio5
        static void Main(string[] args)
        {
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.*/

            string[] valores = Console.ReadLine().Split(' ');
            int cod, quant;
            cod = int.Parse(valores[0]);
            quant = int.Parse(valores[1]);
            double total;
            if (cod == 1)
            {
                total = 4.00 * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 2)
            {
                total = 4.50 * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 3)
            {
                total = 5.00 * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 4)
            {
                total = 2.00 * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 5)
            {
                total = 1.50 * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Digite um valor válido");
            }
        }
        #endregion

        #region exercicio6
        /*static void Main (string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine()); 

            if (n1 >= 0 || n1 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n1 > 25 || n1 <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if ( n1 > 50 || n1 <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (n1 > 75 || n1 <= 100)
            {

                Console.WriteLine("Intervalo [75,100]");
            } else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }*/
        #endregion

        #region exercicio7
        static void Main (string[] args)
        {
            double x, y;
            Console.WriteLine("Digite o valor de X e Y: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = double.Parse(coordenadas[0]);
            y = double.Parse(coordenadas[1]);



        }
        #endregion
    }
}
