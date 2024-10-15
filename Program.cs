namespace FizBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

             GetNumbers();
        }

        static void GetNumbers()
        {


            int i;

            for ( i = 1; i <= 100; i++)
            {
                UseNumbers(i);

               
            }
;  
        }

        static int UseNumbers(int i)
        {
           

            if (i % 3 == 0)
            {
               if (i % 5 == 0)
                {
                 Console.WriteLine("FizBuzz");

                }
                Console.WriteLine();
            }

            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            if (i % 3 == 0)
            {
                Console.WriteLine("Fiz");
            }

            else
            {
                Console.WriteLine(i);
            }
            return i;
        }

    }
}


