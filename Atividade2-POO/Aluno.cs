using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2_POO
{
    public class Aluno
    {
        public string RA;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        public decimal NotaFinal;

        public void ReceberDados()
        {
            Console.Write("Digite o RA do aluno: ");
            RA = Console.ReadLine();

            Console.Write("Digite o nome do aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a nota da prova: ");
            NotaProva = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a nota do trabalho: ");
            NotaTrabalho = decimal.Parse(Console.ReadLine());
        }

        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }
        public void CalcularNotaFinal()
        {
            if(NotaFinal >= 7)
            {
                Console.WriteLine("Aprovado");
            }else
            {
                Console.WriteLine("Reprovado");
            }
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine("A nota final é: " + NotaFinal);
        }
    }
}
