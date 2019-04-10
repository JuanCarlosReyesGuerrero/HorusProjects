using Horus.Dao;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace Horus.DataAccess
{
    public class StudentRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        public void Insert(Student student)
        {
            IDBManager dbManager = new DBManager(DataProvider.SqlServer);

            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString "].ToString();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                dbManager.AddParameters(0, "@ID", student.ID);
                dbManager.AddParameters(1, "@FirstMidName", student.FirstMidName);
                dbManager.AddParameters(2, "@LastName", student.LastName);
                dbManager.AddParameters(3, "@EnrollmentDate", student.EnrollmentDate);

                dbManager.ExecuteNonQuery("Customer_Insert", CommandType.StoredProcedure);
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
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            IDBManager dbManager = new DBManager(DataProvider.SqlServer);

            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            try
            {
                dbManager.Open();

                dbManager.ExecuteReader("Customer_Insert", CommandType.StoredProcedure);
                
                while (dbManager.DataReader.Read())
                {
                    Student student = new Student
                    {
                        ID = Convert.ToInt32(dbManager.DataReader["ID"]),
                        FirstMidName = Convert.ToString(dbManager.DataReader["FirstMidName"]),
                        LastName = Convert.ToString(dbManager.DataReader["LastName"]),
                        EnrollmentDate = Convert.ToDateTime(dbManager.DataReader["EnrollmentDate"])
                    };

                    students.Add(student);
                }
            }
            catch (Exception ex)
            {
                //Usual Code
            }
            finally
            {
                dbManager.Dispose();
            }

            return students;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idStudent"></param>
        /// <returns></returns>
        public Student GetByid(int idStudent)
        {
            IDBManager dbManager = new DBManager(DataProvider.SqlServer);

            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@id", idStudent);

                dbManager.ExecuteReader("Customer_Insert", CommandType.StoredProcedure);

                //while (dbManager.DataReader.Read())
                //    Response.Write(dbManager.DataReader["name"].ToString());

                if (dbManager.DataReader.Read())
                {
                    Student student = new Student
                    {
                        ID = Convert.ToInt32(dbManager.DataReader["ID"]),
                        FirstMidName = Convert.ToString(dbManager.DataReader["FirstMidName"]),
                        LastName = Convert.ToString(dbManager.DataReader["LastName"]),
                        EnrollmentDate = Convert.ToDateTime(dbManager.DataReader["EnrollmentDate"])
                    };

                    return student;
                }
            }
            catch (Exception ex)
            {
                //Usual Code
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
        /// <param name="student"></param>
        public void Update(Student student)
        {
            IDBManager dbManager = new DBManager(DataProvider.SqlServer);

            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString "].ToString();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                dbManager.AddParameters(0, "@ID", student.ID);
                dbManager.AddParameters(1, "@FirstMidName", student.FirstMidName);
                dbManager.AddParameters(2, "@LastName", student.LastName);
                dbManager.AddParameters(3, "@EnrollmentDate", student.EnrollmentDate);

                dbManager.ExecuteNonQuery("Customer_Insert", CommandType.StoredProcedure);
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
        /// 
        /// </summary>
        /// <param name="idEstudent"></param>
        public void Delete(int idEstudent)
        {
            IDBManager dbManager = new DBManager(DataProvider.SqlServer);

            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString "].ToString();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@ID", idEstudent);                

                dbManager.ExecuteNonQuery("Customer_Insert", CommandType.StoredProcedure);
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
