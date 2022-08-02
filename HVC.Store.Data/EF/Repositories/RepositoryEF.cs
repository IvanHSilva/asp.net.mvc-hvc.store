using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HVC.Store.Data.EF.Repositories {

    public class RepositoryEF<T> : IRepository<T> where T : Entity {

        protected readonly HVCStoreDataContext _ctx = new HVCStoreDataContext();

        public IEnumerable<T> Get() {
            return _ctx.Set<T>().ToList();
        }

        public T Get(int id) {
            return _ctx.Set<T>().SingleOrDefault(t => t.Id == id);
            //return _ctx.Set<T>().Find(id);
        }

        public void Add(T entity) {
            _ctx.Set<T>().Add(entity);
            _ctx.SaveChanges();
        }

        public void Edit(T entity) {
            _ctx.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Delete(T entity) {
            _ctx.Set<T>().Remove(entity);
            _ctx.SaveChanges();
        }

        private void Save() {
            _ctx.SaveChanges();
        }

        public void Dispose() {
            _ctx.Dispose();
        }
    }
}
