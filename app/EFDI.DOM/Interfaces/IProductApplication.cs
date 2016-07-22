using EFDI.DOM.Entities;
using System.Collections.Generic;

namespace EFDI.DOM.Interfaces {
  public interface IProductApplication : IApplicationBase<Product> {
    List<Product> GetAllProducts();
    bool Exists(Product product);
    void Add(Product product);
  }
}
