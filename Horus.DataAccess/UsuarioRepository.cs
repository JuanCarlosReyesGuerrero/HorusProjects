using Horus.Common;
using Horus.Dao;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Horus.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class UsuarioRepository : IBaseService<Usuario>
    {
        readonly Parameters parameters = new Parameters();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetByLogin
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public Usuario GetByLogin(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                dbManager.ExecuteReader("uspObtenerUsuarioLogin", CommandType.StoredProcedure);

                if (dbManager.DataReader.Read())
                {
                    Usuario entity = new Usuario
                    {
                        UsuarioId = Convert.ToInt32(dbManager.DataReader["UsuarioId"]),
                        UsuarioCodigo = Convert.ToString(dbManager.DataReader["UsuarioCodigo"]),
                        UsuarioNombre = Convert.ToString(dbManager.DataReader["UsuarioNombre"]),
                        UsuarioLogin = Convert.ToString(dbManager.DataReader["UsuarioLogin"]),
                        UsuarioPassword = Convert.ToString(dbManager.DataReader["UsuarioPassword"]),
                        UsuarioDireccion = Convert.ToString(dbManager.DataReader["UsuarioDireccion"]),
                        UsuarioTelefono = Convert.ToString(dbManager.DataReader["UsuarioTelefono"]),
                        UsuarioCelular = Convert.ToString(dbManager.DataReader["UsuarioCelular"]),
                        GrupoId = Convert.ToInt32(dbManager.DataReader["GrupoId"]),
                        MedicoId = Convert.ToInt32(dbManager.DataReader["MedicoId"]),
                        UsuarioActivo = Convert.ToString(dbManager.DataReader["UsuarioActivo"]),
                        UsuarioCrea = Convert.ToString(dbManager.DataReader["UsuarioCrea"]),
                        UsuarioModifica = Convert.ToString(dbManager.DataReader["UsuarioModifica"]),
                        UsuarioFechaCreacion = Convert.ToDateTime(dbManager.DataReader["UsuarioFechaCreacion"]),
                        UsuarioFechaModificacion = Convert.ToDateTime(dbManager.DataReader["UsuarioFechaModificacion"])
                    };

                    return entity;
                }
            }
            catch (Exception ex)
            {
                dbManager.Close();

                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }

            return null;
        }

        /// <summary>
        /// GetByPermisoOperacion
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public PermisoOperacion GetByPermisoOperacion(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                dbManager.ExecuteReader("uspObtenerPermisoOperacion", CommandType.StoredProcedure);

                if (dbManager.DataReader.Read())
                {
                    PermisoOperacion entity = new PermisoOperacion
                    {
                        PerfilCodigo = Convert.ToString(dbManager.DataReader["PerfilCodigo"]),
                        PerfilNombre = Convert.ToString(dbManager.DataReader["PerfilNombre"]),
                        OperacionCodigo = Convert.ToString(dbManager.DataReader["OperacionCodigo"]),
                        OperacionNombre = Convert.ToString(dbManager.DataReader["OperacionNombre"]),
                        PerfilOperacionConsultar = Convert.ToBoolean(dbManager.DataReader["PerfilOperacionConsultar"]),
                        PerfilOperacionAgregar = Convert.ToBoolean(dbManager.DataReader["PerfilOperacionAgregar"]),
                        PerfilOperacionEditar = Convert.ToBoolean(dbManager.DataReader["PerfilOperacionEditar"]),
                        PerfilOperacionEliminar = Convert.ToBoolean(dbManager.DataReader["PerfilOperacionEliminar"]),
                        PerfilOperacionActivo = Convert.ToString(dbManager.DataReader["PerfilOperacionActivo"]),
                        PerfilOperacionCrea = Convert.ToString(dbManager.DataReader["PerfilOperacionCrea"]),
                        PerfilOperacionModifica = Convert.ToString(dbManager.DataReader["PerfilOperacionModifica"])
                    };

                    return entity;
                }
            }
            catch (Exception ex)
            {
                dbManager.Close();

                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }

            return null;
        }

        /// <summary>
        /// GetByPermisoOpcionMenu
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public PermisoOpcionMenu GetByPermisoOpcionMenu(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                dbManager.ExecuteReader("uspObtenerPermisoMenu", CommandType.StoredProcedure);

                if (dbManager.DataReader.Read())
                {
                    PermisoOpcionMenu entity = new PermisoOpcionMenu
                    {
                        MenuId = Convert.ToInt32(dbManager.DataReader["MenuId"]),
                        PerfilNombre = Convert.ToString(dbManager.DataReader["PerfilNombre"]),
                        UsuarioPermisoNombrePrograma = Convert.ToString(dbManager.DataReader["UsuarioPermisoNombrePrograma"]),
                        UsuarioPermisoAcceso = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoAcceso"]),
                        UsuarioPermisoInsertar = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoInsertar"]),
                        UsuarioPermisosActualizar = Convert.ToInt32(dbManager.DataReader["UsuarioPermisosActualizar"]),
                        UsuarioPermisoEliminar = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoEliminar"]),
                        UsuarioPermisoImprimir = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoImprimir"]),
                        UsuarioPermisoBuscar = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoBuscar"]),
                        UsuarioPermisoExportar = Convert.ToInt32(dbManager.DataReader["UsuarioPermisoExportar"])
                    };

                    return entity;
                }
            }
            catch (Exception ex)
            {
                dbManager.Close();

                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }

            return null;
        }

        /// <summary>
        /// TraerHashUsuario
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public Usuario TraerHashUsuario(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                dbManager.ExecuteReader("uspObtenerHash", CommandType.StoredProcedure);

                if (dbManager.DataReader.Read())
                {
                    Usuario entity = new Usuario
                    {
                        UsuarioPassword = Convert.ToString(dbManager.DataReader["UsuarioPassword"])
                    };

                    return entity;
                }
            }
            catch (Exception ex)
            {
                dbManager.Close();

                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }

            return null;
        }
    }
}
