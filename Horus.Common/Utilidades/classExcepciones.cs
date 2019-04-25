using System;

namespace Horus.Common.Utilidades
{
    public class ClassExcepciones
    {

        public Seguridad.ClassConfiguracion objConfiguracion = new Seguridad.ClassConfiguracion(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

        #region MIEMBROS

        string _strLog;
        string _strRuta;
        string _strEncabezado;
        string _strPie;

        string _strPathMantenimiento;

        #endregion

        #region PROPIEDADES

        public string StrLog
        {
            get { return _strLog; }
        }

        public string StrRuta
        {
            get { return _strRuta; }
        }

        public string StrEncabezado
        {
            get { return _strEncabezado; }
        }

        public string StrPie
        {
            get { return _strPie; }
        }

        public string StrPathMantenimiento
        {
            get { return _strPathMantenimiento; }
        }

        #endregion

        #region CONSTRUCTORES

        public ClassExcepciones()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region FUNCIONES

        /// <summary>
        /// Trae la ruta donde se aloja la aplicación de acuerdo al app.config
        /// </summary>
        /// <returns></returns>
        public string PathMantenimiento()
        {
            try
            {
                _strPathMantenimiento = objConfiguracion.PathMantenimiento();

                return _strPathMantenimiento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region PROCEDIMIENTOS

        /// <summary>
        /// Procedimiento que escribe la excepción en el disco físico
        /// </summary>
        /// <param name="vPagina"></param>
        /// <param name="vNomCtrl"></param>
        /// <param name="vException"></param>
        public void EscribirExcepcion(string vPagina, string vNomCtrl, Exception vException)
        {
            try
            {
                //CultureInfo ci = Thread.CurrentThread.CurrentCulture;

                DateTime vFechaActualCorta = DateTime.Now;
                string vFechaActualLarga = DateTime.Now.ToLongDateString();
                string vHoraActualLarga = DateTime.Now.ToLongTimeString();

                //_strRuta = PathMantenimiento() + "\\Logs\\ex" + Convert.ToString(String.Format(Convert.ToString(DateTime.Now), "ddMMMyyyy")) + ".txt";
                _strRuta = PathMantenimiento() + "\\Logs\\ex" + DateTime.Now.ToString("ddMMMyyyy") + ".txt";
                _strEncabezado = "---------------------------------------------------------------------------------------------------" + ControlChars.NewLine;
                _strLog = _strEncabezado;

                _strLog = _strLog + "Fecha y Hora:" + ControlChars.Tab + vFechaActualLarga + "--" + vHoraActualLarga + ControlChars.NewLine;

                _strLog = _strLog + "Página: " + ControlChars.Tab + vPagina + ControlChars.NewLine;

                _strLog = _strLog + "Evento: " + ControlChars.Tab + vNomCtrl + ControlChars.NewLine;

                _strLog = _strLog + "Excepción: " + ControlChars.Tab + vException.GetType() + ControlChars.NewLine;

                _strLog = _strLog + "Mensaje: " + ControlChars.Tab + vException.Message + ControlChars.NewLine;

                _strLog = _strLog + "Stack Trace: " + ControlChars.Tab + vException.StackTrace + ControlChars.NewLine;

                _strPie = "---------------------------------------------------------------------------------------------------" + ControlChars.NewLine;

                _strLog = _strLog + _strPie;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(_strRuta, true);
                sw.WriteLine(_strLog);
                sw.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
    }

    /// <summary>
    /// Clase utilizada para los controles de línea
    /// </summary>
    public sealed class ControlChars
    {
        public const char Back = '\b';
        public const char Cr = '\r';
        public const string CrLf = "\r\n";
        public const char FormFeed = '\f';
        public const char Lf = '\n';
        public const string NewLine = "\r\n";
        public const char NullChar = '\0';
        public const char Quote = '"';
        public const char Tab = '\t';
        public const char VerticalTab = '\v';
    }
}
