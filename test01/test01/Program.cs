using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Program p = new Program(num);
        }
        
        Program(string n)
        {
            int num = Convert.ToInt32(n);
            find(num);
        }

        private void find(int num)//寻找因子
        {
            for(int i = 2; Convert.ToDouble(i) <= Math.Sqrt(Convert.ToDouble(num)); i++)
            {
                if (num % i == 0)
                {
                    if (isPrimeNuim(i))
                    {
                        Console.WriteLine(Convert.ToString(i));
                        
                    }
                    if (isPrimeNuim(num / i))
                    {
                        Console.WriteLine(Convert.ToString(num / i));
                    }
                }
            }
        }

        private bool isPrimeNuim(int num)//判断是否是素数
        {
            for(int i = 2; Convert.ToDouble(i) <= Math.Sqrt(Convert.ToDouble(num)); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
