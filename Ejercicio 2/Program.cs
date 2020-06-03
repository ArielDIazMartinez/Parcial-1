using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        /*Crear un programa que pida el nombre de un dia de la semana e identifique si es 
         * fin de semana o no. En caso de error, indicarlo */

        static void Main(string[] args)
        {
                        

            Console.WriteLine("Ingrese el nombre de un dia de la semana");
            string dia = Convert.ToString(Console.ReadLine()).ToLower();

      
            if (dia.Equals ("sabado"))
            {              
                Console.WriteLine( "SI es fin de semana" );             
            }
            if (dia.Equals("domingo"))
            {
                Console.WriteLine("SI es fin de semana");
            }

            
            else
            {
                Console.WriteLine("ERROR NO ES UN DIA DE LA SEMANA");
            }
            
            Console.ReadKey();
           
        }
    }
}
