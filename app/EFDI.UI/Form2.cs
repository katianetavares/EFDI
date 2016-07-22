using EFDI.DOM.Entities;
using EFDI.DOM.Interfaces;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using Exceptions;

namespace EFDI.UI {
  public partial class Form2 : Form {
    private readonly IProductApplication _productApp;

    public Form2(IProductApplication ProductApp) {
      _productApp = ProductApp;
      InitializeComponent();

      GetEvents();
    }

    private void GetEvents() {
      btn_Save.Click += new EventHandler(saveProduct);
    }


    private void saveProduct(object sender, EventArgs args) {
      decimal? price = Convert.ToDecimal(tb_Price.Text.Replace('.', ','));
      Product p = new Product { Name = tb_Name.Text, Price = price };

      if (_productApp.Exists(p))
        throw new ProductException("Product already exists!");
      else {
        _productApp.Add(p);
        Debug.WriteLine("Product Added!");
      }

      this.Dispose();
    }
  }
}
