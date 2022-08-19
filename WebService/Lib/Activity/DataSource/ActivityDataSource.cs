using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;

namespace WebService.Lib.Activity.DataSource;

public class ActivityDataSource
{
    readonly MySqlConnection _connection;

    public ActivityDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFActivity> Get(string id)
    {
        // NOTE: Activity is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Activity WHERE IdA = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFActivity>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFActivity>> Search(IDictionary<string, string> searchCriteria)
    {
        const string query = "SELECT * FROM Activity WHERE IdPJ1 = @idPJ1 OR IdT1 = @idT1 OR IdA = @idA";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(searchCriteria);

        var result = await _connection.QueryAsync<PFActivity>(query, dynamicParameters);

        return result;
    }
    
    public async Task<IEnumerable<PFActivity>> OfProject(string ProjectId)
    {
        const string query =
            "SELECT * FROM Activity WHERE IdPJ1 = @ProjectId;";
        DynamicParameters dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["ProjectId"] = ProjectId
        });
        var result = await _connection.QueryAsync<PFActivity>(query, dynamicParameters);
        
        return result;
    }


    public async Task<IEnumerable<PFActivity>> List()
    {
        const string query = "SELECT * FROM Activity;";

        var result = await _connection.QueryAsync<PFActivity>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFActivity Activity)
    {
        const string query =
            "INSERT INTO Activity VALUES(@IdA, @TitleA, @DescriptionA, @ExpectedBeginA, @ExpectedEndA, @IdPJ1, @IdT1);";

        DynamicParameters dynamicParameters = new DynamicParameters();


        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["IdA"] = Activity.IdA,
            ["TitleA"] = Activity.TitleA,
            ["DescriptionA"] = Activity.DescriptionA,
            ["ExpectedBeginA"] = Activity.ExpectedBeginA,
            ["ExpectedEndA"] = Activity.ExpectedEndA,
            ["IdPJ1"] = Activity.IdPJ1,
            ["IdT1"] = Activity.IdT1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFActivity activity)
    {
        const string query =
            "UPDATE Activity SET TitleA=@Title, DescriptionA=@Description, ExpectedBeginA=@ExpectedBegin, ExpectedEndA=@ExpectedEnd, IdPJ1=@IdPJ1, IdT1=@IdT1 WHERE IdA=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Title"] = activity.TitleA,
            ["Description"] = activity.DescriptionA,
            ["ExpectedBegin"] = activity.ExpectedBeginA,
            ["ExpectedEnd"] = activity.ExpectedEndA,
            ["IdPJ1"] = activity.IdPJ1,
            ["IdT1"] = activity.IdT1
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Activity WHERE IdA=@Id;";

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