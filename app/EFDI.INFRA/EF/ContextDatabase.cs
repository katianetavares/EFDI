using System;
using System.Data.Entity;
using EFDI.DOM.Entities;
using System.Diagnostics;

namespace EFDI.INFRA.EF {
  public class ContextDatabase : DbContext {
    // Properties
    private static String dbName = "EFDI";

    // Entities
    public DbSet<Product> Products { get; set; }

    public ContextDatabase() : base(dbName) {
      Database.SetInitializer(new DatabaseSeed());
      Debug.WriteLine("Created EF Context..");
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Configurations.Add(new ProductMap());

      base.OnModelCreating(modelBuilder);
    }
  }
}
