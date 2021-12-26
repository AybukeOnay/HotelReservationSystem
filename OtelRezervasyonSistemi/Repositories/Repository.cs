using OtelRezervasyonSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.Repositories
{
    public class Repository<T> where T:class,new()
    {
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T cls_t)
        {
            db.Set<T>().Add(cls_t);
            db.SaveChanges();
        }
        public void TDelete(T cls_t)
        {
            db.Set<T>().Remove(cls_t);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T cls_t)
        {
            db.SaveChanges();
        }
        public T TFind(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().FirstOrDefault(filter);
        }
    }
}
