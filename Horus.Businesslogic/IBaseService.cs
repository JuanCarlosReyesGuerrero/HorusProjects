using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Businesslogic
{
    /// <summary>
    /// Interfaz genérica que puede ser utilizado por cualquier entidad.
    /// </summary>
    /// <typeparam name="TEntity">Corresponde a la entidad con la cual van a trabajar los métodos de esta 
    /// interfaz, por ejemplo: entidad de tipo “Permiso”/”Persona”/”Usuario”.
    /// </typeparam>
    public interface IBaseService<TEntity> where TEntity : class
    {
        /// <summary>
        /// Método que permite ingresar una entidad
        /// </summary>
        /// <param name="entity">Corresponde a la entidad que se desea agregar</param>
        void Registrar(TEntity entity);

        /// <summary>
        /// Método que permite eliminar una entidad
        /// </summary>
        /// <param name="id">Corresponde al identificador de la entidad que se desea eliminar</param>
        void Eliminar(int id);        

        /// <summary>
        /// Método que permite obtener todos los registros pertenecientes a esa entidad
        /// </summary>
        /// <returns>Todos los objetos de ese tipo de entidad</returns>
        List<TEntity> Todos();

        /// <summary>
        /// Método que permite obtener la información correspondiente a la entidad solicitada
        /// </summary>
        /// <param name="id">Corresponde al identificador de la entidad que se desea obtener</param>
        /// <returns>La información de la correspondiente entidad</returns>
        TEntity TraerPorId(int id);

        void Dispose();
    }
}
