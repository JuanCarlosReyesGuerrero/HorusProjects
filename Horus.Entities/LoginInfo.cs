namespace Horus.Entities
{
    public static class LoginInfo
    {
        /// <summary>
        /// Login del usuario
        /// </summary>
        public static string VgUsuarioCodigo { get; set; }

        /// <summary>
        /// Id del usuario
        /// </summary>
        public static int VgUsuarioId { get; set; }

        /// <summary>
        /// Id de la clínica
        /// </summary>
        public static string VgHospitalId { get; set; }

        /// <summary>
        /// Tabla de permisos de las operaciones
        /// </summary>
        public static object VgPermisoOperaciones { get; set; }

        /// <summary>
        /// Tabla de permisos de opciones de los roles
        /// </summary>
        public static object VgPermisosRoles { get; set; }
    }
}
