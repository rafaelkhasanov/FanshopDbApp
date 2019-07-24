using System;
using System.Configuration;
using System.Data;
using FanshopDbDataAccessLibrary.Interface;
using System.Data.SqlClient;
using FanshopDbDataAccessLibrary.BaseModels;
using FanshopDbDataAccessLibrary.BaseModels.BaseEntity;

namespace FashopDbADO
{
    public class FanshopAdoOperations<T>
    {
        private SqlConnection connect;
        protected SqlCommand command;
        protected SqlParameter[] parameters;
        protected string sqlQuery;
        //private InfoProperty infoOfClass = new InfoProperty();
        private string[] propertiesOfT;
        public int Add(T entity)
        {
            //connect.Open();
            //propertiesOfT = infoOfClass.GetPropertiesOfClass(typeof(T));
            //string tableNames = String.Join(",", propertiesOfT);
            //sqlQuery = $"INSERT INTO {typeof(T)} ({tableNames}) VALUES ();
            return 1;
        }

        //public abstract void Add(T entity);

        public T GetOne(int? id) => throw new System.NotImplementedException();

        public void OpenConnection()
        {
            connect = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["FanshopDbADO"].ConnectionString);
            connect.Open();
        }

        public void CloseConnection()
        {
            if (connect?.State != ConnectionState.Closed) connect.Close();
        }

        public int Save() => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
