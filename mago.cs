using System;

namespace MissaoRpg
{
    public class Mago : Personagem
    {
        public string Elemento { get; set; }

        
        public Mago(string nome, int vida, int nivel, string elemento)
            : base(nome, vida, nivel)
        {
            Elemento = elemento;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} | Classe: Mago | Vida: {Vida} | Nível: {Nivel} | Elemento: {Elemento}");
        }

        public override void Atacar()
        {
            
            if (Vida <= 0)
            {
                base.Atacar();
            }
            else
            {
                Console.WriteLine($"{Nome} lança uma magia de {Elemento}!");
            }
        }
    }
}