using System;

namespace _13241_LeastCommonMultiple2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] str = Console.ReadLine().Split();
            Int64 a = Int32.Parse(str[0]);
            Int64 b = Int32.Parse(str[1]);

            Int64 oa = a;
            Int64 ob = b;
            Int64 lm;

            while (true)
            {
                if(a % b == 0)
                {
                    lm = b;
                    break;
                }

                Int64 tmp = b;
                b = a % b;
                a = tmp;
            }

            lm = (oa * ob) / lm;

            Console.WriteLine(lm);
        }
    }
}
