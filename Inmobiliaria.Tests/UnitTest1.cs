using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inmobiliaria.Dto;

namespace Inmobiliaria.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExistenPersonas()
        {
            using (FluentModel db = new FluentModel())
            {
                IList<Persona> personas = db.Personas.ToList();
                db.SaveChanges();
                Assert.IsNotNull(personas);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            using (FluentModel db = new FluentModel())
            {
                IList<Persona> personas = db.Personas.ToList();
                db.SaveChanges();
                Assert.IsNotNull(personas);
            }
        }
    }
}
