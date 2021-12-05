using System;
using DIO_Jogo_RPG_Orientacao_Objeto.Entidades;

namespace DIO_Jogo_RPG_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus();
            hero.Name = "Arus";
            hero.Level = 2;
            hero.HeroType = "Knight";
        }
    }
}
