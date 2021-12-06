using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Jogo_RPG_Orientacao_Objeto.Entidades
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, string HeroType, int HitPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
            this.ManaPoints = ManaPoints;
        }

        public override string Attack()
        {
            return this.Name + " atacou com estrela ninja";
        }
    }
}
