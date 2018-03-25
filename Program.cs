using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---- ESCOLA DO VITORIA RÉGIA----");
            Console.WriteLine();
            Aluno alu = new Aluno();

            Console.Write("Nome do aluno: ");
            alu.nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            alu.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a segunda nota: ");
            alu.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a terceira nota: ");
            alu.nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            alu.SomaDasNotas();

            alu.Aprovacao();
        }
    }
}
