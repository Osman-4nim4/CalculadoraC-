using System;

namespace Calculadora_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidadA;
            double cantidadB;
            string operacionX;
            double resultado;

            Console.WriteLine("Escriba la operacion que quiere realizar");
            Console.WriteLine("1.SUMA");
            Console.WriteLine("2.RESTA");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");
            Console.WriteLine("******************ESPACIO****************************");
            Console.WriteLine("Ingrese el numero de la operacion ");

            operacionX = Console.ReadLine();

            Console.WriteLine("Escriba la primer cantidad");
            cantidadA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************************************************");
            Console.WriteLine("Escriba la segunda cantidad");
            cantidadB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************************************************");
            Console.Clear();
            
            

            if(operacionX=="1")
            {
                resultado= cantidadA + cantidadB;
                Console.WriteLine("Tu respuesta es :"+ resultado);
                Console.ReadLine();
            }
            if(operacionX=="2")
            {
                resultado= cantidadA - cantidadB;
                Console.WriteLine("Tu respuesta es:"+ resultado);
                Console.ReadLine();
            }
            if(operacionX=="3")
            {
                resultado= cantidadA * cantidadB;
                Console.WriteLine("Tu respuesta es:"+ resultado);
                Console.ReadLine();
            }
            if(operacionX=="4")
            {
                resultado= cantidadA / cantidadB;
                Console.WriteLine("Tu respuesta es: "+ resultado);
                Console.ReadLine();
            }
        }
    }
}
