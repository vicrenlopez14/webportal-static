using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;
using Domain.Models;


namespace ProFind_WebService.Lib.Profession.DataSource;

public class ProfessionDataSource
{
    readonly MySqlConnection _connection;

    public ProfessionDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProfession> Get(string id)
    {
        // NOTE: Profession is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Profession WHERE IdPFS = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFProfession>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFProfession>> List()
    {
        const string query = "SELECT * FROM Profession;";

        var result = await _connection.QueryAsync<PFProfession>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFProfession Profession)
    {
        return false;
    }

    public async Task<bool> Update(string id, PFProfession Profession)
    {
        const string query =
            "UPDATE Profession SET NamePFS=@Name WHERE IdPFS=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = Profession.NamePFS
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Profession WHERE IdPFS=@Id;";

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