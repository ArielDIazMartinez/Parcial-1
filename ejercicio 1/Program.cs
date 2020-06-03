using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pedir al usuario el precio de un producto y la forma de pagar (efectivo o tarjeta) si la 
             * forma de pago es mediante tarjeta, pedir el numero de tarjeta (12 digitos). Ojo, validar que
             * el valor ingresado en el sea positivo. */

            string formadepago;
            double numeraciondetargeta;
            double precio;


            


            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());

           

            Console.WriteLine("Ingrese la forma de pago: Efectivo o Targeta");
            formadepago = Convert.ToString(Console.ReadLine()).ToLower();


            if (formadepago.Equals("targeta")) 
            {
               
                Console.WriteLine("Digite la numeracion de la Targeta");
                numeraciondetargeta = Convert.ToDouble(Console.ReadLine());

                if (numeraciondetargeta >= 0  && numeraciondetargeta >= 100000000000)  // Asi logro que el numero que se ingrese sea igual a 12 digitos
                {                                                                          
                    Console.WriteLine(" Procesado pago con precio : " + precio +
                       " Felicidades pago procesado con numero de Targeta:  " + numeraciondetargeta);
                }
                else
                {
                    Console.WriteLine("EL numero ingresado no es mayor a 12 digitos o Algun numero es negativo");
                }

               
            }
            

            if (formadepago.Equals("efectivo"))
            {
                Console.WriteLine("Procesando pago con un Precio de: " + precio +
                    " : Felicidades pago procesado con EFECTIVO:  " + precio);
            }

            else
            {
                Console.WriteLine("Error al Procesar el pago ");
            }

            Console.ReadKey();

            
          
        }
    }
}
