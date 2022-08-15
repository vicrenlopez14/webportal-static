using System.Security.Cryptography;
using System.Text;
using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using ProFind_WebService.Lib.DataSource;
using ProFind_WebService.Utils;

namespace ProFind_WebService.Lib.Admin.DataSource;

public class AdminDataSource
{
    readonly MySqlConnection _connection;

    public AdminDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFAdmin?> Get(string id)
    {
        const string query = "SELECT * FROM Admin WHERE IdA = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFAdmin>(query, dynamicParameters);

        try
        {
            return result.ToList()[0];
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<IEnumerable<PFAdmin>> List()
    {
        const string query = "SELECT * FROM Admin;";
        var result = await _connection.QueryAsync<PFAdmin>(query);

        return result.ToList();
    }

    public async Task<IEnumerable<PFAdmin>> PaginatedList(int fromIndex, int toIndex)
    {
        int len = toIndex - fromIndex + 1;

        const string query = "SELECT * FROM Admin LIMIT @FromIndex, @Len;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["FromIndex"] = fromIndex.ToString(),
            ["Len"] = len.ToString()
        });

        var result = await _connection.QueryAsync<PFAdmin>(query, dynamicParameters);

        return result;
    }

    public async Task<IEnumerable<PFAdmin>> Search(IDictionary<string, string> searchCriteria)
    {
        const string query =
            "SELECT * FROM Admin WHERE( NameA LIKE '%@Name%') OR (soundex(NameA) = SOUNDEX('@Name'));";


        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Name"] = searchCriteria["Name"]
        });

        var result = await _connection.QueryAsync<PFAdmin>(query, dynamicParameters);

        return result;
    }

    public async Task<bool> Create(PFAdmin admin)
    {
        const string query = "INSERT INTO Admin VALUES(@Id,@Name,@Email,@Tel,@Password,@Rank);";

        DynamicParameters dynamicParameters = new DynamicParameters();


        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = admin.IdA,
            ["Name"] = admin.NameA,
            ["Email"] = admin.EmailA,
            ["Tel"] = admin.TelA,
            ["Password"] = SHAPassword.ShaThisPassword(admin.PasswordA!),
            ["Rank"] = admin.IdR1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Login(string email, string password)
    {
       

        const string query = "SELECT * FROM Admin WHERE EmailA = @Email AND PasswordA = @Password;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Email"] = email,
            ["Password"] = SHAPassword.ShaThisPassword(password)
        });

        return await _connection.ExecuteAsync(query, dynamicParameters) > 0;
    }

    public async Task<bool> Update(string id, PFAdmin admin)
    {
        const string query = "UPDATE Admin SET NameA = @Name, EmailA = @Email, TelA = @Tel,"
                             + " PasswordA = @Password, IdR1 = @Rank WHERE IdA = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = admin.NameA,
            ["Email"] = admin.EmailA,
            ["Tel"] = admin.TelA,
            ["Password"] = admin.PasswordA,
            ["Rank"] = admin.IdR1
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Admin WHERE IdA = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

  
}