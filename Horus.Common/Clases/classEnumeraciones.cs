namespace Horus.Common.Clases
{
    /// <summary>
    /// 
    /// </summary>
    public class ClassEnumeraciones
    {
        #region ENUMERACIONES

        /// <summary>
        /// Permisos roles
        /// </summary>
        public enum enumPermisosRoles
        {
            /// <summary>
            /// The usuario permiso acceso
            /// </summary>
            UsuarioPermisoAcceso = 1,

            /// <summary>
            /// The usuario permiso insertar
            /// </summary>
            UsuarioPermisoInsertar = 2,

            /// <summary>
            /// The usuario permisos actualizar
            /// </summary>
            UsuarioPermisosActualizar = 3,

            /// <summary>
            /// The usuario permiso eliminar
            /// </summary>
            UsuarioPermisoEliminar = 4,

            /// <summary>
            /// The usuario permiso imprimir
            /// </summary>
            UsuarioPermisoImprimir = 5,

            /// <summary>
            /// The usuario permiso buscar
            /// </summary>
            UsuarioPermisoBuscar = 6,

            /// <summary>
            /// The usuario permiso exportar
            /// </summary>
            UsuarioPermisoExportar = 7,
        }

        /// <summary>
        /// Enumeración de las opciones del menu
        /// </summary>
        public enum enumOpcionesMenu
        {
            /// <summary>
            /// The home
            /// </summary>
            Home = 100,

            /// <summary>
            /// The archivo
            /// </summary>
            Archivo = 200,

            /// <summary>
            /// The pacientes
            /// </summary>
            Pacientes = 201,

            /// <summary>
            /// The admision integral
            /// </summary>
            AdmisionIntegral = 202,

            /// <summary>
            /// The egreso paciente
            /// </summary>
            EgresoPaciente = 203,

            /// <summary>
            /// The monitores
            /// </summary>
            Monitores = 204,

            /// <summary>
            /// The historia clinica
            /// </summary>
            HistoriaClinica = 205,

            /// <summary>
            /// The lista pacientes
            /// </summary>
            ListaPacientes = 207,

            /// <summary>
            /// The configuración
            /// </summary>
            ConfiguracionHC = 300,

            /// <summary>
            /// The configuracion general
            /// </summary>
            ConfiguracionGeneral = 301,

            /// <summary>
            /// The configuracion detalle
            /// </summary>
            ConfiguracionDetalle = 302,

            /// <summary>
            /// The reportes
            /// </summary>
            Reportes = 400,

            /// <summary>
            /// The herramientas
            /// </summary>
            Herramientas = 500,

            /// <summary>
            /// The perfiles operaciones
            /// </summary>
            PerfilesOperaciones = 501,

            /// <summary>
            /// The usuarios
            /// </summary>
            Usuarios = 502,

            /// <summary>
            /// The usuarios permisos
            /// </summary>
            UsuariosPermisos = 503,

            /// <summary>
            /// The patologías
            /// </summary>
            Patologias = 504,

            /// <summary>
            /// The procedimientos
            /// </summary>
            Procedimientos = 505,

            /// <summary>
            /// The suministros
            /// </summary>
            Suministros = 506,

            /// <summary>
            /// The medicos
            /// </summary>
            Medicos = 507,

            /// <summary>
            /// The dispositivos
            /// </summary>
            Dispositivos = 508,

            /// <summary>
            /// The ips
            /// </summary>
            Ips = 509,

            /// <summary>
            /// The ocupaciones
            /// </summary>
            Ocupaciones = 510,

            /// <summary>
            /// The constantes
            /// </summary>
            Constantes = 511,

            /// <summary>
            /// The dosis
            /// </summary>
            Dosis = 512,

            /// <summary>
            /// The parametros signos vitales
            /// </summary>
            ParametrosSignosVitales = 513,

            /// <summary>
            /// The ayuda
            /// </summary>
            Ayuda = 600,
        }

        /// <summary>
        /// Enumeración estados del paciente
        /// </summary>
        public enum enumEstadosPaciente
        {
            /// <summary>
            /// Estado pendiente
            /// </summary>
            Pendiente = 1,

            /// <summary>
            /// Estado facturado
            /// </summary>
            Facturado = 2,

            /// <summary>
            /// Estado anulado
            /// </summary>
            Anulado = 3,
        }

        /// <summary>
        /// Estado de la cuenta de la admisión
        /// </summary>
        public enum enumEstadoCuenta
        {
            /// <summary>
            /// Inactivo
            /// </summary>
            Pendiente = 0,

            /// <summary>
            /// Activo
            /// </summary>
            Facturada = 1,
        }

        /// <summary>
        /// Estado de la salida
        /// </summary>
        public enum enumEstadoSalida
        {
            /// <summary>
            /// Inactivo
            /// </summary>
            Vivo = 1,

            /// <summary>
            /// Activo
            /// </summary>
            Muerto = 2,
        }

        /// <summary>
        /// Ultimos numeros de las enumeraciones
        /// </summary>
        public enum enumEnumeraciones
        {
            /// <summary>
            /// Ultimo número del folio
            /// </summary>
            FOLIO = 1,

            /// <summary>
            /// Ultimo Numero Procedimientos
            /// </summary>
            UNPRO = 2,

            /// <summary>
            /// Ultimo Numero Suministros
            /// </summary>
            UNSUM = 3,
        }

        /// <summary>
        /// Enumeración tipo de manual
        /// </summary>
        public enum enumTipoManual
        {
            /// <summary>
            /// The procedimiento
            /// </summary>
            Procedimiento = 1,

            /// <summary>
            /// The quirurgico
            /// </summary>
            Quirurgico = 2,

            /// <summary>
            /// The suministro
            /// </summary>
            Suministro = 3,

            /// <summary>
            /// The estancia
            /// </summary>
            Estancia = 4,
        }

        #endregion
    }
}