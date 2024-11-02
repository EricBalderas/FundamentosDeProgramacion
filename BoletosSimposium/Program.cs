using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosSimposium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            fecha = DateTime.Today;
            Console.WriteLine(fecha);
            DateTime fechaLimite = Convert.ToDateTime("10/15/2024");


            //if (fecha < Convert.ToDateTime("10/15/2024") Esto tambien funcionaria 
            if (fecha < fechaLimite)
            {
                Console.WriteLine("1500");
            }
            else
            {
                Console.WriteLine("1600");
            }


            //if (fecha.CompareTo("10/01/2024") > 1)
            //{
            //    Console.WriteLine("1500");
            //}

        
        }
    }
}
