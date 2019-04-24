using System;

namespace Horus.Entities
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }

        public string EspecialidadCodigo { get; set; }

        public string EspecialidadNombre { get; set; }

        public bool EspecialidadActivo { get; set; }

        public int EspecialidadUsuarioCrea { get; set; }

        public int EspecialidadUsuarioModifica { get; set; }

        public DateTime EspecialidadFechaCreacion { get; set; }

        public DateTime EspecialidadFechaModificacion { get; set; }
    }
}
