using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;
using Domain.Models;

namespace ProFind_WebService.Lib.Rank.DataSource;

public class RankDataSource
{
    readonly MySqlConnection _connection;

    public RankDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFRank> Get(string id)
    {
        const string query = "SELECT IdR, NameR FROM `Rank` WHERE IdR = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFRank>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFRank>> List()
    {
        const string query = "SELECT * FROM `Rank`;";

        var result = await _connection.QueryAsync<PFRank>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFRank rank)
    {
        const string query = "INSERT INTO `Rank` VALUES (@Id,@Name);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = rank.IdR,
            ["Name"] = rank.NameR
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFRank rank)
    {
        const string query = "UPDATE `Rank` SET NameR = @Name WHERE IdR = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = rank.NameR
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM `Rank` WHERE IdR = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}