using SimpleInjector;
using EFDI.DOM.Interfaces;
using EFDI.INFRA;
using EFDI.APP;

namespace EFDI.IOC
{
  // Dependency Injector
  public static class Boostrap {

    public static Container container;
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
