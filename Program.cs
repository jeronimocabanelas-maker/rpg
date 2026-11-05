using System;
using System.Collections.Generic;

namespace MissaoRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem("Teste1", 150, 1);
            Console.WriteLine($"Personagem criado com vida 150 -> vida registrada: {p1.Vida}");

            Personagem p2 = new Personagem("Teste2", -20, 1);
            Console.WriteLine($"Personagem criado com vida -20 -> vida registrada: {p2.Vida}");

            Console.WriteLine();

            List<Personagem> equipe = new List<Personagem>()
            {
                new Guerreiro("Thor", 100, 5, "Martelo"),
                new Mago("miranha", 80, 7, "teia"),
                new Guerreiro("thanos", 0, 3, "joias")
            };

            Console.WriteLine("=== PERSONAGENS ===");
            foreach (Personagem hero in equipe)
            {
                hero.Apresentar();
            }

            Console.WriteLine("\n=== BATALHA ===");
            foreach (Personagem hero in equipe)
            {
                hero.Atacar();
            }
        }
    }
}