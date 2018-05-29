using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application6
{
    public class maindistinctpower
    {
        public double maindistinctpower()
        {
            double[] arrstore = new double[10000];
            double[] arrint = new double[10000];
            int iCount = 0;
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    arrstore[iCount] = Math.Pow(a, b);
                    iCount++;
                }
            }
            arrstore.Distinct();
            return iCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            maindistinctpower mainpower = new maindistinctpower();
            mainpower.maindistinctpower();
            Console.ReadKey();
        }
    }
}
