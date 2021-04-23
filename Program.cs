using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter name: ");
            String username= Console.ReadLine();
            Console.Write("How many repeats? ");
            String repeats = Console.ReadLine();
            int counter = 0; 
            
            while (int.Parse(repeats)>counter){
            Console.WriteLine(username);
            counter++;
            }
            
        }
    }
}
