using EFDI.DOM.Entities;
using EFDI.DOM.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Diagnostics;

namespace EFDI.APP
{
  public class ProductApplication : ApplicationBase<Product>, IProductApplication {

    private readonly IProductRepository _productRepo;

    public ProductApplication(IProductRepository ProductRepo) : base(ProductRepo) {
      _productRepo = ProductRepo;
    }

    public bool Exists(Product product) {
      return _productRepo.Exists(product);
    }

    public List<Product> GetAllProducts() {
      return _productRepo.GetAll();
    }
  }
}
