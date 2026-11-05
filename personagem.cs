using System;

namespace MissaoRpg
{
    public class Personagem
    {
        private string nome;
        private int vida;
        private int nivel;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    
        public int Vida
        {
            get { return vida; }
            set
            {
                if (value < 0)
                {
                    vida = 0;
                }
                else if (value > 100)
                {
                    vida = 100;
                }
                else
                {
                    vida = value;
                }
            }
        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

    
        public Personagem(string nome, int vida, int nivel)
        {
            Nome = nome;
            Vida = vida; 
            Nivel = nivel;
        }

        
        public virtual void Apresentar()
        {
            Console.Write($"Nome: {Nome} | Vida: {Vida} | Nível: {Nivel}");
        }

        
        public virtual void Atacar()
        {
        
            if (Vida <= 0)
            {
                Console.WriteLine($"{Nome} está sem vida e não pode atacar.");
            }
        }
    }
}