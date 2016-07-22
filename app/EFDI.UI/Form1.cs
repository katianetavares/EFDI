using System;
using System.Windows.Forms;

using EFDI.DOM.Entities;
using EFDI.DOM.Interfaces;
using System.Diagnostics;

namespace EFDI.UI {
  public partial class Form1 : Form {
    private readonly IProductApplication _productApp;

    public Form1(IProductApplication ProductApp) {
      _productApp = ProductApp;

      InitializeComponent();
      lv_Main.View = View.Details;
      lv_Main.Columns.Add("Id");
      lv_Main.Columns.Add("Name");
      lv_Main.Columns.Add("Price");

      GetEvents();
    }

    void GetEvents() {
      bt_Sender.Click += new EventHandler(bt_Sender_Click);
      btn_NewProduct.Click += new EventHandler(btn_NewProduct_Click);
    }

    void bt_Sender_Click(object sender, EventArgs args) {
      var products = _productApp.GetAllProducts();
      
      lv_Main.Items.Clear();
      foreach (Product p in products) {
        string[] str_product = {
          p.Id.ToString(),
          p.Name,
          p.Price.ToString()
        };

        lv_Main.Items.Add(new ListViewItem(str_product));
      }

      Debug.WriteLine("Busca finalizada");
    }

    private void btn_NewProduct_Click(object sender, EventArgs e) {
      Form Form2 = new Form2(_productApp);
      Form2.ShowDialog();
      bt_Sender.PerformClick();
    }
  }
}
