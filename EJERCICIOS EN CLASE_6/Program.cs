using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_EN_CLASE_6
{
    internal class Program
    {

        //NUMERO 1
        static void EJERCICIO1()
        {
            int[] numeros;
            numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumaPares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    sumaPares += numeros[i];
                }
            }

            Console.WriteLine($"La suma de los elementos pares es: {sumaPares}");
            Console.ReadKey();
            Console.Clear();
        }


        //NUMERO 2

        static void Despliegue(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static int[] InvertirArreglo(int[] original)
        {
            int[] invertido = new int[original.Length];
            int j = original.Length - 1;

            for (int i = 0; i < original.Length; i++)
            {
                invertido[i] = original[j];
                j--;
            }

            return invertido;
        }

        static void EJERCICIO2()
        {
            int[] elementos = new int[] { 50, 20, 80, 90, 60 };

            Console.WriteLine("Original:");
            Despliegue(elementos);

            Console.WriteLine("Invertido:");
            int[] invertido = InvertirArreglo(elementos);
            Despliegue(invertido);

            Console.WriteLine("***********");

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO 3
        static void despliegue(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static int EncontrarMaximo(int[] arreglo)
        {
            int maximo = arreglo[0];

            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > maximo)
                {
                    maximo = arreglo[i];
                }
            }

            return maximo;
        }

        static void EJERCICIO3()
        {
            int[] numeros = new int[] { 10, 2, 5, 8, 15, 3, 12, 9 };

            int max = EncontrarMaximo(numeros);

            Console.WriteLine("El valor máximo del arreglo es: {0}", max);

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO 4
        static void lista(int[] arreglo1)
        {
            foreach (int item in arreglo1)
            {
                Console.WriteLine(item);
            }
        }

        static int EnconMaximo(int[] arreglo1)
        {
            int maximo = arreglo1[0];

            for (int i = 1; i < arreglo1.Length; i++)
            {
                if (arreglo1[i] > maximo)
                {
                    maximo = arreglo1[i];
                }
            }

            return maximo;
        }

        static int BuscarElemento(int[] arreglo1, int valor)
        {
            for (int i = 0; i < arreglo1.Length; i++)
            {
                if (arreglo1[i] == valor)
                {
                    return i;
                }
            }

            return -1;
        }


        static void EJERCICIO4()
        {
            int[] numero = new int[] { 1, 2, 4, 5, 10, 3, 12, 9 };
            int valor = 2;

            int posicion = BuscarElemento(numero, valor);

            if (posicion == -1)
            {
                Console.WriteLine("El valor {0} no se encuentra en el arreglo.", valor);
            }
            else
            {
                Console.WriteLine("El valor {0} se encuentra en la posición {1}.", valor, posicion);
            }

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO 5
        static void LISTA2(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static int[] EncontraMaximo(int[] arreglo2)
        {
            int maximo = arreglo2[0];

            for (int i = 1; i < arreglo2.Length; i++)
            {
                if (arreglo2[i] > maximo)
                {
                    maximo = arreglo2[i];
                }
            }

            int[] resultado = new int[] { maximo };
            return resultado;
        }

        static int elemento(int[] arreglo2, int valor)
        {
            for (int i = 0; i < arreglo2.Length; i++)
            {
                if (arreglo2[i] == valor)
                {
                    return i;
                }
            }

            return -1;
        }


        static int[] OrdenarAscendente(int[] arreglo2)
        {
            Array.Sort(arreglo2);
            return arreglo2;
        }

        static void EJERCICIO5()
        {
            int[] numeros = new int[] { 50, 20, 80, 90, 60 };

            Console.WriteLine("Original:");
            Despliegue(numeros);

            Console.WriteLine("Ordenado ascendentemente:");
            int[] ordenado = OrdenarAscendente(numeros);
            Despliegue(ordenado);

            Console.WriteLine("***********");

            Console.ReadKey();
            Console.Clear();
        }

        //EJERCICIO_6
        static void Despliegue6(string[] arreglo6)
        {
            foreach (string nombre6 in arreglo6)
            {
                Console.WriteLine(nombre6);
            }
        }
        static void EJERCICIO6()
        {

            string[] nombres;
            int cantidadNombres;

            Console.WriteLine("********** EJERCICIO DE ORDENAMIENTO DE NOMBRES **********");


            Console.Write("¿Cuántos nombres desea ingresar?: ");
            cantidadNombres = int.Parse(Console.ReadLine());


            nombres = new string[cantidadNombres];


            for (int i = 0; i < cantidadNombres; i++)
            {
                Console.Write("Ingrese el nombre {0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }


            Console.WriteLine("\nLista de nombres original:");
            Despliegue6(nombres);


            Array.Sort(nombres);


            Console.WriteLine("\nLista de nombres ordenada alfabéticamente:");
            Despliegue6(nombres);


            Console.ReadKey();
            Console.Clear();
        }

        //EJERCICIO 7

        static void EJERCICIO7()
        {

            int[] numeros;
            int cantidadNumeros;


            Console.WriteLine("********** EJERCICIO DE MÁXIMO Y MÍNIMO **********");


            Console.Write("¿Cuántos números desea ingresar?: ");
            cantidadNumeros = int.Parse(Console.ReadLine());

            numeros = new int[cantidadNumeros];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese el número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // NO UTILICE EL ARRAY.MIN Y ARRAY.MAX PORQUE NO ME LO PERMITE EL PROGRAMA YA QUE USO .NET 
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }
            }


            Console.WriteLine("\nEl valor máximo es: {0}", maximo);
            Console.WriteLine("El valor mínimo es: {0}", minimo);

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO8

        static void EJERCICIO8()
        {

            string[] paises = { "Guatemala", "España", "México", "Argentina", "Colombia" };


            Console.Write("Ingrese el nombre del país a buscar: ");
            string paisABuscar = Console.ReadLine();


            int indice = Array.IndexOf(paises, paisABuscar);


            if (indice >= 0)
            {
                Console.WriteLine("El país {0} se encuentra en el arreglo en la posición {1}", paisABuscar, indice);
            }
            else
            {
                Console.WriteLine("El país {0} no se encuentra en el arreglo", paisABuscar);
            }

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO 9
        static void Despliegue9(int[] arreglo9)
        {
            foreach (int numero in arreglo9)
            {
                Console.Write("{0} ", numero);
            }
            Console.WriteLine();
        }
        static void EJERCICIO9()
        {

            int[] numeros9 = { 1, 2, 3, 4, 5 };


            Console.WriteLine("Arreglo original:");
            Despliegue9(numeros9);

            Array.Reverse(numeros9);

          
            Console.WriteLine("\nArreglo invertido:");
            Despliegue9(numeros9);

            Console.ReadKey();
            Console.Clear();
        }

        //NUMERO 10

        static void EJERCICIO10()
        {
            int cantidadCalificaciones;
            float[] calificaciones;

            
            Console.WriteLine("********** EJERCICIO DE CALIFICACIONES SOBRESALIENTES **********");

           
            Console.Write("¿Cuántas calificaciones desea ingresar?: ");
            cantidadCalificaciones = int.Parse(Console.ReadLine());

           
            calificaciones = new float[cantidadCalificaciones];

            
            for (int i = 0; i < cantidadCalificaciones; i++)
            {
                Console.Write("Ingrese la calificación {0}: ", i + 1);
                calificaciones[i] = float.Parse(Console.ReadLine());
            }

           
            bool haySobresalientes = Array.Exists(calificaciones, x => x >= 90);

            
            if (haySobresalientes)
            {
                Console.WriteLine("¡Hay al menos una calificación sobresaliente!");
            }
            else
            {
                Console.WriteLine("No hay calificaciones sobresalientes.");
            }

            Console.ReadKey();
            Console.Clear();
        }





        static void Main(string[] args)
    {
            int opcion;

            try
            {

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***********************MENU***********************");
                    Console.ResetColor();
                    Console.WriteLine("1. Suma de Elementos Pares");
                    Console.WriteLine("2. Invertir el orden de un Arreglo");
                    Console.WriteLine("3. Encontrar el Valor Máximo en un Arreglo");
                    Console.WriteLine("4. Buscar un elemento en un arreglo:");
                    Console.WriteLine("5. Ordenar un arreglo de forma ascendente: ");
                    Console.WriteLine("6. Ordenar  nombres alfabéticamente:");
                    Console.WriteLine("7. Encuentra el valor máximo y el valor mínimo:");
                    Console.WriteLine("8. Buscar el país en el arreglo");
                    Console.WriteLine("9. Invertir el orden de los elementos.");
                    Console.WriteLine("10. Idicando si hay calificaciones sobresalientes o no.");
                    Console.WriteLine("11. Salir");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***************************************************");
                    Console.ResetColor();

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            EJERCICIO1();
                            break;
                        case 2:
                            EJERCICIO2();
                            break;
                        case 3:
                            EJERCICIO3();
                            break;
                        case 4:
                            EJERCICIO4();
                            break;
                        case 5:
                            EJERCICIO5();
                            break;
                        case 6:
                            EJERCICIO6();
                            break;
                        case 7:
                            EJERCICIO7();
                            break;
                       
                        case 8:
                            EJERCICIO8();
                            break;
                        case 9:
                            EJERCICIO9();
                            break;
                        case 10:
                            EJERCICIO10();
                            break;
                        case 11:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Seleccione del 1 al 4.");
                            break;
                    }
                } while (opcion != 11);


            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");

            }
            Console.ReadKey();

        }
    }
}


