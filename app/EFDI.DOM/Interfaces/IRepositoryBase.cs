using EFDI.DOM.Entities;
using System.Collections;

namespace EFDI.DOM.Interfaces {
  public interface IRepositoryBase<TEntity> where TEntity : class {
    void Add(TEntity obj);
    TEntity Get(int id);
    void Delete(int id);
    void Update(TEntity obj);
    void EndTransaction();
  }
}
