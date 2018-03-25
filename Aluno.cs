using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3, notafinal;

        public void SomaDasNotas()
        {
            notafinal = nota1 + nota2 + nota3;
        }

        public void Aprovacao()
        {
            if(notafinal >= 60.00)
            {
                Console.WriteLine("NOTA FINAL: {0}", notafinal);
                Console.WriteLine("AROVADO!!");
                Console.ReadLine();
            }
            else
            {
                double val;
                val = 60.00 - notafinal;
                Console.WriteLine("NOTA FINAL: {0}", notafinal);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "+ val + " pontos");
                Console.ReadLine();
            }
        }
    }
}
