cusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random r = new Random();
            Console.WriteLine("Input Number of Contenstant:");
            int size=Convert.ToInt32(Console.ReadLine());
            double [] timings = new double[size];
            for(int i =0; i<size; i++)
            {
                timings[i] = 80*r.NextDouble()+20;
                Console.WriteLine(timings[i]);

            }
            int firstIndex = 0;
            double first= timings[0];
            for (int j=0;j<size;j++)
            {
                if (timings[j]<first)
                {
                    first = timings[j];
                   
                }

            }
            Console.WriteLine("Best timing (min) is: " + first);



        }
    }
}
    





