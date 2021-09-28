using Entity.Context;
using Entity.Models;
using System;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new();

            Console.WriteLine("Nome do livro:");
            livro.Nome = Console.ReadLine();

            Console.WriteLine("Número de páginas:");
            livro.NumeroPaginas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor R$: ");
            livro.Valor = Convert.ToDouble(Console.ReadLine());

            using (var contexto = new LivroContext())
            {
                contexto.Livros.Add(livro);
                contexto.SaveChanges();
            }

            Console.WriteLine("Livro salvo com sucesso!");
        }
    }
}
