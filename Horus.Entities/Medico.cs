using System;

namespace Horus.Entities
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string MedicoCodigo { get; set; }
        public int EspecialidadId { get; set; }
        public string MedicoTipoIdentificacion { get; set; }
        public string MedicoIdentificacion { get; set; }
        public string MedicoRegistroMedico { get; set; }
        public string MedicoApellido1 { get; set; }
        public string MedicoApellido2 { get; set; }
        public string MedicoNombre1 { get; set; }
        public string MedicoNombre2 { get; set; }
        public string MedicoDireccion { get; set; }
        public string MedicoTelefono { get; set; }
        public string MedicoCelular { get; set; }
        public string MedicoEmail { get; set; }
        public string MedicoParametro { get; set; }
        public string MedicoRegistroControl { get; set; }
        public string MedicoPassword { get; set; }
        public string MedicoFirma { get; set; }
        public int MedicoTurno { get; set; }
        public string MedicoActivo { get; set; }
        public string MedicoUsuarioCrea { get; set; }
        public string MedicoUsuarioModifica { get; set; }
        public DateTime MedicoFechaCreacion { get; set; }
        public DateTime MedicoFechaModificacion { get; set; }
    }
}
