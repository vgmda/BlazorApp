using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccessLibrary;

public class SqlDataAccess
{
    private readonly IConfiguration _config;

    public string ConnectionStringName { get; set; } = "Default";

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
    {
        string connectionString = _config.GetConnectionString(ConnectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            var data = await connection.QueryAsync<T>(sql, parameters);

            return data.ToList();
        }

    }


}

