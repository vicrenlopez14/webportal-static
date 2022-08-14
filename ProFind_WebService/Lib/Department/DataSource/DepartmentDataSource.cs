using Dapper;
using Domain.Models;
using Microsoft.OpenApi.Extensions;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;

namespace ProFind_WebService.Lib.Department.DataSource;

public class DepartmentDataSource
{
    readonly MySqlConnection _connection;

    public DepartmentDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFDepartment> Get(string id)
    {
        // NOTE: Department is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Department WHERE IdDP = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFDepartment>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFDepartment>> List()
    {
        const string query = "SELECT * FROM Department;";

        var result = await _connection.QueryAsync<PFDepartment>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFDepartment Department)
    {
        return false;
    }

    public async Task<bool> Update(string id, PFDepartment Department)
    {
        const string query =
            "UPDATE Department SET NameDP=@Name WHERE IdDP=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = Department.NameDP
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Department WHERE IdDP=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
            {
                ["Id"] = id
            }
        );

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}