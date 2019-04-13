using Horus.Dao;
using System.Configuration;

namespace Horus.Common
{
    public class Parameters
    {
        public ConnectionStringSettings ConnectionString;
        public Parameters()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConexionPruebas"];

            cadenaConexion();
        }

        //public string ConnectionString = ConfigurationManager.AppSettings["connectionStrings"].ToString();

        public string cadenaConexion()
        {
            // ConnectionString = ConfigurationManager.ConnectionStrings["connectionStrings"];

             return ConnectionString.ToString();            
        }

        public DataProvider validarProveedor()
        {
            DataProvider proveedor = DataProvider.SqlServer;

            if (ConfigurationManager.AppSettings["providerName"] == "SqlServer")
            {
                proveedor = DataProvider.SqlServer;
            }

            return proveedor;
        }
    }
}
