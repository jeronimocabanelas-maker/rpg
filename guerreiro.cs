using System;

namespace MissaoRpg
{
    public class Guerreiro : Personagem
    {
        public string Arma { get; set; }

        public Guerreiro(string nome, int vida, int nivel, string arma)
            : base(nome, vida, nivel)
        {
            Arma = arma;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} | Classe: Guerreiro | Vida: {Vida} | Nível: {Nivel} | Arma: {Arma}");
        }

        public override void Atacar()
        {
            if (Vida <= 0)
            {
                base.Atacar();
            }
            else
            {
                Console.WriteLine($"{Nome} ataca com o {Arma} e causa dano físico!");
            }
        }
    }
}