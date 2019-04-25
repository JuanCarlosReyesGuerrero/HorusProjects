using Horus.Common;
using Horus.Dao;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Horus.DataAccess
{
    public class MedicoRepository : IBaseService<Medico> 
    {
        Parameters parameters = new Parameters();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@ID", id);

                dbManager.ExecuteNonQuery("uspEliminarMedicos", CommandType.StoredProcedure);

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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Medico> GetAll()
        {
            List<Medico> entities = new List<Medico>();

            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.ExecuteReader("uspTraerMedicos", CommandType.StoredProcedure);

                while (dbManager.DataReader.Read())
                {
                    Medico entity = new Medico
                    {
                        MedicoId = Convert.ToInt32(dbManager.DataReader["MedicoId"]),
                        MedicoCodigo = Convert.ToString(dbManager.DataReader["MedicoCodigo"]),
                        EspecialidadId = Convert.ToInt32(dbManager.DataReader["EspecialidadId"]),
                        MedicoTipoIdentificacion = Convert.ToString(dbManager.DataReader["MedicoTipoIdentificacion"]),
                        MedicoIdentificacion = Convert.ToString(dbManager.DataReader["MedicoIdentificacion"]),
                        MedicoRegistroMedico = Convert.ToString(dbManager.DataReader["MedicoRegistroMedico"]),
                        MedicoApellido1 = Convert.ToString(dbManager.DataReader["MedicoApellido1"]),
                        MedicoApellido2 = Convert.ToString(dbManager.DataReader["MedicoApellido2"]),
                        MedicoNombre1 = Convert.ToString(dbManager.DataReader["MedicoNombre1"]),
                        MedicoNombre2 = Convert.ToString(dbManager.DataReader["MedicoNombre2"]),
                        MedicoDireccion = Convert.ToString(dbManager.DataReader["MedicoDireccion"]),
                        MedicoTelefono = Convert.ToString(dbManager.DataReader["MedicoTelefono"]),
                        MedicoCelular = Convert.ToString(dbManager.DataReader["MedicoCelular"]),
                        MedicoEmail = Convert.ToString(dbManager.DataReader["MedicoEmail"]),
                        MedicoParametro = Convert.ToString(dbManager.DataReader["MedicoParametro"]),
                        MedicoRegistroControl = Convert.ToString(dbManager.DataReader["MedicoRegistroControl"]),
                        MedicoPassword = Convert.ToString(dbManager.DataReader["MedicoPassword"]),
                        MedicoFirma = Convert.ToString(dbManager.DataReader["MedicoFirma"]),
                        MedicoTurno = Convert.ToInt32(dbManager.DataReader["MedicoTurno"]),
                        MedicoActivo = Convert.ToString(dbManager.DataReader["MedicoActivo"]),
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Medico GetById(int id)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@id", id);

                dbManager.ExecuteReader("Customer_Insert", CommandType.StoredProcedure);

                if (dbManager.DataReader.Read())
                {
                    Medico entity = new Medico
                    {
                        MedicoId = Convert.ToInt32(dbManager.DataReader["MedicoId"]),
                        MedicoCodigo = Convert.ToString(dbManager.DataReader["MedicoCodigo"]),
                        EspecialidadId = Convert.ToInt32(dbManager.DataReader["EspecialidadId"]),
                        MedicoTipoIdentificacion = Convert.ToString(dbManager.DataReader["MedicoTipoIdentificacion"]),
                        MedicoIdentificacion = Convert.ToString(dbManager.DataReader["MedicoIdentificacion"]),
                        MedicoRegistroMedico = Convert.ToString(dbManager.DataReader["MedicoRegistroMedico"]),
                        MedicoApellido1 = Convert.ToString(dbManager.DataReader["MedicoApellido1"]),
                        MedicoApellido2 = Convert.ToString(dbManager.DataReader["MedicoApellido2"]),
                        MedicoNombre1 = Convert.ToString(dbManager.DataReader["MedicoNombre1"]),
                        MedicoNombre2 = Convert.ToString(dbManager.DataReader["MedicoNombre2"]),
                        MedicoDireccion = Convert.ToString(dbManager.DataReader["MedicoDireccion"]),
                        MedicoTelefono = Convert.ToString(dbManager.DataReader["MedicoTelefono"]),
                        MedicoCelular = Convert.ToString(dbManager.DataReader["MedicoCelular"]),
                        MedicoEmail = Convert.ToString(dbManager.DataReader["MedicoEmail"]),
                        MedicoParametro = Convert.ToString(dbManager.DataReader["MedicoParametro"]),
                        MedicoRegistroControl = Convert.ToString(dbManager.DataReader["MedicoRegistroControl"]),
                        MedicoPassword = Convert.ToString(dbManager.DataReader["MedicoPassword"]),
                        MedicoFirma = Convert.ToString(dbManager.DataReader["MedicoFirma"]),
                        MedicoTurno = Convert.ToInt32(dbManager.DataReader["MedicoTurno"]),
                        MedicoActivo = Convert.ToString(dbManager.DataReader["MedicoActivo"])
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
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(Medico entity)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(24);

                dbManager.AddParameters(0, "@MedicoId", entity.MedicoId);
                dbManager.AddParameters(1, "@MedicoCodigo", entity.MedicoCodigo);
                dbManager.AddParameters(2, "@EspecialidadId", entity.EspecialidadId);
                dbManager.AddParameters(3, "@MedicoTipoIdentificacion", entity.MedicoTipoIdentificacion);
                dbManager.AddParameters(4, "@MedicoIdentificacion", entity.MedicoIdentificacion);
                dbManager.AddParameters(5, "@MedicoRegistroMedico", entity.MedicoRegistroMedico);
                dbManager.AddParameters(6, "@MedicoApellido1", entity.MedicoApellido1);
                dbManager.AddParameters(7, "@MedicoApellido2", entity.MedicoApellido2);
                dbManager.AddParameters(8, "@MedicoNombre1", entity.MedicoNombre1);
                dbManager.AddParameters(9, "@MedicoNombre2", entity.MedicoNombre2);
                dbManager.AddParameters(10, "@MedicoDireccion", entity.MedicoDireccion);
                dbManager.AddParameters(11, "@MedicoTelefono", entity.MedicoTelefono);
                dbManager.AddParameters(12, "@MedicoCelular", entity.MedicoCelular);
                dbManager.AddParameters(13, "@MedicoEmail", entity.MedicoEmail);
                dbManager.AddParameters(14, "@MedicoParametro", entity.MedicoParametro);
                dbManager.AddParameters(15, "@MedicoRegistroControl", entity.MedicoRegistroControl);
                dbManager.AddParameters(16, "@MedicoPassword", entity.MedicoPassword);
                dbManager.AddParameters(17, "@MedicoFirma", entity.MedicoFirma);
                dbManager.AddParameters(18, "@MedicoTurno", entity.MedicoTurno);
                dbManager.AddParameters(19, "@MedicoActivo", entity.MedicoActivo);
                dbManager.AddParameters(20, "@MedicoUsuarioCrea", entity.MedicoUsuarioCrea);
                dbManager.AddParameters(21, "@MedicoUsuarioModifica", entity.MedicoUsuarioModifica);
                dbManager.AddParameters(22, "@MedicoFechaCreacion", entity.MedicoFechaCreacion);
                dbManager.AddParameters(23, "@MedicoFechaModificacion", entity.MedicoFechaModificacion);

                dbManager.ExecuteNonQuery("uspInsertarMedicos", CommandType.StoredProcedure);

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Medico entity)
        {
            IDBManager dbManager = new DBManager(parameters.validarProveedor());

            dbManager.ConnectionString = parameters.cadenaConexion();

            try
            {
                dbManager.Open();

                dbManager.CreateParameters(24);

                dbManager.AddParameters(0, "@MedicoId", entity.MedicoId);
                dbManager.AddParameters(1, "@MedicoCodigo", entity.MedicoCodigo);
                dbManager.AddParameters(2, "@EspecialidadId", entity.EspecialidadId);
                dbManager.AddParameters(3, "@MedicoTipoIdentificacion", entity.MedicoTipoIdentificacion);
                dbManager.AddParameters(4, "@MedicoIdentificacion", entity.MedicoIdentificacion);
                dbManager.AddParameters(5, "@MedicoRegistroMedico", entity.MedicoRegistroMedico);
                dbManager.AddParameters(6, "@MedicoApellido1", entity.MedicoApellido1);
                dbManager.AddParameters(7, "@MedicoApellido2", entity.MedicoApellido2);
                dbManager.AddParameters(8, "@MedicoNombre1", entity.MedicoNombre1);
                dbManager.AddParameters(9, "@MedicoNombre2", entity.MedicoNombre2);
                dbManager.AddParameters(10, "@MedicoDireccion", entity.MedicoDireccion);
                dbManager.AddParameters(11, "@MedicoTelefono", entity.MedicoTelefono);
                dbManager.AddParameters(12, "@MedicoCelular", entity.MedicoCelular);
                dbManager.AddParameters(13, "@MedicoEmail", entity.MedicoEmail);
                dbManager.AddParameters(14, "@MedicoParametro", entity.MedicoParametro);
                dbManager.AddParameters(15, "@MedicoRegistroControl", entity.MedicoRegistroControl);
                dbManager.AddParameters(16, "@MedicoPassword", entity.MedicoPassword);
                dbManager.AddParameters(17, "@MedicoFirma", entity.MedicoFirma);
                dbManager.AddParameters(18, "@MedicoTurno", entity.MedicoTurno);
                dbManager.AddParameters(19, "@MedicoActivo", entity.MedicoActivo);
                dbManager.AddParameters(20, "@MedicoUsuarioCrea", entity.MedicoUsuarioCrea);
                dbManager.AddParameters(21, "@MedicoUsuarioModifica", entity.MedicoUsuarioModifica);
                dbManager.AddParameters(22, "@MedicoFechaCreacion", entity.MedicoFechaCreacion);
                dbManager.AddParameters(23, "@MedicoFechaModificacion", entity.MedicoFechaModificacion);

                dbManager.ExecuteNonQuery("uspActualizarMedicos", CommandType.StoredProcedure);

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
        }
    }
}
