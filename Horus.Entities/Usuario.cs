using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioCodigo { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioPassword { get; set; }
        public string UsuarioDireccion { get; set; }
        public string UsuarioTelefono { get; set; }
        public string UsuarioCelular { get; set; }
        public int GrupoId { get; set; }
        public int MedicoId { get; set; }
        public string UsuarioActivo { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime UsuarioFechaCreacion { get; set; }
        public DateTime UsuarioFechaModificacion { get; set; }
    }
}
