using System.Data.Entity;
using EFDI.DOM.Entities;

namespace EFDI.INFRA.EF {
  public class DatabaseSeed : CreateDatabaseIfNotExists<ContextDatabase> {
    protected override void Seed(ContextDatabase context) {
      context = new ContextDatabase();

      context.Products.Add(
        new Product { Id = 1, Name = "Coke", Price = 3.23m }
      );

      context.Products.Add(
        new Product { Id = 2, Name = "Beer", Price = 4.27m }
      );

      context.Products.Add(
        new Product { Id = 3, Name = "Soda", Price = 2.88m }
      );

      context.SaveChanges();
      base.Seed(context);
    }
  }
}
