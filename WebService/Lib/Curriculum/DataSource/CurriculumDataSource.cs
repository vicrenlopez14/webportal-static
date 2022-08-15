using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;

namespace WebService.Lib.Curriculum.DataSource;

public class CurriculumDataSource
{
    readonly MySqlConnection _connection;

    public CurriculumDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFCurriculum> Get(string id)
    {
        const string query =
            "SELECT * FROM Curriculum WHERE idCU = @Id;";
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string,object>()
            ["Id"] = id
        );

        var result = await _connection.QueryAsync<PFCurriculum>(query, dynamicParameters);

        return result.ToList()[0];
    }

    public async Task<IEnumerable<PFCurriculum>> List()
    {
        const string query = "SELECT * FROM Curriculum;";

        var result = await _connection.QueryAsync<PFCurriculum>(query);

        return result.ToList();
    }

    public async Task<bool> Create(PFCurriculum curriculum)
    {
        const string query = "INSERT INTO Curriculum VALUES(@Id,@Studies,@Experiences,@Years);";
        var dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = curriculum.IdCU,
            ["Studies"] = curriculum.StudiesCU,
            ["Experiences"] = curriculum.ExperiencesCU,
            ["Years"] = curriculum.YearsCU
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Update(string id, PFCurriculum curriculum)
    {
        const string query = "UPDATE Curriculum SET StudiesCU = @Studies, ExperiencesCU = @Experiences, "
                             + "YearsCU = @Years WHERE Id_CU = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Studies"] = curriculum.StudiesCU,
            ["Experiences"] = curriculum.ExperiencesCU,
            ["Years"] = curriculum.YearsCU
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Curriculum WHERE IdCU = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });


        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }
}