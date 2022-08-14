using Dapper;
using Domain.Models;
using Microsoft.OpenApi.Extensions;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;

namespace ProFind_WebService.Lib.ProjectStatus.DataSource;

public class ProjectStatusDataSource
{
    readonly MySqlConnection _connection;

    public ProjectStatusDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProjectStatus> Get(string id)
    {
        // NOTE: ProjectStatus is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM ProjectStatus WHERE IdPS = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFProjectStatus>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFProjectStatus>> List()
    {
        const string query = "SELECT * FROM ProjectStatus;";

        var result = await _connection.QueryAsync<PFProjectStatus>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFProjectStatus ProjectStatus)
    {
        return false;
    }

    public async Task<bool> Update(string id, PFProjectStatus ProjectStatus)
    {
        const string query =
            "UPDATE ProjectStatus SET NamePS=@Name WHERE IdPS=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = ProjectStatus.GetDisplayName()
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM ProjectStatus WHERE IdPS=@Id;";

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