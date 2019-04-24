using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horus.DataAccess
{
    public class EspecialidadRepository<TEntity> : IDisposable, IBaseService<Especialidad> where TEntity : class
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Especialidad> GetAll()
        {
            throw new NotImplementedException();
        }

        public Especialidad GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Especialidad entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Especialidad entity)
        {
            throw new NotImplementedException();
        }
    }
}
