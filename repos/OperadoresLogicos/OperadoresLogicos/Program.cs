using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = !(2 > 3) || 4 != 5;
            Console.WriteLine("A resposta é: {0}", a);
        }
    }
}
