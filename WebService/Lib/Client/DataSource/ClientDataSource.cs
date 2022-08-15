using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;
using WebService.Utils;

namespace WebService.Lib.Client.DataSource;

public class ClientDataSource
{
    readonly MySqlConnection _connection;

    public ClientDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFClient> Get(string id)
    {
        const string query = "SELECT * FROM Client WHERE IdC = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        var result = await _connection.QueryAsync<PFClient>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFClient>> List()
    {
        const string query = "SELECT * FROM Client;";

        var result = await _connection.QueryAsync<PFClient>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFClient client)
    {
        const string query = "INSERT INTO Client VALUES (@Id, @Name, @Email, @Password);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = client.IdC,
            ["Name"] = client.NameC!,
            ["Email"] = client.EmailC!,
            ["Password"] = SHAPassword.ShaThisPassword(client.PasswordC!)
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFClient client)
    {
        const string query =
            "UPDATE Client SET NameC = @Name, EmailC = @Email, PasswordC = @Password WHERE IdC = @Id;";


        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Name"] = client.NameC,
            ["Email"] = client.EmailC,
            ["Password"] = client.PasswordC
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Client WHERE IdC = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Login(string email, string password)
    {
        const string query = "SELECT * FROM Client WHERE EmailC = @Email AND PasswordC = @Password;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>
        {
            ["Email"] = email,
            ["Password"] = SHAPassword.ShaThisPassword(password)
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    private async Task<bool> CheckEmail(string email)
    {
        const string query = "SELECT * FROM Client WHERE EmailC = @Email;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Email"] = email
        });

        return !(await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public bool CheckPassword(string password)
    {
        if (password.Length <= 5) return false;

        bool letter = false;
        bool number = false;
        bool upper = false;

        foreach (char character in password)
        {
            if (Char.IsLetter(character)) letter = true;
            if (Char.IsNumber(character)) number = true;
            if (Char.IsUpper(character)) upper = true;
        }

        return (letter && number && upper);
    }

    public async Task<RegisterResponse> Register(string name, string email, string password)
    {
        var checkEmail = await CheckEmail(email);
        var checkPassword = CheckPassword(password);

        if (checkEmail && checkPassword)
        {
            string id = await Nanoid.Nanoid.GenerateAsync();

            PFClient client = new PFClient(id, name, email, password);

            if (Create(client).Result) return RegisterResponse.Successful;
            return RegisterResponse.Error;
        }

        if (checkEmail) return RegisterResponse.AccountAlreadyExists;
        return RegisterResponse.IncorrectPasswordFormat;
    }
}