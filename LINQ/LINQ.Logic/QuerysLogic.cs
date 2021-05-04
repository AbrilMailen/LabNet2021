using LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Logic
{
    public class QuerysLogic
    {
        public NorthwindContext db = new NorthwindContext();

        //1. Query para devolver objeto customer
        public Entities.Customers Query1()
        {
            var query1 = db.Customers.First();
            return query1;
        }

        //2. Query para devolver todos los productos sin stock

        public IQueryable<Entities.Products> Query2()
        {
            var query2 = db.Products.Where(p => p.UnitsInStock == 0);
            return query2;
        }

        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad.

        public IQueryable<Entities.Products> Query3()
        {
            var query3 = db.Products.Where(p => (p.UnitsInStock > 0) && (p.UnitPrice > 3));
            return query3;
        }

        //4. Query para devolver todos los customers de Washington

        public IQueryable<Entities.Customers> Query4()
        {
            var query4 = db.Customers.Where(c => c.Region == "WA");

            return query4;
        }

        //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789

        public Entities.Products Query5()
        {
            var query5 = db.Products.Where(p => p.ProductID == 789).FirstOrDefault();
            return query5;
        }

        //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.

        public IQueryable<string> Query6()
        {
            var query6 = db.Customers.Select(p => p.CompanyName);
            return query6;
        }

        //7. Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1/1/1997.

        public IQueryable<MiClase> Query7()
        {
            DateTime fecha = Convert.ToDateTime("01/01/1997");
            var query7 =
                (from O in db.Orders
                 join C in db.Customers
                 on O.CustomerID equals C.CustomerID
                 where (C.Region == "WA") && (O.OrderDate > fecha)
                 orderby C.CustomerID
                 select new MiClase
                 {
                     CompanyName = C.CompanyName,
                     Region = C.Region,
                     OrderDate = (DateTime)O.OrderDate
                 });
            return query7;

        }

        //8. Query para devolver los primeros 3 Customers de Washington

        public IQueryable<Entities.Customers> Query8()
        {
            var query8 = db.Customers.Where(c => c.Region == "WA").Take(3);
            return query8;
        }

        //9. Query para devolver lista de productos ordenados por nombre

        public List<Entities.Products> Query9()
        {
            var query9 = (from P in db.Products
                          orderby P.ProductName
                          select P).ToList();
            return query9;
        }

        //10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

        public List<Entities.Products> Query10()
        {
            var query10 = (from P in db.Products
                           orderby P.UnitsInStock descending
                           select P).ToList();
            return query10;

        }

        //11. Query para devolver las distintas categorías asociadas a los productos

        public IQueryable<string> Query11()
        {
            var query11 = (from C in db.Categories
                           join P in db.Products
                           on C.CategoryID
                           equals P.CategoryID
                           where (C.CategoryID == P.CategoryID)
                           select C.CategoryName).Distinct();
            return query11;
        }

        //12. Query para devolver el primer elemento de una lista de productos

        public Entities.Products Query12()
        {
            var query12 = (from P in db.Products
                           select P).ToList().First();
            return query12;
        }

        //13. Query para devolver los customer con la cantidad de ordenes asociadas

        public IQueryable<MiClase> Query13()
        {
            var query13 = (from C in db.Customers
                           join O in db.Orders
                           on C.CustomerID equals O.CustomerID into Orders
                           orderby C.CustomerID
                           select new MiClase
                           {
                               IDCustomer = C.CustomerID,
                               Ordenes = Orders.Count()
                           });
            return query13;
        }

    }
}
