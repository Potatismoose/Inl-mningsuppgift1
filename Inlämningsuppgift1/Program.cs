using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> inputOperator = new List<char>();
            List<int> inputNumber = new List<int>();
            bool quit = false;

            do
            {
                Console.Title = "Inlämmningsuppgift 1";
                Console.WriteLine("-------------------------");
                Console.WriteLine("  Inlämmningsuppgift 1");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                //Nollställer listan med operatorer så att man kan knappa in en ny beräkning
                if (inputOperator.Count > 0)
                    inputOperator.Clear();
                //ber användaren ange första operatorn och sparar den till listan
                Console.Write("Ange första operatorn (+,-,* eller /): ");
                inputOperator.Add(Convert.ToChar(Console.ReadLine()));
                //ber användaren ange andra operatorn och sparar den till listan
                Console.Write("Ange den andra operatorn (+,-,* eller /): ");
                inputOperator.Add(Convert.ToChar(Console.ReadLine()));
                Console.Write("Ange det första talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ange det andra talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ange det tredje talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
                for (int i = 0; i < inputOperator.Count; i++)
                {
                    Console.WriteLine("operator " + (i+1) + " = " + inputOperator[i]);

                }

                for (int i = 0; i < inputNumber.Count; i++)
                {
                    Console.WriteLine("Tal " + (i + 1) + " = " + inputNumber[i]);

                }



                Console.WriteLine();
                Console.ReadKey();
            } while (!quit);



        }
    }
}
