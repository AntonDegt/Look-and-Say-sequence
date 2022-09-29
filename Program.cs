using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string a = "1";

            
            Console.WriteLine("\n" + a);
            for ( int i = 0; i < n-1; i++)
            {
                string t = string.Empty;

                int x = 0;
                char c = a[0];
                for(int j = 0; j < a.Length; j++)
                {
                    if (c == a[j]) x++;
                    else
                    {
                        t += x.ToString() + c.ToString();
                        x = 0;
                        c = a[j];

                        j--;
                    }
                }
                t += x.ToString() + c.ToString();
                a = t;

                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
