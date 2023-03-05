namespace _1_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////// The program for calculating the country's budget \\\\\\\\\\\\\\\\\\\\\\\\\\

            long bud = 20000000000;
            int Defenseperc = 20;
            int ministrytechno = 10;

            Console.WriteLine("Budget of government  :" + bud);
            Console.WriteLine("\nMinistry of Defense :" + bud * Defenseperc / 100);
            Console.WriteLine("\nMinistry of Techno  :" + bud * ministrytechno / 100);
            Console.WriteLine("Remain : " + (bud - (bud * Defenseperc / 100) - (bud * ministrytechno / 100)));







        }
    }
}