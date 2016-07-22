using System;
using EFDI.DOM.Interfaces;
using System.Data.Entity;
using EFDI.INFRA.EF;
using System.Diagnostics;

namespace EFDI.INFRA {
  public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class {

    protected ContextDatabase _context { get; set; }

    public RepositoryBase() {
      _context = new ContextDatabase();
    }

    public void Add(TEntity obj) {
      _context.Set<TEntity>().Add(obj);
    }

    public void Delete(int id) {
      throw new NotImplementedException();
    }

    public TEntity Get(int id) {
      return _context.Set<TEntity>().Find(id);
      //throw new NotImplementedException();
    }

    public void Update(TEntity obj) {
      throw new NotImplementedException();
    }

    public void EndTransaction() {
      _context.SaveChanges();
    }

    public void Dispose() {
      Debug.WriteLine("Disposing _context in RepoBase");
    }

   
  }
}
