namespace Horus.Entities
{
    public class PermisoOperacion
    {
        public string PerfilCodigo { get; set; }
        public string PerfilNombre { get; set; }
        public string OperacionCodigo { get; set; }
        public string OperacionNombre { get; set; }
        public bool PerfilOperacionConsultar { get; set; }
        public bool PerfilOperacionAgregar { get; set; }
        public bool PerfilOperacionEditar { get; set; }
        public bool PerfilOperacionEliminar { get; set; }
        public string PerfilOperacionActivo { get; set; }
        public string PerfilOperacionCrea { get; set; }
        public string PerfilOperacionModifica { get; set; }
    }
}
