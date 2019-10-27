using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleas enter your name \n");
            string name = Console.ReadLine();
            Console.Write("Pleas enter your age \n");
            while(true)
            {
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 18)
                    {
                        Console.Write("You have the right to vote");
                    }
                    else
                    {
                        Console.WriteLine("You dont have the right to vote");
                    }
                    break;
                } catch
                {

                    Console.Write("Pleas enter your real age \n");
                }
            }
            
        }
    }
}
