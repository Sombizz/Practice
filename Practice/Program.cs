using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce mi edad y te dire si es correcta");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad == 19)
            {
                Console.WriteLine("Has acertado! mi edad es 19");
            }
            else if (edad < 19)
            {
                while (edad < 19)
                {
                    Console.WriteLine("Has fallado, intentalo de nuevo");
                    int ok = Convert.ToInt32(Console.ReadLine()); 
                    if (ok == 19)
                    {
                        Console.WriteLine("Has acertado! mi edad es 19");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }        
                }
                
            }
            Console.ReadLine();
        }
    }
}
