using System;
using Metodo_Construtor.Classe;

namespace Metodo_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Console.WriteLine($"Código = {produto1.Codigo} / Nome = {produto1.Nome ?? "vazio"} / Descrição = {produto1.Desc ?? "vazio"} / Estoque = {produto1.Estoque}");   

            Console.WriteLine("");
            
            Produto produto2 = new Produto(2,2);
            Console.WriteLine($"Código = {produto2.Codigo} / Nome = {produto2.Nome ?? "vazio"} / Descrição = {produto2.Desc ?? "vazio"} / Estoque = {produto2.Estoque}");
            
            Console.WriteLine("");
            
            Produto produto3 = new Produto(3,"mouse","Isto é um mouse",3);
            Console.WriteLine($"Código = {produto3.Codigo} / Nome = {produto3.Nome ?? "vazio"} / Descrição = {produto3.Desc ?? "vazio"} / Estoque = {produto3.Estoque}");
        }
    }
}
