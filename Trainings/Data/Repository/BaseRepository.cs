using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Repository
{
    public class BaseRepository<M> where M:BaseModel
    {
        public virtual void Create(M model)
        {
            using (var context = new BaseContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }

        public virtual List<M> Read()
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().ToList<M>();
            }
        }

        public virtual M Read(int id)
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().Find(id);
            }
        }

        public virtual void Update(M model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<M>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(M model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<M>(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
