using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;
using Domain.Models;

namespace ProFind_WebService.Lib.Job.DataSource;

public class JobDataSource
{
    readonly MySqlConnection _connection;

    public JobDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFJob> Get(string id)
    {
        const string query = "SELECT * FROM Job WHERE IdJ = @Id;";
        DynamicParameters dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFJob>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFJob>> List()
    {
        const string query = "SELECT * FROM Job;";

        var result = await _connection.QueryAsync<PFJob>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFJob job)
    {
        const string query = "INSERT INTO Job VALUES (@Id,@Name);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = job.IdJ,
            ["Name"] = job.NameJ
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFJob job)
    {
        const string query = "UPDATE Job SET NameJ=@Name WHERE IdJ = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = job.NameJ
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Job WHERE IdJ = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}