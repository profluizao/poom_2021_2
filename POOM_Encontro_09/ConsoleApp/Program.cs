using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria c = new Categoria();
            c.CategoriaId = 1;
            c.Descricao = "Teste";
            c.DataDeInsercao = DateTime.Now;

            Console.WriteLine("Teste:");
            Console.WriteLine("ID: {0}", c.CategoriaId);
            Console.WriteLine("Descricao: {0}", c.Descricao);
            Console.WriteLine("Data Insert: {0}", c.DataDeInsercao);

            Console.ReadLine();
        }
    }
}
