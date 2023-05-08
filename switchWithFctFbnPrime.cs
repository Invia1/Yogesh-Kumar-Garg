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
                        Console.WriteLine("enter a number where up to u want to be print fibonacci series:");
                        int number2=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\n");
                         int fib(int a)
                        {
                            if (a > 1)
                                return fib(a - 1) + fib(a - 2);
                            else if (a == 1)
                                return 1;
                            else
                                return 0;
                        }
                        for (int i = 1; i <= number2; i++)
                        {
                            Console.WriteLine(fib(i));

                        }
                        Console.WriteLine("Thank You");
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
