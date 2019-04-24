using Horus.DataAccess;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Businesslogic
{
    public class BarrioServices : IBaseService<Barrio>
    {
        private readonly BarrioRepository<Barrio> entityRepository = new BarrioRepository<Barrio>();
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void Registrar(Barrio entity)
        {
            if (ValidarEntity(entity))
            {
                if (entityRepository.GetById(entity.BarrioId) == null)
                {
                    entityRepository.Insert(entity);
                }
                else
                    entityRepository.Update(entity);
            }
        }

        public List<Barrio> Todos()
        {
            return entityRepository.GetAll();
        }

        public Barrio TraerPorId(int id)
        {
            stringBuilder.Clear();

            if (id == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return entityRepository.GetById(id);
            }

            return null;
        }

        public void Eliminar(int id)
        {
            stringBuilder.Clear();

            if (id == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                entityRepository.Delete(id);
            }
        }

        private bool ValidarEntity(Barrio entity)
        {
            stringBuilder.Clear();

            if (entity.BarrioId == 0) stringBuilder.Append("El campo BarrioId es obligatorio");

            if (String.IsNullOrEmpty(entity.BarrioCodigo)) stringBuilder.Append("El campo BarrioCodigo es obligatorio");

            if (String.IsNullOrEmpty(entity.BarrioNombre)) stringBuilder.Append("El campo BarrioNombre es obligatorio");

            if (String.IsNullOrEmpty(entity.MunicipioCodigo)) stringBuilder.Append("El campo MunicipioCodigo es obligatorio");

            if (String.IsNullOrEmpty(entity.BarrioZona)) stringBuilder.Append("El campo BarrioZona es obligatorio");

            if (String.IsNullOrEmpty(entity.BarrioComuna)) stringBuilder.Append("El campo BarrioComuna es obligatorio");

            if (String.IsNullOrEmpty(entity.BarrioActivo)) stringBuilder.Append("El campo BarrioActivo es obligatorio");

            return stringBuilder.Length == 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}




















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Horus.Businesslogic
//{
//    class BarrioServices
//    {
//    }
//}


