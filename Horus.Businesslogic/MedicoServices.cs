using Horus.DataAccess;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Businesslogic
{
    public class MedicoServices<TEntity> : IDisposable, IBaseService<Medico> where TEntity : class
    {
        /// <summary>
        /// 
        /// </summary>
        private MedicoRepository<Medico> entityRepository = new MedicoRepository<Medico>();

        /// <summary>
        /// 
        /// </summary>
        public readonly StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Registrar(Medico entity)
        {
            if (ValidarEntity(entity))
            {
                if (entityRepository.GetById(entity.EspecialidadId) == null)
                {
                    entityRepository.Insert(entity);
                }
                else
                    entityRepository.Update(entity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Medico> Todos()
        {
            return entityRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Medico TraerPorId(int id)
        {
            stringBuilder.Clear();

            if (id == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return entityRepository.GetById(id);
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idStudent"></param>
        public void Eliminar(int idStudent)
        {
            stringBuilder.Clear();

            if (idStudent == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                entityRepository.Delete(idStudent);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private bool ValidarEntity(Medico entity)
        {
            stringBuilder.Clear();

            // if (string.IsNullOrEmpty(entity.MedicoId)) stringBuilder.Append("El campo MedicoId es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoCodigo)) stringBuilder.Append("El campo MedicoCodigo es obligatorio");
            // if (string.IsNullOrEmpty(entity.EspecialidadId)) stringBuilder.Append("El campo EspecialidadId es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoTipoIdentificacion)) stringBuilder.Append("El campo MedicoTipoIdentificacion es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoIdentificacion)) stringBuilder.Append("El campo MedicoIdentificacion es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoRegistroMedico)) stringBuilder.Append("El campo MedicoRegistroMedico es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoApellido1)) stringBuilder.Append("El campo MedicoApellido1 es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoApellido2)) stringBuilder.Append("El campo MedicoApellido2 es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoNombre1)) stringBuilder.Append("El campo MedicoNombre1 es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoNombre2)) stringBuilder.Append("El campo MedicoNombre2 es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoDireccion)) stringBuilder.Append("El campo MedicoDireccion es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoTelefono)) stringBuilder.Append("El campo MedicoTelefono es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoCelular)) stringBuilder.Append("El campo MedicoCelular es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoEmail)) stringBuilder.Append("El campo MedicoEmail es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoParametro)) stringBuilder.Append("El campo MedicoParametro es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoRegistroControl)) stringBuilder.Append("El campo MedicoRegistroControl es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoPassword)) stringBuilder.Append("El campo MedicoPassword es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoFirma)) stringBuilder.Append("El campo MedicoFirma es obligatorio");
            //if (string.IsNullOrEmpty(entity.MedicoTurno)) stringBuilder.Append("El campo MedicoTurno es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoActivo)) stringBuilder.Append("El campo MedicoActivo es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoUsuarioCrea)) stringBuilder.Append("El campo MedicoUsuarioCrea es obligatorio");
            if (string.IsNullOrEmpty(entity.MedicoUsuarioModifica)) stringBuilder.Append("El campo MedicoUsuarioModifica es obligatorio");
            //if (string.IsNullOrEmpty(entity.MedicoFechaCreacion)) stringBuilder.Append("El campo MedicoFechaCreacion es obligatorio");
            //if (string.IsNullOrEmpty(entity.MedicoFechaModificacion)) stringBuilder.Append("El campo MedicoFechaModificacion es obligatorio");

            return stringBuilder.Length == 0;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
