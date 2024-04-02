using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240401_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tarefa 1
            //Console.WriteLine("Digite o valor da nota 1:");
            //float nota1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor da nota 2:");
            //float nota2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor da nota 3:");
            //float nota3 = float.Parse(Console.ReadLine());


            //float media = (nota1 + nota2 + nota3) / 3;

            //Console.WriteLine("Suas nota do trimestre é: ");
            //Console.WriteLine("Nota 1: " + nota1);
            //Console.WriteLine("Nota 2: " + nota2);
            //Console.WriteLine("Nota 3: " + nota3);
            //Console.WriteLine("");
            //Console.WriteLine("Sua média é: " + media.ToString("F"));

            //if (media <= 4)
            //{
            //    Console.WriteLine("Você reprovou de ano!");
            //}
            //else if (media < 7)
            //{
            //    Console.WriteLine("Você está de recuperação!");
            //}
            //else
            //{
            //    Console.WriteLine("Parabéns você foi aprovado!");
            //}


            // Tarefa 2
            //Console.WriteLine("Digite o número do mês: ");
            //int mes = int.Parse(Console.ReadLine());

            //switch (mes)
            //{
            //    case (1):
            //        Console.WriteLine("Janeiro");
            //        break;
            //    case (2):
            //        Console.WriteLine("Fevereiro");
            //        break;
            //    case (3):
            //        Console.WriteLine("Março");
            //        break;
            //    case (4):
            //        Console.WriteLine("Abril");
            //        break;
            //    case (5):
            //        Console.WriteLine("Maio");
            //        break;
            //    case (6):
            //        Console.WriteLine("Junho");
            //        break;
            //    case (7):
            //        Console.WriteLine("Julho");
            //        break;
            //    case (8):
            //        Console.WriteLine("Agosto");
            //        break;
            //    case (9):
            //        Console.WriteLine("Setembro");
            //        break;
            //    case (10):
            //        Console.WriteLine("Outubro");
            //        break;
            //    case (11):
            //        Console.WriteLine("Novembro");
            //        break;
            //    case (12):
            //        Console.WriteLine("Dezembro");
            //        break;
            //    default:
            //        Console.WriteLine("Valor incorreto!");
            //        break;
            //}

            //// Tabuada
            //Console.WriteLine("Digite um número para realizar a tabuada:");
            //int numero = int.Parse(Console.ReadLine()); 
            //for (int i = 0; i <= 10; i++)
            //{
            //   Console.WriteLine(i + " x " + numero + " = " + i * numero);
            //}

            // Calculadora
            Console.WriteLine("Calculadora");

            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual operação deseja realizar:");
            Console.WriteLine("");
            Console.WriteLine("(+) - Somar");
            Console.WriteLine("(-) - Subtrair");
            Console.WriteLine("(/) - Divisão");
            Console.WriteLine("(*) - Multiplicação");
            String operacao = Console.ReadLine();

            Console.WriteLine("Digite outro número:");
            int n2 = int.Parse(Console.ReadLine());

            if (operacao == "+")
            {
                Console.WriteLine("A soma do número " +  n1 + " e o número " + n2 + " é: " + (n1 + n2));
            } else if (operacao == "-")
            {
                Console.WriteLine("A subtração do número " + n1 + " e o número " + n2 + " é: " + (n1 - n2));
            } else if (operacao == "/")
            {
                Console.WriteLine("A divisão do número " + n1 + " e o número " + n2 + " é: " + (n1 / n2));
            } else if (operacao == "*")
            {
                Console.WriteLine("A multiplicação do número " + n1 + " e o número " + n2 + " é: " + (n1 * n2));
            } else
            {
                Console.WriteLine("Operação invalida!");
            }
        }
    }
}
