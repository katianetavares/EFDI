using System;
using EFDI.DOM.Interfaces;

namespace EFDI.APP {
  public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : class {
    protected readonly IRepositoryBase<TEntity> _repoBase;

    public ApplicationBase(IRepositoryBase<TEntity> RepoBase) {
      _repoBase = RepoBase;
    }

    public void Add(TEntity obj) {
      _repoBase.Add(obj);
      _repoBase.EndTransaction();
    }
  }
}
