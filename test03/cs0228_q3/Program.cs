using System;

namespace test
{
    class Program
    {
        private int[] a = new int[101];
        static void Main(string[] args)
        {
            Program run = new Program();
        }
        Program()
        {
            for(int i = 0; i < 101; i++)
            {
                a[i] = 1;
            }
            a[0] = 0;
            a[1] = 0;
            for(int i = 2; i < 101; i++)
            {
                if (a[i] == 1)
                {
                    for(int j = i; j<=100; j += i)
                    {
                        a[j] = 0;
                    }
                    Console.WriteLine(Convert.ToString(i));
                }
            }
        }
    }
}
