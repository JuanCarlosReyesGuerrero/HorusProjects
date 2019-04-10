using System.Data;

namespace Horus.Dao
{
    public interface IDBManager
    {
        DataProvider ProviderType
        {
            get;
            set;
        }

        string ConnectionString
        {
            get;
            set;
        }

        IDbConnection Connection
        {
            get;
        }

        IDbTransaction Transaction
        {
            get;
        }

        IDataReader DataReader
        {
            get;
        }
        IDbCommand Command
        {
            get;
        }

        IDbDataParameter[] Parameters
        {
            get;
        }

        void Open();
        void BeginTransaction();
        void CommitTransaction();
        void CreateParameters(int paramsCount);
        void AddParameters(int index, string paramName, object objValue);
        IDataReader ExecuteReader(string commandText, CommandType commandType);
        DataSet ExecuteDataSet(string commandText, CommandType commandType);
        object ExecuteScalar(string commandText, CommandType commandType);
        int ExecuteNonQuery(string commandText, CommandType commandType);
        void CloseReader();
        void Close();
        void Dispose();
    }
}
