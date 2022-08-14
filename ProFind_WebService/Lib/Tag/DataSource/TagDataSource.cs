using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;

namespace ProFind_WebService.Lib.Tag.DataSource;

public class TagDataSource
{
    readonly MySqlConnection _connection;

    public TagDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFTag> Get(string id)
    {
        const string query = "SELECT IdT, NameT, IdPJ1 FROM Tag WHERE IdT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFTag>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFTag>> List()
    {
        const string query = "SELECT * FROM Tag;";

        var result = await _connection.QueryAsync<PFTag>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFTag tag)
    {
        const string query = "INSERT INTO Tag VALUES (@Id,@Name,@Project);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = tag.IdT,
            ["Name"] = tag.NameT,
            ["Project"] = tag.IdPJ1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFTag tag)
    {
        const string query = "UPDATE Tag SET NameT = @Name, IdPJ1 = @Project WHERE IdT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = tag.NameT,
            ["Project"] = tag.IdPJ1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Tag WHERE IdT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}