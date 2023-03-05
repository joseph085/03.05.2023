using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////   Program for calculating cargo orders   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            string firstshoesname = "adidas";
            int firstcount = 4;
            int firstshoesprice = 200;
            int firsttotal = firstcount * firstshoesprice;

            string secondshoesname = "gucci";
            int secondcount = 2;
            int secondshoesprice = 1000;
            int secondtotal = secondcount * secondshoesprice;

            string thirdshoesname = "nike";
            int thirdcount = 1;
            int thirdshoesprice = 150;
            int thirdtotal = thirdcount * thirdshoesprice;

            Console.Write("Ayaqqabı adı :" + firstshoesname);
            Console.writeline("Sayı :" + firstcount);
            Console.writeline("Ayyaqabinin qiymeti :" + firstshoesprice);
            Console.writeline("Umumi qiymeti :" + firsttotal);

            Console.writeline("");

            Console.writeline("Ayaqqabı adı :" + secondshoesname);
            Console.writeline("Sayı :" + secondcount);
            Console.writeline("Ayyaqabinin qiymeti :" + secondshoesprice);
            Console.writeline("Umumi qiymeti :" + secondtotal);

            Console.writeline("");
           
            Console.writeline("Ayaqqabı adı :" + thirdshoesname);
            Console.writeline("Sayı :" + thirdcount);
            Console.writeline("Ayyaqabinin qiymeti :" + thirdshoesprice);
            Console.Writeline("Umumi qiymeti :" + thirdtotal);
        }
    }
}