using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p=0;
            Console.WriteLine("Inserire valore:");
            int[] x = new int[1];
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                if (x.Length<=7)
                {
                    int b=int.Parse(x[i].ToString());
                    int ris=0;
                    ris += b * (int)Math.Pow(2, p);
                    Console.WriteLine((int)ris);
                }
                else
                {
                    Console.WriteLine("Valore inserito non corretto");
                    break;
                }
            }
            
        }
    }
}
