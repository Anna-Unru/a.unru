using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string a = Console.ReadLine();
        //    string b = Console.ReadLine();
        //    int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
        //    Console.WriteLine(sum);
        //    Console.ReadLine();

            //string n = Console.ReadLine();
            //string i = Console.ReadLine();

            //byte N = Convert.ToByte(n);
            //byte I = Convert.ToByte(i);

            //int r;

            //r = (N >> I) & 1;
            //Console.WriteLine(r);
            //Console.ReadLine();

            string n = Console.ReadLine();
            
            byte N = Convert.ToByte(n);
           
            int r;

            r = (N>>(N-1)) & 0;
            Console.WriteLine(r);
            
        }
    }
}
