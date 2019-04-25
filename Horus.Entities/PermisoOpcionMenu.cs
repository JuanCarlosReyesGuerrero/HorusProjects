namespace Horus.Entities
{
    public class PermisoOpcionMenu
    {
        public string PerfilCodigo { get; set; }
        public int MenuId { get; set; }
        public string PerfilNombre { get; set; }
        public string UsuarioPermisoNombrePrograma { get; set; }
        public bool UsuarioPermisoAcceso { get; set; }
        public bool UsuarioPermisoInsertar { get; set; }
        public bool UsuarioPermisosActualizar { get; set; }
        public bool UsuarioPermisoEliminar { get; set; }
        public bool UsuarioPermisoImprimir { get; set; }
        public bool UsuarioPermisoBuscar { get; set; }
        public bool UsuarioPermisoExportar { get; set; }
    }
}
