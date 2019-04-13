using Horus.Common;
using Horus.Dao;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Horus.DataAccess
{
    public class UsuarioRepository<TEntity> : IDisposable, IBaseService<Usuario> where TEntity : class
    {
        Parameters parameters = new Parameters();

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

        public DataSet TraerUsuariosLogin(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                DataSet dsTemp = dbManager.ExecuteDataSet("uspObtenerUsuarioLogin", CommandType.StoredProcedure);

                dbManager.Close();

                return dsTemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }
        }

        /// <summary>
        /// Trae el password del usuario
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// <returns></returns>
        public DataTable TraerHashUsuario(string usuarioLogin)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(1);

                dbManager.AddParameters(0, "@UsuarioLogin", usuarioLogin);

                DataSet dsTemp = dbManager.ExecuteDataSet("uspObtenerHash", CommandType.StoredProcedure);

                dbManager.Close();

                return dsTemp.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }
        }
    }
}
