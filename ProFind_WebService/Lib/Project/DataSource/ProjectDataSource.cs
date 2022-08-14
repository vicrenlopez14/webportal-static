using Dapper;
using Domain.Models;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;

namespace ProFind_WebService.Lib.Project.DataSource;

public class ProjectDataSource
{
    readonly MySqlConnection _connection;

    public ProjectDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProject> Get(string id)
    {
        // NOTE: Project is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Project WHERE IdPJ = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFProject>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFProject>> List()
    {
        const string query = "SELECT * FROM Project;";

        var result = await _connection.QueryAsync<PFProject>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFProject Project)
    {
        const string query =
            "INSERT INTO Project VALUES(@IdPJ, @TitlePJ, @DescriptionPJ, @IdPS1, @IdP1, @IdC1);";

        DynamicParameters dynamicParameters = new DynamicParameters();


        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["IdA"] = Project.IdPJ,
            ["TitleA"] = Project.TitlePJ,
            ["DescriptionA"] = Project.DescriptionPJ,
            ["IdPS1"] = Project.IdPS1,
            ["IdP1"] = Project.IdP1,
            ["IdC1"] = Project.IdC1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFProject Project)
    {
        const string query =
            "UPDATE Project SET TitlePJ=@Title, DescriptionPJ=@Description, IdPS1=@IdPS1, IdP1=@IdP1, IdC1=@IdC1 WHERE IdPJ=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Description"] = Project.DescriptionPJ,
            ["Title"] = Project.TitlePJ,
            ["IdPS1"] = Project.IdPS1,
            ["IdP1"] = Project.IdP1,
            ["IdC1"] = Project.IdC1
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Project WHERE IdPJ=@Id;";

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