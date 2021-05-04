using LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.UI
{
    public class EjerciciosUI
    {
        protected QuerysLogic querysLogic = new QuerysLogic();
        public void Ejercicio1()
        {
            Console.WriteLine($"1 - Query para devolver objeto customer.");
            Console.WriteLine();
            var query1 = querysLogic.Query1();
            Console.WriteLine($"Customer ID: {query1.CustomerID} {Environment.NewLine}" +
                                $"Nombre contacto: {query1.ContactName} {Environment.NewLine}" +
                                $"Titulo contacto: {query1.ContactTitle} {Environment.NewLine}" +
                                $"Nombre empresa: {query1.CompanyName} {Environment.NewLine}" +
                                $"Pais: {query1.Country} {Environment.NewLine}" +
                                $"Direccion: {query1.Address} {Environment.NewLine}" +
                                $"Fax: {query1.Fax} {Environment.NewLine}" +
                                $"Telefono: {query1.Phone} {Environment.NewLine}" +
                                $"Codigo postal: {query1.PostalCode} {Environment.NewLine}" +
                                $"Region: {query1.Region} {Environment.NewLine}");

        }
        public void Ejercicio2()
        {
            Console.WriteLine($"2 - Query para devolver todos los productos sin stock.");
            Console.WriteLine();
            var query2 = querysLogic.Query2();
            foreach (var item in query2)
            {
                Console.WriteLine($"ID producto: {item.ProductID}, Nombre del producto: {item.ProductName}{Environment.NewLine}");
            }
        }
        public void Ejercicio3()
        {
            Console.WriteLine($"3 - Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad.");
            Console.WriteLine();
            var query3 = querysLogic.Query3();
            foreach (var item in query3)
            {
                Console.WriteLine($"ID producto: {item.ProductID}, Nombre: {item.ProductName}, Stock:{item.UnitsInStock}, Precio unitario: ${item.UnitPrice}{Environment.NewLine}");
            }
        }
        public void Ejercicio4()
        {
            Console.WriteLine($"4 - Query para devolver todos los customers de Washington.");
            Console.WriteLine();
            var query4 = querysLogic.Query4();
            foreach (var item in query4)
            {
                Console.WriteLine($"ID Customer: {item.CustomerID}, Nombre Empresa: {item.CompanyName}, Nombre Contacto: {item.ContactName}, Region: {item.Region}{Environment.NewLine}");
            }
        }
        public void Ejercicio5()
        {
            Console.WriteLine($"5 - Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789.");
            Console.WriteLine();
            var query5 = querysLogic.Query5();
            if (query5 == null)
                Console.WriteLine($"El elemento es null.");
            else
                Console.WriteLine($"ID producto: {query5.ProductID}, Nombre: {query5.ProductName}");
        }
        public void Ejercicio6()
        {
            Console.WriteLine($"6 - Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine();
            var query6 = querysLogic.Query6();
            foreach (var item in query6)
            {
                Console.WriteLine($"Nombre customer: {item.ToUpper()}");
                Console.WriteLine($"Nombre customer: {item.ToLower()}{Environment.NewLine}");
            }
        }
        public void Ejercicio7()
        {
            Console.WriteLine($"7 - Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1/1/1997.");
            Console.WriteLine();
            var query7 = querysLogic.Query7();
            foreach (var item in query7)
            {
                Console.WriteLine($" Nombre customer: {item.CompanyName}, Region: {item.Region}, Fecha Orden:{item.OrderDate} {Environment.NewLine}");

            }
        }
        public void Ejercicio8()
        {
            Console.WriteLine($"8 - Query para devolver los primeros 3 Customers de Washington.");
            Console.WriteLine();
            var query8 = querysLogic.Query8();
            foreach (var item in query8)
            {
                Console.WriteLine($"ID customer:{item.CustomerID}, Nombre: {item.CompanyName}, Region: {item.Region} {Environment.NewLine}");
            }
        }
        public void Ejercicio9()
        {
            Console.WriteLine($"9 - Query para devolver lista de productos ordenados por nombre.");
            Console.WriteLine();
            var query9 = querysLogic.Query9();
            foreach (var item in query9)
            {
                Console.WriteLine($"ID Producto:{item.ProductID}, Nombre: {item.ProductName}{Environment.NewLine}");
            }
        }
        public void Ejercicio10()
        {
            Console.WriteLine($"10 - Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine();
            var query10 = querysLogic.Query10();
            foreach (var item in query10)
            {
                Console.WriteLine($"ID Producto:{item.ProductID}, Nombre: {item.ProductName}, Stock:  {item.UnitsInStock} {Environment.NewLine}");
            }
        }
        public void Ejercicio11()
        {
            Console.WriteLine($"11 - Query para devolver las distintas categorías asociadas a los productos.");
            Console.WriteLine();
            var query11 = querysLogic.Query11();
            foreach (var item in query11)
            {
                Console.WriteLine($"Nombre categoria: {item} {Environment.NewLine}");
            }
        }
        public void Ejercicio12()
        {
            Console.WriteLine($"12 - Query para devolver el primer elemento de una lista de productos.");
            Console.WriteLine();
            var query12 = querysLogic.Query12();
            Console.WriteLine($"ID producto: {query12.ProductID}, Nombre: {query12.ProductName}");
        }
        public void Ejercicio13()
        {
            Console.WriteLine($"13 - Query para devolver los customer con la cantidad de ordenes asociadas.");
            Console.WriteLine();
            var query13 = querysLogic.Query13();
            foreach (var item in query13)
            {
                Console.WriteLine($"Customer ID: {item.IDCustomer}, Cantidad de Ordenes: {item.Ordenes}");
            }
        }
    }
}
