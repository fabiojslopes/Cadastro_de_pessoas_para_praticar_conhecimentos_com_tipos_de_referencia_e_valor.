using System;
using Cadastro_Pessoa.Class;

namespace Cadastro_Pessoa
{
    class Program
    {
        static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ricardo";
            p1.Idade = 30;
            p1.Documento = "12312312399";

            TrocarNome(p1, "Fábio");
                
            Console.WriteLine($"O novo nome é: {p1.Nome}.");
        }
    }
}