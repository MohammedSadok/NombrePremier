using System;

namespace NombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer un nombre : ");
            var nbrAsString = Console.ReadLine();
            int nbr;
            while (!int.TryParse(nbrAsString, out nbr))
            {
                Console.WriteLine("Ce n'est pas un nombre entier!");
                nbrAsString = Console.ReadLine();
            }

            bool test = false;
            for (int i = 2; i <= nbr / 2 && test == false; i++)
            {
                if (nbr % i == 0)
                    test = true;
            }
            if (test)
                Console.WriteLine(nbr + " est un nombre premier");
            else
                Console.WriteLine(nbr + " n'est pas un nombre premier");
        }
    }
}
