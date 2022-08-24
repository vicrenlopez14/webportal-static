using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.Activity.DataSource;
using WebService.Lib.Client.DataSource;
using WebService.Lib.DataSource;
using WebService.Lib.Professional.DataSource;

namespace WebService.Lib.Project.DataSource;

public class ProjectDataSource
{
    readonly MySqlConnection _connection;

    public ProjectDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProject> Get(string id)
    {
        // NOTE: Project is supposed to have already an Id at this point.

        const string query =
            "SELECT * FROM Project WHERE IdPJ = @id";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });

        List<PFProject> result =
            (await _connection.QueryAsync<PFProject>(query, dynamicParameters)).ToList();

        // Fill up nested objects
        if (!result.Any())
            return null;

        return await FillUp(result.First());
    }

    public async Task<IEnumerable<PFProject>> List()
    {
        const string query = "SELECT * FROM Project;";

        var result = (await _connection.QueryAsync<PFProject>(query)).ToList();

        if (!result.Any()) return result.ToList();

        // Fill nested objects
        var filledList = new List<PFProject>();
        foreach (var professional in result)
        {
            filledList.Add(await FillUp(professional));
        }

        return filledList;
    }

    public async Task<IEnumerable<PFAdmin>> Search(IDictionary<string, string> searchCriteria)
    {
        const string query =
            "SELECT * FROM Project WHERE( NameA LIKE '%@Name%') OR (soundex(NameA) = SOUNDEX('@Name'));";


        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Name"] = searchCriteria["Name"]
        });

        var result = await _connection.QueryAsync<PFAdmin>(query, dynamicParameters);

        return result;
    }

    public async Task<IEnumerable<PFAdmin>> Search(string searchCriteria)
    {
        const string query =
            "SELECT * FROM Project WHERE( project.TitlePJ LIKE '%@Name%') OR (soundex(TitlePJ) = SOUNDEX('@Name'));";
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Name"] = searchCriteria
        });
        var result = await _connection.QueryAsync<PFAdmin>(query, dynamicParameters);

        return result;
    }

    public async Task<IEnumerable<PFProject>> GetProposalProjects()
    {
        const string query = "SELECT * FROM Project WHERE IdPS1 = 3;";
        var result = await _connection.QueryAsync<PFProject>(query);
        return result;
    }


    public async Task<IEnumerable<PFProject>> GetProjectsOfAProfessional(string id)
    {
        const string query =
            "SELECT * FROM Project WHERE IdP1 = @id";
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });
        var result = await _connection.QueryAsync<PFProject>(query, dynamicParameters);

        return result.ToList();
    }

    public async Task<bool> CreateProposal(PFProject Project)
    {
        Project.IdPS1 = 3.ToString();
        return await Create(Project);
    }


    public async Task<IEnumerable<PFProject>> GetProjectsOfAClient(string id)
    {
        const string query =
            "SELECT * FROM Project WHERE IdC1 = @id";
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["id"] = id
        });
        var result = await _connection.QueryAsync<PFProject>(query, dynamicParameters);

        return result.ToList();
    }

    public async Task<bool> Create(PFProject Project)
    {
        const string query =
            "INSERT INTO Project VALUES(@IdPJ, @TitlePJ, @DescriptionPJ, @PicturePJ, @TotalPricePJ, @IdPS1, @IdP1, @IdC1);";

        DynamicParameters dynamicParameters = new DynamicParameters();


        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["IdPJ"] = Project.IdPJ,
            ["TitlePJ"] = Project.TitlePJ,
            ["DescriptionPJ"] = Project.DescriptionPJ,
            ["PicturePJ"] = Project.PicturePJ,
            ["TotalPricePJ"] = Project.TotalPricePJ,
            ["IdPS1"] = Project.IdPS1,
            ["IdP1"] = Project.IdP1,
            ["IdC1"] = Project.IdC1
        });

        var result = (await _connection.ExecuteAsync(query, dynamicParameters) > 0);

        if (result == false) return false;

        return await FillDown(Project);
    }

    private static async Task<PFProject> FillUp(PFProject unfilled)
    {
        if (!string.IsNullOrEmpty(unfilled.IdC1))
            unfilled.ResponsibleClient = await new ClientDataSource().Get(unfilled.IdC1);
        if (!string.IsNullOrEmpty(unfilled.IdP1))
            unfilled.ResponsibleProfessional = await new ProfessionalDataSource().Get(unfilled.IdP1);

        unfilled.Activities = await new ActivityDataSource().OfProject(unfilled.IdP1);

        return unfilled;
    }

    private static async Task<bool> FillDown(PFProject unfilled)
    {
        return true;
    }

    public async Task<bool> Update(string id, PFProject Project)
    {
        const string query =
            "UPDATE Project SET TitlePJ=@Title, DescriptionPJ=@Description, PicturePJ=@Picture, TotalPricePJ=@TotalPrice, IdPS1=@IdPS1, IdP1=@IdP1, IdC1=@IdC1 WHERE IdPJ=@Id;";

        var dynamicParameters = new DynamicParameters();
        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id,
            ["Description"] = Project.DescriptionPJ,
            ["Title"] = Project.TitlePJ,
            ["Picture"] = Project.PicturePJ,
            ["TotalPrice"] = Project.TotalPricePJ,
            ["IdPS1"] = Project.IdPS1,
            ["IdP1"] = Project.IdP1,
            ["IdC1"] = Project.IdC1
        });

        // If more than 0 rows modified, was successful
        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query =
            "DELETE FROM Project WHERE IdPJ=@Id;";

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