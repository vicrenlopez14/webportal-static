using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;
using ProFind_WebService.Lib.Process.Model;

namespace ProFind_WebService.Lib.Process.DataSource;

public class ProcessDataSource
{
    readonly MySqlConnection _connection;

    public ProcessDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProcess> Get(string id)
    {
        // NOTE: Process is supposed to have already an Id at this point.

        const string query =
            "SELECT Process.IdPR," +
            "Process.TitlePR," +
            "Process.DescriptionPR," +
            "Process.BeginDatePR," +
            "Process.EndDatePR," +
            "Process.IdT1," +
            "NameT," +
            "IdPJ1," +
            "TitlePJ," +
            "DescriptionPJ FROM Process " +
            "INNER JOIN Tag T on Process.IdT1 = T.IdT " +
            "INNER JOIN Project P on T.IdPJ1 = P.IdPJ " +
            "WHERE Process.IdPR = @Id " +
            "LIMIT 1;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object> ()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFProcess>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFProcess>> List()
    {
        const string query = "SELECT * FROM Process;";

        var result = await _connection.QueryAsync<PFProcess>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFProcess process)
    {
        // NOTE@ Process is supposed to have already an Id at this point.

        const string query =
            "INSERT INTO Process VALUES (@Id, @Title, @Description, @BeginDate, @IdTag, @EndDate);";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = process.IdPR,
            ["Title"] = process.TitlePR,
            ["Description"] = process.DescriptionPR,
            ["BeginDate"] = process.BeginDatePR,
            ["IdTag"] = process.IdTag,
            ["EndDate"] = process.EndDatePR
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFProcess process)
    {
        const string query =
            "UPDATE Process SET TitlePR=@Title, DescriptionPR=@Description, BeginDatePR=@BeginDate, " +
            "IdT1=@IdTag, EndDatePR=@EndDate WHERE IdPR=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Title"] = process.TitlePR,
            ["Description"] = process.DescriptionPR,
            ["BeginDate"] = process.BeginDatePR,
            ["IdTag"] = process.IdTag,
            ["EndDate"] = process.EndDatePR
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Process WHERE IdPR=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string , object>()
        {
            ["Id"] = id
        }
        );

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}