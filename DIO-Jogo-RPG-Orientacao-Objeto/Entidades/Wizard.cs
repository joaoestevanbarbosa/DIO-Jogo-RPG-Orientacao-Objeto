using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Jogo_RPG_Orientacao_Objeto.Entidades
{
    public class Wizard : Hero //herança => herdando da classe pai Hero
    {
        //construtor
        public Wizard(string Name, int Level, string HeroType, int HitPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
            this.ManaPoints = ManaPoints;
        }
              

        public override string Attack () //polimorfismo 1 devido ao virtual/override
        {
            return this.Name + "lançou magia";
        }

        public string Attack(int Bonus) //polimorfismo 2, outra maneira de chamar o attack
        {

            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com Bonus de dano no valor de " + Bonus;
            }
            else 
            {
                return this.Name + " lançou magia com força fraca com Bonus de dano no valor de " + Bonus;
            }

            
        }
    }
}
