using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;

namespace WebService.Lib.WorkDayType.DataSource;

public class WorkDayTypeDataSource
{
    readonly MySqlConnection _connection;

    public WorkDayTypeDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFWorkDayType> Get(string id)
    {
        const string query = "SELECT * FROM WorkDayType WHERE IdWDT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFWorkDayType>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFWorkDayType>> List()
    {
        const string query = "SELECT * FROM WorkDayType;";

        var result = await _connection.QueryAsync<PFWorkDayType>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFWorkDayType WorkDayType)
    {
        const string query = "INSERT INTO WorkDayType (NameWDT) VALUES (@Name);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = WorkDayType.IdWDT,
            ["Name"] = WorkDayType.NameWDT
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFWorkDayType WorkDayType)
    {
        const string query = "UPDATE WorkDayType SET NameWDT = @Name WHERE IdWDT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = WorkDayType.NameWDT,
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM WorkDayType WHERE IdWDT = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}