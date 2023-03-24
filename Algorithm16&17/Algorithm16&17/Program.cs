namespace Algorithm16_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print numbers between 0 to 1000 range 
            Console.WriteLine("Prime numbers between 0 to 1000");
            for (int number = 1; number <= 1000; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
               
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
                
            }
            Console.ReadLine();
        }
    }
    }
