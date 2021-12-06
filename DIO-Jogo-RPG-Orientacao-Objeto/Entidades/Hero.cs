using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Jogo_RPG_Orientacao_Objeto.Entidades
{
    public abstract class Hero //abstração para que somente tenha uma "forma", algo "parecido" com a interface
    {

        public string Name { get; set; }

        public int Level { get; set; }

        public string HeroType { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; } 

        //construtor
        public Hero (string Name, int Level, string HeroType, int HitPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
            this.ManaPoints = ManaPoints;
        }
        public Hero()
        {

        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.HeroType}, {this.HitPoints}, {this.ManaPoints} ";
        }
      
        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada";
        }
    }
}
