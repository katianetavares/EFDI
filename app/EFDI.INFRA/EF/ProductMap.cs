using EFDI.DOM.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EFDI.INFRA.EF {
  public class ProductMap : EntityTypeConfiguration<Product> {
    public ProductMap() {
      HasKey(p => p.Id);
      Property(p => p.Name).IsRequired();
    }
  }
}
