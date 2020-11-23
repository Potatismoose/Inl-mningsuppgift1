using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> inputOperator = new List<char>();
            List<double> inputNumber = new List<double>();
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
                //ber användaren ange 3 st tal som sparas till en lista
                Console.Write("Ange det första talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ange det andra talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ange det tredje talet: ");
                inputNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();

                //Om första operatorn är + så körs ifsatsen nedan
                bool error = default(bool);
                if (inputOperator[0] == '+')
                {
                    //Vilken av följande uträkningar som utförs beror på vad den andra operatorn är satt till
                    if (inputOperator[1] == '+')
                        sum.Add(inputNumber[0] + inputNumber[1] + inputNumber[2]);
                    if (inputOperator[1] == '-')
                        sum.Add(inputNumber[0] + inputNumber[1] - inputNumber[2]);
                    if (inputOperator[1] == '*')
                        sum.Add(inputNumber[0] + inputNumber[1] * inputNumber[2]);
                    if (inputOperator[1] == '/')
                    {
                        //Om tal nr 3 är satt till 0 så kommer ett felmeddelande om att division med 0 inte är möjlig.
                        if (inputNumber[2] == 0)
                        {
                            Console.WriteLine("Du kan inte dela med 0");
                            error = true;
                        }
                        else
                            sum.Add(inputNumber[0] + inputNumber[1] / inputNumber[2]);
                    }
                }

                //Om första operatorn är - så körs ifsatsen nedan
                if (inputOperator[0] == '-')
                {
                    //Vilken av följande uträkningar som utförs beror på vad den andra operatorn är satt till
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

                //Om första operatorn är * så körs ifsatsen nedan
                if (inputOperator[0] == '*')
                {
                    //Vilken av följande uträkningar som utförs beror på vad den andra operatorn är satt till
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

                //Om första operatorn är / så körs ifsatsen nedan
                if (inputOperator[0] == '/')
                {
                    //Här behöver vi kolla så att tal nr 1 ELLER 2 inte är en 0:a, i annat fall ska felmeddelande skrivas ut.
                    if (inputNumber[1] != 0 || inputNumber[0] != 0)
                    {
                        //Vilken av följande uträkningar som utförs beror på vad den andra operatorn är satt till
                        if (inputOperator[1] == '+')
                            sum.Add(inputNumber[0] / inputNumber[1] + inputNumber[2]);
                        if (inputOperator[1] == '-')
                            sum.Add(inputNumber[0] / inputNumber[1] - inputNumber[2]);
                        if (inputOperator[1] == '*')
                            sum.Add(inputNumber[0] / inputNumber[1] * inputNumber[2]);
                        if (inputOperator[1] == '/')
                        {
                            //Om tal nr 3 är satt till 0 så kommer ett felmeddelande om att division med 0 inte är möjlig.
                            if (inputNumber[2] == 0)
                            {
                                Console.WriteLine("Du kan inte dela med 0");
                                error = true;
                            }
                            else
                                sum.Add(inputNumber[0] / inputNumber[1] / inputNumber[2]);
                        }
                    }
                    //Om talet blir division med 0
                    else
                        Console.WriteLine("Du kan inte dela med 0");
                }

                //Om inget fel funnet så skrivs talet och beräkningen ut
                if (!error)
                {
                    
                    int counter = sum.Count - 1;
                    Console.Write("{0}{1}{2}{3}{4} = {5}", inputNumber[0], inputOperator[0], inputNumber[1], inputOperator[1], inputNumber[2], sum[counter]);
                    Console.WriteLine();

                    //Ifsats som kontrollerar om talet är 100, mindre än 100 eller mer än 100 och skriver ut meddelandet
                    if(sum[counter] < 100)
                        Console.WriteLine("Less then a hundred");
                    else if (sum[counter] > 100)
                        Console.WriteLine("More then a hundred");
                    else
                        Console.WriteLine("Cool, now you have a hundred, clap clap");

                    Console.ReadKey();
                }
                
                error = false;
                //Medan error är true så frågas om man vill göra en ny uträkning., annars
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
                //Om användaren valt att avsluta så kommer loopen brytas här
            } while (!quit);
            
            //Summan av alla resultat kommer här att loopas igenom och skrivas ut.
            double summa = default(double);
            for (int i = 0; i < sum.Count; i++)
            {
                summa += sum[i];
            }
            
            Console.WriteLine("\nDen totala summan av alla uträkningar blev: {0}", summa);
            //Ifsats som kontrollerar om talet är 100, mindre än 100 eller mer än 100 och skriver ut meddelandet
            if (summa < 100)
                Console.WriteLine("Less then a hundred");
            else if (summa > 100)
                Console.WriteLine("More then a hundred");
            else
                Console.WriteLine("Cool, now you have a hundred, clap clap");

            
            Console.ReadKey();

        }
    }
}