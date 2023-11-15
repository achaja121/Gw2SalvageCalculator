using Dapper;
using Gw2SalvageCalculator.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Gw2SalvageCalculator.DataAccess.DataAccess
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        private readonly string _connectionStringId = "Default";

        private readonly IConfiguration _configuration;

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters)
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(_connectionStringId));

            return await connection
                .QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<int> InsertDataAsync<T>(string storedProcedure, T parameters)
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(_connectionStringId));

            return await connection
                .ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}