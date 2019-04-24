namespace Horus.Entities
{
    public class PermisoOpcionMenu
    {
        public string PerfilCodigo { get; set; }
        public int MenuId { get; set; }
        public string PerfilNombre { get; set; }
        public string UsuarioPermisoNombrePrograma { get; set; }
        public int UsuarioPermisoAcceso { get; set; }
        public int UsuarioPermisoInsertar { get; set; }
        public int UsuarioPermisosActualizar { get; set; }
        public int UsuarioPermisoEliminar { get; set; }
        public int UsuarioPermisoImprimir { get; set; }
        public int UsuarioPermisoBuscar { get; set; }
        public int UsuarioPermisoExportar { get; set; }
    }
}
