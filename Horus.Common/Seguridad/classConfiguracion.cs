using System;

namespace Horus.Common.Seguridad
{
    public class classConfiguracion
    {
        #region MIEMBROS

        /// <summary>
        /// Ruta de la aplicación principal
        /// </summary>
        private string _RutaAppSettings;

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Ruta de la aplicación principal
        /// </summary>
        public string RutaAppSettings
        {
            get { return _RutaAppSettings; }
        }

        #endregion

        #region CONSTRUCTORES

        public classConfiguracion(string vRutaAppSettings)
        {
            try
            {
                _RutaAppSettings = vRutaAppSettings;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region FUNCIONES

        /// <summary>
        /// Funcion para traer la ruta de la aplicación principal
        /// </summary>
        /// <returns>Un String con la ruta de la aplicación de mantenimiento</returns>
        public string PathMantenimiento()
        {
            try
            {
                System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                string strPathMantenimiento = null;

                XmlDoc.Load(RutaAppSettings);
                foreach (System.Xml.XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "appSettings")
                    {
                        foreach (System.Xml.XmlNode xNode in xElement.ChildNodes)
                        {
                            if ((xNode.Attributes != null))
                            {
                                if (xNode.Attributes[0].Value == "PathMantenimiento")
                                {
                                    strPathMantenimiento = xNode.Attributes[1].Value;
                                }
                            }
                        }
                    }
                }

                return strPathMantenimiento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Funcion para traer la ruta de la aplicación principal
        /// </summary>
        /// <returns>Un String con la ruta de la aplicación principal</returns>
        public string PathAplicacion()
        {
            try
            {
                System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                string strPathAplicacion = null;

                XmlDoc.Load(RutaAppSettings);
                foreach (System.Xml.XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "appSettings")
                    {
                        foreach (System.Xml.XmlNode xNode in xElement.ChildNodes)
                        {
                            if ((xNode.Attributes != null))
                            {
                                if (xNode.Attributes[0].Value == "PathAplicacion")
                                {
                                    strPathAplicacion = xNode.Attributes[1].Value;
                                }
                            }
                        }
                    }
                }

                return strPathAplicacion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Funcion para traer la ruta de los reportes
        /// </summary>
        /// <returns>Un String con la ruta de la aplicación de mantenimiento</returns>
        public string PathReportes()
        {
            try
            {
                System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                string strPathMantenimiento = null;

                XmlDoc.Load(RutaAppSettings);
                foreach (System.Xml.XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "appSettings")
                    {
                        foreach (System.Xml.XmlNode xNode in xElement.ChildNodes)
                        {
                            if ((xNode.Attributes != null))
                            {
                                if (xNode.Attributes[0].Value == "PathReportes")
                                {
                                    strPathMantenimiento = xNode.Attributes[1].Value;
                                }
                            }
                        }
                    }
                }

                return strPathMantenimiento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
