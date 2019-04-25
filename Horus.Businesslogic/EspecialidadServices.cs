using Horus.DataAccess;
using Horus.Entities;
using System;
using System.Collections.Generic;

namespace Horus.Businesslogic
{
    public class EspecialidadServices : IBaseService<Especialidad>
    {
        private readonly EspecialidadRepository especialidadRepository = new EspecialidadRepository();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Registrar(Especialidad entity)
        {
            throw new NotImplementedException();
        }

        public List<Especialidad> Todos()
        {
            throw new NotImplementedException();
        }

        public Especialidad TraerPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SeleccionarEspecialidades
        /// </summary>
        /// <returns></returns>
        public List<Especialidad> SeleccionarEspecialidades()
        {
            return especialidadRepository.SeleccionarEspecialidades();
        }
    }
}
