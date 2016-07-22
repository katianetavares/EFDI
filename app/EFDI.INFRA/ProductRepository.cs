using System;
using System.Collections.Generic;
using EFDI.DOM.Entities;
using EFDI.DOM.Interfaces;
using System.Linq;
using EFDI.INFRA.EF;

namespace EFDI.INFRA {
  public class ProductRepository : RepositoryBase<Product>, IProductRepository {
    public bool Exists(Product product) {
      var products = _context.Products.Where(p => p.Name == product.Name).ToList();
      return products.Count != 0;
    }

    public List<Product> GetAll() {
      return _context.Products.ToList();
    }

    public IEnumerable<Product> GetByPrice() {
      throw new NotImplementedException();
    }
  }
}
