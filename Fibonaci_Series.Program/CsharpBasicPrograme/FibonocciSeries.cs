using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicPrograme
{
    public class FibonocciSeries
    {
        public static void Findseries(int n)
        {
            int first = 0;
            int second = 1;
            int third = 0,res = 0;
            Console.Write("{0} {1}",first,second);
            third = first + second;
            for (int i= 2; i < n; i++)
            {
                third = first + second;
                Console.Write("{0}", third);
                first = second;
                second = third;
                
            }
            

            }
}
