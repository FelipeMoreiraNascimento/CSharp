using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMethod01
{
    internal class Aluno
    {
        public double[] Notas = new double [4];
        public double Media;
        public double Exame;
        public double CalcMedia()
        {
            Media += ((Notas[0] * 2) + (Notas[1] * 3) + (Notas[2] * 4) + (Notas[3] * 1)) / 10;
            return Media;
        }

        public double ValidaAluno()
        {
            if (Media >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado.");
            }
            else if (Media < 5.0)
            {
                Console.WriteLine("Aluno reprovado!");
            }
            else if (Media > 5.0 || Media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                Exame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + Exame);
                Media = (Exame + Media) / 2;
                if (Media > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                   
                }
            }
            return Media;
        }
    }
}
