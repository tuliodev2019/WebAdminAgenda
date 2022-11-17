using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Core.Interfaces.Services;

namespace webAdmin.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }
        public virtual TEntity Add(TEntity obj)
        {
            return _repository.Add(obj);
        }
        public virtual TEntity? GetById(object id)
        {
            return _repository.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }
        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}
