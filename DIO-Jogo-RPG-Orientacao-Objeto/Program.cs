using System;
using DIO_Jogo_RPG_Orientacao_Objeto.Entidades;

namespace DIO_Jogo_RPG_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero knight = new Knight("Arus", 42, "Knight", 469, 72);

            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 292, 89);

            Wizard whiteWizard = new Wizard("Jennica", 42, "White Wizard", 325, 474);

            Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 106, 611);

            
            Console.WriteLine(knight);
            Console.WriteLine(knight.Attack());
            Console.WriteLine();

            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack());
            Console.WriteLine();

            Console.WriteLine(whiteWizard);
            Console.WriteLine(whiteWizard.Attack(1));
            Console.WriteLine(whiteWizard.Attack(9));
            Console.WriteLine();

            Console.WriteLine(blackWizard);
            Console.WriteLine(blackWizard.Attack(3));
            Console.WriteLine(blackWizard.Attack(7));
            Console.WriteLine();
        }
    }
}
