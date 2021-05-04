using LINQ.Data;
using LINQ.Entities;
using LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {


            EjerciciosUI ejerciciosUI = new EjerciciosUI();

            string teclado;
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("********* Bienvenido al practico de LINQ de Abril Arce. *********");
            do
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("********* Por favor, ingrese UN NUMERO DEL 1 al 13 **************");
                Console.WriteLine("****** para poder acceder a los correspondientes ejercicios. ****");
                Console.WriteLine("****************** INGRESE 0 PARA SALIR. ************************");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                teclado = Console.ReadLine();
                switch (teclado)
                {
                    case "1":
                        ejerciciosUI.Ejercicio1();
                        Console.ReadLine();
                        break;
                    case "2":
                        ejerciciosUI.Ejercicio2();
                        Console.ReadLine();
                        break;
                    case "3":
                        ejerciciosUI.Ejercicio3();
                        Console.ReadLine();
                        break;

                    case "4":
                        ejerciciosUI.Ejercicio4();
                        Console.ReadLine();
                        break;
                    case "5":
                        ejerciciosUI.Ejercicio5();
                        Console.ReadLine();
                        break;
                    case "6":
                        ejerciciosUI.Ejercicio6();
                        Console.ReadLine();
                        break;
                    case "7":
                        ejerciciosUI.Ejercicio7();
                        Console.ReadLine();
                        break;
                    case "8":
                        ejerciciosUI.Ejercicio8();
                        Console.ReadLine();
                        break;
                    case "9":
                        ejerciciosUI.Ejercicio9();
                        Console.ReadLine();
                        break;
                    case "10":
                        ejerciciosUI.Ejercicio10();
                        Console.ReadLine();
                        break;
                    case "11":
                        ejerciciosUI.Ejercicio11();
                        Console.ReadLine();
                        break;
                    case "12":
                        ejerciciosUI.Ejercicio12();
                        Console.ReadLine();
                        break;
                    case "13":
                        ejerciciosUI.Ejercicio13();
                        Console.ReadLine();
                        break;
                    case "0": break;
                    default:
                        Console.WriteLine("****************** Ingrese un numero valido. ********************");
                        break;
                }
            }
            while (teclado != "0");
            Console.ReadLine();
        }
    }
}
