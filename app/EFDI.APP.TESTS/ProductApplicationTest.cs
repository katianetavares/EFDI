using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFDI.DOM.Interfaces;
using EFDI.DOM.Entities;
using Moq;
using Exceptions;

namespace EFDI.APP.TESTS {
  [TestClass]
  public class ProductApplicationTest {
    private Mock<IProductRepository> _mockIProductRepo;
    private ProductApplication _productApp;
    private Mock<Product> _product;

    [TestInitialize]
    public void Start() {
      _mockIProductRepo = new Mock<IProductRepository>();
      _productApp = new ProductApplication(_mockIProductRepo.Object);
      _product = new Mock<Product>();
    }

    [TestMethod]
    public void When_Add_returns_success() {
      Product p = new Product { Name = "Generic Product" };
      _mockIProductRepo.Setup(x => x.Exists(p)).Returns(false);

      if (_productApp.Exists(p))
        throw new ProductException("Product already exists!");
      else
        _productApp.Add(p);

      _mockIProductRepo.Verify(x => x.Add(p), Times.AtLeast(1));
    }
  }
}
