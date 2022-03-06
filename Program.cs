using System;
using DesafioDioJogoRPG.Entities;

namespace DesafioDioJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Witcher Witcher = new Witcher("Geralt", 48, "bruxo");
            Sorcerers Sorcerers = new Sorcerers("Yennefer", 70, "feiticeira");

            Console.WriteLine(Witcher.ToString());
            Console.WriteLine(Sorcerers.ToString());

            Console.WriteLine($"O poder do {Witcher.Name} é {Witcher.Actions()}");
            Console.WriteLine($"O poder do {Sorcerers.Name} é {Sorcerers.Actions()}");

            Console.ReadKey();
        }
    }
}
