using System;


namespace SwitchwithFact_Fbn_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for fact\n press 2 for fibonacci \n press 3 for prime number");
            int n=Convert.ToInt32(Console.ReadLine());
            
            switch (n)
            {
                    case 1:
                    {
                        Console.WriteLine("----factorial ----");
                        Console.WriteLine("enter a number which factorial to be evaluated:");
                        int number= Convert.ToInt32(Console.ReadLine());

                        int fact = 1;
                        for (int i = 1; i <= number; i++)
                        {
                            fact=fact*i;

                        }
                        Console.WriteLine($"factorial of {number} is  {fact}");
                        Console.WriteLine("Thank You ");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("enter a number where up to u want to print fibonacci series");
            int number2=Convert.ToInt32(Console.ReadLine());


            int n1=1, n2=0,fbn=1;
            for (int i = 0; i < number2; i++)
            {
                fbn = n1 + n2;
                n1= n2;
                n2 = fbn;
                Console.Write(fbn+"\t");
            }
                        Console.WriteLine("\nThank You");
                        break;
                    }
                case 3:
                    {

                        Console.WriteLine("enter a number which to be check if it is prime or not");
                        int number3 = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 1; i <= number3 / 2; i++)
                        {
                            if (number3 % i == 0)
                                count++;
                        }

                        if (count > 1)
                            Console.WriteLine("not prime");
                        else
                            Console.WriteLine(" prime");

                        Console.WriteLine("Thank You");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("please enter a valid value");
                        n= Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    }
                   
            }
           
            Console.ReadLine();
        }
    }
}
