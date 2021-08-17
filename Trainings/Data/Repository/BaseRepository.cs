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
    public class BaseRepository<M> where M : BaseModel
    {
        public void Create(M model)
        {
            using (var context = new BaseContext())
            {
                context.Set<M>().Add(model);
            }
        }

        public List<M> Read()
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().ToList<M>();
            }
        }

        public M Read(int id)
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().Find(id);
            }
        }

        public void Update(M model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<M>(model).State = EntityState.Modified;
            }
        }

        public void Delete(M model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<M>(model).State = EntityState.Deleted;
            }
        }
    }
}
