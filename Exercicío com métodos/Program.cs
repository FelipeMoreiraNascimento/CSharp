using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMethod01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.Write("Nota 1: ");
            aluno1.Notas[0] = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            aluno1.Notas[1] = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            aluno1.Notas[2] = double.Parse(Console.ReadLine());
            Console.Write("Nota 4: ");
            aluno1.Notas[3] = double.Parse(Console.ReadLine());

            Console.WriteLine("Media: " + aluno1.CalcMedia());

            Console.WriteLine(aluno1.ValidaAluno());


            Console.ReadKey();
        }
    }
}
