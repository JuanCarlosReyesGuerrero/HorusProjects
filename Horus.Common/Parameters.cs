using Horus.Dao;
using System.Configuration;

namespace Horus.Common
{
    public class Parameters
    {
        public Parameters()
        {

        }

        public string ConnectionString = ConfigurationManager.AppSettings["connectionStrings"].ToString();

        public DataProvider validarProveedor()
        {
            DataProvider proveedor = DataProvider.SqlServer;

            if (ConfigurationManager.AppSettings["providerName"] == "SqlServer")
            {
                proveedor =  DataProvider.SqlServer;
            }
            
            return proveedor;
        }        
    }
}
