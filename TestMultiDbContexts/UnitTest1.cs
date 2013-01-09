using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

using testAppDbContext.Models;
using testFooDbContext.Models;

namespace TestMultiDbContexts
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void TestMethod1()
        {
            using (AppDbContext appDb = new AppDbContext()) {
                appDb.Items.Add(new AppItems() { 
                    Name = "Item1",
                });
                appDb.Items.Add(new AppItems()
                {
                    Name = "Item2",
                });
                appDb.Items.Add(new AppItems()
                {
                    Name = "Item3",
                });
                appDb.SaveChanges();
            }
            using (FooDbContext fooDb = new FooDbContext()) {
                fooDb.FooItems.Add(new FooItems() { 
                    Name = "Foo1",
                });
                fooDb.FooItems.Add(new FooItems()
                {
                    Name = "Foo2",
                });
                fooDb.FooItems.Add(new FooItems()
                {
                    Name = "Foo3",
                });
                fooDb.SaveChanges();
            }

            // Query saved items
            using (AppDbContext appDb = new AppDbContext()) {
                var items = appDb.Items.ToList();
                items.ForEach(c => log.Info("AppItem:" + c.Guid.ToString() + " name:" + c.Name));
            }
            using (FooDbContext fooDb = new FooDbContext()) {
                var items = fooDb.FooItems.ToList();
                items.ForEach(c => log.Info("FooItem: " + c.Guid.ToString() + " name:" + c.Name));
            }

        }
    }
}
