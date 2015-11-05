using Telerik.OpenAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmobiliaria.Dto;

namespace Inmobiliaria.GestorDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FluentModel dbContext = new FluentModel())
            {
                // The method, which creates the database on the server.
                UpdateDatabase();

                // Add a new customer.
                //Asegurado newCustomer = new Asegurado
                //{
                //    Nombre = "John Smith",
                //    Apellidos = "john@smith.com"
                //};
                //dbContext.Add(newCustomer);

                // Commit changes to the database.
                dbContext.SaveChanges();

                // Get the first customer using LINQ and modify it.
                //var customer = dbContext.Customers.FirstOrDefault();


                // Commit changes to the database.
                //dbContext.SaveChanges();

                // Use LINQ to retrieve a customer named John.


                // Delete the customer from the database.


                //// Commit changes to the database.
                //dbContext.SaveChanges();
            }
        }

        private static void UpdateDatabase()
        {
            using (var context = new FluentModel())
            {
                var schemaHandler = context.GetSchemaHandler();
                EnsureDB(schemaHandler);
            }
        }

        private static void EnsureDB(ISchemaHandler schemaHandler)
        {
            string script = null;
            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }

            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }
    }
}
