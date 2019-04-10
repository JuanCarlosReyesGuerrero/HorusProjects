using Horus.DataAccess;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Businesslogic
{
    public class StudentServices
    {
        /// <summary>
        /// 
        /// </summary>
        private StudentRepository studentRepository = new StudentRepository();

        /// <summary>
        /// 
        /// </summary>
        public readonly StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        public void Registrar(Student student)
        {
            if (ValidarProducto(student))
            {
                if (studentRepository.GetByid(student.ID) == null)
                {
                    studentRepository.Insert(student);
                }
                else
                    studentRepository.Update(student);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Student> Todos()
        {
            return studentRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idStudent"></param>
        /// <returns></returns>
        public Student TraerPorId(int idStudent)
        {
            stringBuilder.Clear();

            if (idStudent == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return studentRepository.GetByid(idStudent);
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
                studentRepository.Delete(idStudent);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        private bool ValidarProducto(Student student)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(student.LastName)) stringBuilder.Append("El campo Descripción es obligatorio");
            if (string.IsNullOrEmpty(student.FirstMidName)) stringBuilder.Append(Environment.NewLine + "El campo Marca es obligatorio");
            //if (string.IsNullOrEmpty(student.EnrollmentDate)) stringBuilder.Append(Environment.NewLine + "El campo Marca es obligatorio");
            //if (student.Precio <= 0) stringBuilder.Append(Environment.NewLine + "El campo Precio es obligatorio");

            return stringBuilder.Length == 0;
        }
    }
}
