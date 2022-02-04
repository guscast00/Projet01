// See https://aka.ms/new-console-template for more information

namespace Projet01
{
    class Program
    {
        static void Main()
        {
            int a = 5, b = 10, c =2;
            Console.WriteLine("\n Avant= a:" + a + "\n b:" + b + "\n c:" + c );
            int tmp = b;
            b = a;
            a = tmp;
            tmp = c;
            c = a;
            a = tmp;

            Console.WriteLine("\n Apres = a:" + a + "\n b:" + b + "\n c:" + c );
        }
    }
}