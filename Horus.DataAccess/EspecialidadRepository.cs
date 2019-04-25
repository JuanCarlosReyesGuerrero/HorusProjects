using Horus.Common;
using Horus.Dao;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Horus.DataAccess
{
    public class EspecialidadRepository : IBaseService<Especialidad>
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

        /// <summary>
        /// SeleccionarEspecialidades
        /// </summary>
        /// <returns></returns>
        public List<Especialidad> SeleccionarEspecialidades()
        {
            List<Especialidad> entities = new List<Especialidad>();

            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.ExecuteReader("uspTraerEspecialidades", CommandType.StoredProcedure);

                while (dbManager.DataReader.Read())
                {
                    Especialidad entity = new Especialidad
                    {
                        EspecialidadId = Convert.ToInt32(dbManager.DataReader["EspecialidadId"]),
                        EspecialidadNombre = Convert.ToString(dbManager.DataReader["EspecialidadNombre"])
                    };

                    entities.Add(entity);
                }

                if (dbManager.DataReader != null)
                {
                    Especialidad entity = new Especialidad
                    {
                        EspecialidadId = 0,
                        EspecialidadNombre = "[Seleccione uno]"
                    };

                    entities.Add(entity);
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

            return entities;
        }
    }
}
