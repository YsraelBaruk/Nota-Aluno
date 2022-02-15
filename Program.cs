using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;

            double result;

            Console.WriteLine("Digite a primeira nota do aluno");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno");
            nota2 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Digite a terceira nota do aluno");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota do aluno");
            nota4 = Convert.ToDouble(Console.ReadLine());
;
            result = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Digite o nome do aluno - ");
            string nome = Console.ReadLine();

            Console.WriteLine($"A média do aluno {nome} : {result}");

            if (result <= 5)
            {
                Console.WriteLine($"{nome} infelizmente você está reprovado");
            }
            else if (result <= 7)
            {
                Console.WriteLine($"Cuidado {nome} você está de recuperação");
            }
            else
            {
                Console.WriteLine($"Parabéns {nome} você foi aprovado");
            }

            Console.ReadKey();
        }
    }
}
