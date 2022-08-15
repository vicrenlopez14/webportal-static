using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;

namespace WebService.Lib.Notification.DataSource;

public class NotificationDataSource
{
    readonly MySqlConnection _connection;

    public NotificationDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFNotification> Get(string id)
    {
        // NOTE: Notification is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Notification WHERE IdN = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        var result = await _connection.QueryAsync<PFNotification>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFNotification>> Search(IDictionary<string, string> searchCriteria)
    {
        const string query = "SELECT * FROM Notification WHERE IdPJ2 = @idPJ2;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(searchCriteria);

        var result = await _connection.QueryAsync<PFNotification>(query, dynamicParameters);

        return result;
    }

    public async Task<IEnumerable<PFNotification>> List()
    {
        const string query = "SELECT * FROM Notification;";

        var result = await _connection.QueryAsync<PFNotification>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFNotification Notification)
    {
        const string query =
            "INSERT INTO Notification VALUES(@IdN, @TitleN, @DescriptionN, @DateTimeIssuedN, @PictureN, @IdPJ2);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["IdA"] = Notification.IdN,
            ["TitleA"] = Notification.TitleN,
            ["DescriptionA"] = Notification.DescriptionN,
            ["DateTimeIssuedA"] = Notification.DateTimeIssuedN,
            ["PictureA"] = Notification.PictureN,
            ["IdPJ2"] = Notification.IdPJ2
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFNotification Notification)
    {
        const string query =
            "UPDATE Notification SET TitleN=@Title, DescriptionN=@Description, DateTimeIssuedN=@DateTimeIssuedN, PictureN=@PictureN, IdPJ2=@IdPJ2 WHERE IdN=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Title"] = Notification.TitleN,
            ["Description"] = Notification.DescriptionN,
            ["DateTimeIssued"] = Notification.DateTimeIssuedN,
            ["Picture"] = Notification.PictureN,
            ["IdPJ2"] = Notification.IdPJ2
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Notification WHERE IdN=@Id;";

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