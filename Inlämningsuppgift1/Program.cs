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
            List<double> sum = new List<double>();
            bool quit = false;

            Console.Title = "Inlämmningsuppgift 1";
            Console.WriteLine("-------------------------");
            Console.WriteLine("  Inlämmningsuppgift 1");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            do
            {

                //Nollställer listan med operatorer så att man kan knappa in en ny beräkning
                if (inputOperator.Count > 0 || inputNumber.Count > 0)
                {
                    inputOperator.Clear();
                    inputNumber.Clear();
                }
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
                
                bool error = default(bool);
                if (inputOperator[0] == '+')
                {
                    if (inputOperator[1] == '+')
                        sum.Add(inputNumber[0] + inputNumber[1] + inputNumber[2]);
                    if (inputOperator[1] == '-')
                        sum.Add(inputNumber[0] + inputNumber[1] - inputNumber[2]);
                    if (inputOperator[1] == '*')
                        sum.Add(inputNumber[0] + inputNumber[1] * inputNumber[2]);
                    if (inputOperator[1] == '/')
                    {
                        if (inputNumber[2] == 0)
                        {
                            Console.WriteLine("Du kan inte dela med 0");
                            error = true;
                        }
                        else
                            sum.Add(inputNumber[0] + inputNumber[1] / inputNumber[2]);
                    }
                }

                if (inputOperator[0] == '-')
                {
                    if (inputOperator[1] == '+')
                        sum.Add(inputNumber[0] - inputNumber[1] + inputNumber[2]);
                    if (inputOperator[1] == '-')
                        sum.Add(inputNumber[0] - inputNumber[1] - inputNumber[2]);
                    if (inputOperator[1] == '*')
                        sum.Add(inputNumber[0] - inputNumber[1] * inputNumber[2]);
                    if (inputOperator[1] == '/')
                    {
                        if (inputNumber[2] == 0)
                        {
                            Console.WriteLine("Du kan inte dela med 0");
                            error = true;
                        }
                        else
                            sum.Add(inputNumber[0] - inputNumber[1] / inputNumber[2]);
                    }
                }

                if (inputOperator[0] == '*')
                {
                    if (inputOperator[1] == '+')
                        sum.Add(inputNumber[0] * inputNumber[1] + inputNumber[2]);
                    if (inputOperator[1] == '-')
                        sum.Add(inputNumber[0] * inputNumber[1] - inputNumber[2]);
                    if (inputOperator[1] == '*')
                        sum.Add(inputNumber[0] * inputNumber[1] * inputNumber[2]);
                    if (inputOperator[1] == '/')
                    {
                        if (inputNumber[2] == 0)
                        {
                            Console.WriteLine("Du kan inte dela med 0");
                            error = true;
                        }
                        else
                            sum.Add(inputNumber[0] * inputNumber[1] / inputNumber[2]);
                    }
                }

                if (inputOperator[0] == '/')
                {
                    if (inputNumber[1] != 0)
                    {
                        if (inputOperator[1] == '+')
                            sum.Add(inputNumber[0] / inputNumber[1] + inputNumber[2]);
                        if (inputOperator[1] == '-')
                            sum.Add(inputNumber[0] / inputNumber[1] - inputNumber[2]);
                        if (inputOperator[1] == '*')
                            sum.Add(inputNumber[0] / inputNumber[1] * inputNumber[2]);
                        if (inputOperator[1] == '/')
                        {
                            if (inputNumber[2] == 0)
                            {
                                Console.WriteLine("Du kan inte dela med 0");
                                error = true;
                            }
                            else
                                sum.Add(inputNumber[0] / inputNumber[1] / inputNumber[2]);
                        }
                    }
                    else
                        Console.WriteLine("Du kan inte dela med 0");
                }

                if (!error)
                {
                    int counter = sum.Count - 1;
                    Console.Write("{0}{1}{2}{3}{4} = {5}", inputNumber[0], inputOperator[0], inputNumber[1], inputOperator[1], inputNumber[2], sum[counter]);
                    Console.WriteLine();
                    if(sum[counter] < 100)
                        Console.WriteLine("Less then a hundred");
                    else if (sum[counter] > 100)
                        Console.WriteLine("More then a hundred");
                    else
                        Console.WriteLine("Cool, now you have a hundred, clap clap");

                    Console.ReadKey();
                }
                
                error = false;
                
                do
                {
                    Console.Write("Vill du göra en ny uträkning? j/n:");
                    char quitChoice = Convert.ToChar(Console.ReadLine());
                    switch (quitChoice)
                    {
                        case 'j':
                            quit = default(bool);
                            error = false;
                            break;
                        case 'n':
                            quit = true;
                            error = false;
                            break;
                        default:
                            error = true;
                            break;
                    }
                } while (error);
                error = false;
                Console.Clear();
            } while (!quit);
            

            double summa = default(double);
            for (int i = 0; i < sum.Count; i++)
            {
                summa += sum[i];
            }
            
            Console.WriteLine("\nDen totala summan av alla uträkningar blev: {0}", summa);
            Console.ReadKey();

        }
    }
}
