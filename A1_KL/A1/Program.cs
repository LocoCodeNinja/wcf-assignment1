using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A1Reference.A1ServiceClient client = new A1Reference.A1ServiceClient();

            bool active = true;
            string n1, n2, n3, n4, n5, result;
            int value;
            while (active)
            {
                Console.WriteLine("Please select an option");

                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");

                string menu = Console.ReadLine();
                int selection = Convert.ToInt32(menu);

                switch (selection)
                {
                    case 1:
                        //Prime number 
                        Console.WriteLine("Enter Number: ");
                        n1 = Console.ReadLine();
                        if (client.IsInt(n1))
                        {
                            value = Int32.Parse(n1);
                            result = client.PrimeNumber(value);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");                  
                        }
                        Console.ReadLine();
                        break;

                    case 2:
                        //Sum of digits
                        Console.WriteLine("Enter Number 1: ");
                        n1 =(Console.ReadLine());
                        if (client.IsInt(n1))
                        {
                            Console.WriteLine("Enter Number 2: ");
                            n2 = (Console.ReadLine());
                            if (client.IsInt(n2))
                            {
                                //add
                            }
                        }
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();

                        break;

                    case 3:
                        //Reverse a string 
                        Console.WriteLine("Enter a string: ");
                        n1 = (Console.ReadLine());
                        //reverse string
                        break;


                    case 4:
                        //Print HTML tags 
                        Console.WriteLine("Enter Tag: ");
                        n1 = (Console.ReadLine());
                        Console.WriteLine("Enter Data: ");
                        n2 = (Console.ReadLine());
                        //output <tag><data></tag>
                        break;


                    case 5:
                        //Sort 5 numbers 
                        Console.WriteLine("Enter Number 1: ");
                        n1 = (Console.ReadLine());
                        if (client.IsInt(n1))
                        {
                            Console.WriteLine("Enter Number 2: ");
                            n2 = (Console.ReadLine());
                            if (client.IsInt(n2))
                            {
                                Console.WriteLine("Enter Number 3: ");
                                n3 = (Console.ReadLine());
                                if (client.IsInt(n3))
                                {
                                    Console.WriteLine("Enter Number 4: ");
                                    n4 = (Console.ReadLine());
                                    if (client.IsInt(n4))
                                    {
                                        Console.WriteLine("Enter Number 5: ");
                                        n5 = (Console.ReadLine());
                                        if (client.IsInt(n5))
                                        {
                                            //sort here
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                        break;

                    case 6:
                        //exit
                        active = false;
                        break;
                }
            }


        }
    }
}
