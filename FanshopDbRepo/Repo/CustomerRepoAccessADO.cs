using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbDAL
{
    class CustomerRepoAccessADO : BaseRepo<BaseCustomer>
    {
        private string sqlQuery;
        private SqlCommand command;
        private SqlParameter[] parameters;
        private SqlConnection connect;
        private int result;

        public override int Add(BaseCustomer entity)
        {
            OpenConnection();
            sqlQuery = $"INSERT INTO Customer (FirstName, LastName, Phone, Email) " +
                $"VALUES (@FirstName, @LastName, @Phone, @Email, @DateOfBirth)";
            using (command = new SqlCommand(sqlQuery))
            {
                parameters = GetParameters(entity);
                command.Parameters.AddRange(parameters);
                result = command.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
        }
        private SqlParameter[] GetParameters(BaseCustomer customer) =>
            new SqlParameter[]
            {
                new SqlParameter()
                {
                    ParameterName = "@FirstName",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = customer.FirstName
                },

                new SqlParameter()
                {
                    ParameterName = @"LastName",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = customer.LastName
                },

                new SqlParameter()
                {
                    ParameterName = "@Phone",
                    SqlDbType = SqlDbType.NChar,
                    Size = 11,
                    Value = customer.Phone,
                    IsNullable = true
                },

                new SqlParameter()
                {
                    ParameterName = @"Email",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 100,
                    Value = customer.Email,
                },

                new SqlParameter()
                {
                    ParameterName = "@DateOfBirth",
                    SqlDbType = SqlDbType.Date,
                    IsNullable = true,
                    Value = customer.DateOfBirth
                }
            };
        private void OpenConnection()
        {
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ADOConnection"].ConnectionString);
            connect?.Open();
        }
        private void CloseConnection()
        {
            if (connect?.State != ConnectionState.Closed) connect.Close();
        }
    }
}
