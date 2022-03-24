using System;
namespace Prime_Factorize
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter your integer");
            num = Convert.ToInt32(Console.ReadLine());
          
            for(i = 2; i <= num; i++)
            {
                if(num%i ==0)
                {
                    Console.WriteLine(i + " is a factor of " + num);
                }
            }
        }
    }
}