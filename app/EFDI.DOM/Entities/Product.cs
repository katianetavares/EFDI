using System;

namespace EFDI.DOM.Entities {
  public class Product : Identifier {
    public String Name { get; set; }
    public decimal? Price { get; set; }
    public int Number { get; set; }
    public String Logo { get; set; }

    public override string ToString() {
      return
        "Id: " + Id + "\n" +
        "Name: " + Name + "\n" +
        "Price: " + Price + "\n";
    }
  }
}
