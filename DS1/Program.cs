using System;

namespace DS1
{
    public class DS1
    {
        public static void Main(string[] args)
        {
            int total = 0;
            int i = 1;
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine()); 
            while (i <=n)
            {
                total += i;
                i++;
            }
            Console.WriteLine(total);
        }
    }
}