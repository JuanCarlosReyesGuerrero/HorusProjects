using Horus.Common.Seguridad;
using Horus.DataAccess;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Horus.Businesslogic
{
    /// <summary>
    /// Usuario Services
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class UsuarioServices : IBaseService<Usuario>
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly UsuarioRepository entityRepository = new UsuarioRepository();

        /// <summary>
        /// 
        /// </summary>
        public readonly StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Registrar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Todos()
        {
            return entityRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idStudent"></param>
        public void Eliminar(int idStudent)
        {
            //stringBuilder.Clear();

            //if (idStudent == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            //if (stringBuilder.Length == 0)
            //{
            //    entityRepository.Delete(idStudent);
            //}
        }

        public Usuario TraerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private bool ValidarEntity(Usuario entity)
        {
            stringBuilder.Clear();

            //// if (string.IsNullOrEmpty(entity.UsuarioId)) stringBuilder.Append("El campo UsuarioId es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioCodigo)) stringBuilder.Append("El campo UsuarioCodigo es obligatorio");
            //// if (string.IsNullOrEmpty(entity.EspecialidadId)) stringBuilder.Append("El campo EspecialidadId es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioTipoIdentificacion)) stringBuilder.Append("El campo UsuarioTipoIdentificacion es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioIdentificacion)) stringBuilder.Append("El campo UsuarioIdentificacion es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioRegistroUsuario)) stringBuilder.Append("El campo UsuarioRegistroUsuario es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioApellido1)) stringBuilder.Append("El campo UsuarioApellido1 es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioApellido2)) stringBuilder.Append("El campo UsuarioApellido2 es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioNombre1)) stringBuilder.Append("El campo UsuarioNombre1 es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioNombre2)) stringBuilder.Append("El campo UsuarioNombre2 es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioDireccion)) stringBuilder.Append("El campo UsuarioDireccion es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioTelefono)) stringBuilder.Append("El campo UsuarioTelefono es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioCelular)) stringBuilder.Append("El campo UsuarioCelular es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioEmail)) stringBuilder.Append("El campo UsuarioEmail es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioParametro)) stringBuilder.Append("El campo UsuarioParametro es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioRegistroControl)) stringBuilder.Append("El campo UsuarioRegistroControl es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioPassword)) stringBuilder.Append("El campo UsuarioPassword es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioFirma)) stringBuilder.Append("El campo UsuarioFirma es obligatorio");
            ////if (string.IsNullOrEmpty(entity.UsuarioTurno)) stringBuilder.Append("El campo UsuarioTurno es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioActivo)) stringBuilder.Append("El campo UsuarioActivo es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioUsuarioCrea)) stringBuilder.Append("El campo UsuarioUsuarioCrea es obligatorio");
            //if (string.IsNullOrEmpty(entity.UsuarioUsuarioModifica)) stringBuilder.Append("El campo UsuarioUsuarioModifica es obligatorio");
            ////if (string.IsNullOrEmpty(entity.UsuarioFechaCreacion)) stringBuilder.Append("El campo UsuarioFechaCreacion es obligatorio");
            ////if (string.IsNullOrEmpty(entity.UsuarioFechaModificacion)) stringBuilder.Append("El campo UsuarioFechaModificacion es obligatorio");

            return stringBuilder.Length == 0;
        }

        /// <summary>
        /// TraerUsuariosLogin
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public Usuario TraerUsuariosLogin(string usuarioLogin)
        {
            stringBuilder.Clear();

            if (usuarioLogin == "") stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return entityRepository.GetByLogin(usuarioLogin);
            }

            return null;
        }

        /// <summary>
        /// Traer Usuarios Permiso Operacion
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public PermisoOperacion TraerUsuariosPermisoOperacion(string usuarioLogin)
        {
            stringBuilder.Clear();

            if (usuarioLogin == "") stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return entityRepository.GetByPermisoOperacion(usuarioLogin);
            }

            return null;
        }

        /// <summary>
        /// Traer Usuarios Permiso Menu
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public PermisoOpcionMenu TraerUsuariosPermisoMenu(string usuarioLogin)
        {
            stringBuilder.Clear();

            if (usuarioLogin == "") stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return entityRepository.GetByPermisoOpcionMenu(usuarioLogin);
            }

            return null;
        }

        /// <summary>
        /// Validar Hash Usuario
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <param name="usuarioPassword"></param>
        /// <returns></returns>
        public bool ValidarHashUsuario(string usuarioLogin, string usuarioPassword)
        {
            classPasswordHash objSeguridad = new classPasswordHash();

            bool vTemp = false;

            stringBuilder.Clear();

            if (usuarioLogin == "") stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {

                Usuario _usuario = entityRepository.TraerHashUsuario(usuarioLogin);

                if (_usuario != null)
                {
                    if (objSeguridad.verifyMd5Hash(usuarioPassword, Convert.ToString(_usuario.UsuarioPassword)))
                    {
                        vTemp = true;
                    }
                    else
                    {
                        vTemp = false;
                    }
                }
            }

            return vTemp;
        }

    }
}
