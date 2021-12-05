using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Jogo_RPG_Orientacao_Objeto.Entidades
{
    public class Arus
    {
        //construtor
        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public string HeroType { get; set; }
      
    }
}
