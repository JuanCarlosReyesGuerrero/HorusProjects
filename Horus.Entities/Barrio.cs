using System;

namespace Horus.Entities
{
    public class Barrio
    {
        public int BarrioId { get; set; }
        public string BarrioCodigo { get; set; }
        public string BarrioNombre { get; set; }
        public string MunicipioCodigo { get; set; }
        public string BarrioZona { get; set; }
        public string BarrioComuna { get; set; }
        public string BarrioActivo { get; set; }
        public string BarrioUsuarioCrea { get; set; }
        public string BarrioUsuarioModifica { get; set; }
        public DateTime BarrioFechaCreacion { get; set; }
        public DateTime BarrioFechaModificacion { get; set; }
    }
}