using System.Data.SqlClient;
using System.Configuration;

namespace ManagementFlorarie.Repository
{
    public class BaseRepo
    {
        public readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        internal void ExecuteNonQuery(string storedProcedureName, params SqlParameter [] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Connection = sqlConnection;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
