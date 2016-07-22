using EFDI.DOM.Entities;
using System.Collections.Generic;

namespace EFDI.DOM.Interfaces {
  public interface IProductRepository : IRepositoryBase<Product> {
    List<Product> GetAll();
    IEnumerable<Product> GetByPrice();
    bool Exists(Product product);
  }
}
