using System;

namespace repetition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Xs? ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int counter=0;
            while(num>0){
                //yo dawg i heard you liked repetition so i put repetition in your repetition so this could loop forever if i did it wrong
                while(num>counter){
                    Console.Write('x');
                    counter++;}
                    Console.WriteLine();
                    num--;
                    counter=0;
            }

            {
            Console.WriteLine("How many Lines?");
            string lineimput = Console.ReadLine();
            int lines = int.Parse(lineimput);
            int baseline = 1;
            while(lines>0){
                counter=baseline; 
                while(counter>0){
                    Console.Write('x');
                    counter--;}
                    Console.WriteLine();
                    baseline++;
                    lines--;
                }
            }
        }
    }
}
