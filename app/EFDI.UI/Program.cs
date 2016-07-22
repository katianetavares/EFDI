using System.Windows.Forms;
using EFDI.DOM.Interfaces;
using SimpleInjector;
using EFDI.INFRA;
using EFDI.APP;
using System;

namespace EFDI.UI {
  static class Program {
    // Properties
    private static Container container;

    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      Bootstrap();
      Application.Run(container.GetInstance<Form1>());
    }

    public static void Bootstrap() {
      container = new Container();

      container.Register<IProductRepository, ProductRepository>(Lifestyle.Singleton);
      container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
      container.Register<IProductApplication, ProductApplication>(Lifestyle.Singleton);
      container.Register<Form1>(Lifestyle.Singleton);
      //container.Register<Form2>(Lifestyle.Singleton);


      container.Verify();
    }

  }
}
