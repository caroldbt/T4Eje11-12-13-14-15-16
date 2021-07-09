using System;

namespace Eje1116
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /************
            * Ejercicio 11
            * **********/
            Console.WriteLine("Mostrar si un numero es mayor entre -5 y 8:");
            int dato1 = -5, dato2 = 8;
            if (dato1 > dato2)
            {
                Console.WriteLine("El número " + dato1 + " es mayor.");
            }
            else if (dato2 > dato1)
            {
                Console.WriteLine("El numero " + dato2 + " es mayor.");
            }
            else
            {
                Console.WriteLine("Son iguales");
            }

            /************
            * Ejercicio 12
            * **********/
            string nombre = "Carol";
            Console.WriteLine("Bienvenido " + nombre);

            /************
            * Ejercicio 13
            * **********/

            Console.WriteLine("Ingrese su nombre: ");
            string n = Console.ReadLine();
            Console.WriteLine("Bienvenido " + n);

            /************
            * Ejercicio 14
            * **********/
            Console.WriteLine("Mostrar el area de un circulo:");
            Console.WriteLine("Ingrese radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            const double PI = 3.1416;
            double area = PI * Math.Pow(radio, 2);
            Console.WriteLine("El área del circulo es: " + area);


            /************
            * Ejercicio 15
            * **********/
            Console.WriteLine("Mostrar si es divisble o no, un numero:");
            Console.WriteLine("Ingrese un numero:");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor % 2 == 0)
            {
                Console.WriteLine("Numero {0} es divisible con 2.", valor);
            }
            else
            {
                Console.WriteLine("Numero {0} no es divisible con 2.", valor);
            }

            /************
            * Ejercicio 16
            * **********/
            Console.WriteLine("Mostrara el precio con IVA:");
            Console.WriteLine("Bienvenido!!\nIngrese el precio del producto:");
            double dat = Convert.ToDouble(Console.ReadLine());
            const double IVA = 0.21;
            Console.WriteLine("El precio " + dat + " con IVA es: " + (dat + (dat * IVA)));
        }
    }
}
