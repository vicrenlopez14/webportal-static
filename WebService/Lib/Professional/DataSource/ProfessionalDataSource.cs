using Application.Models;
using Dapper;
using MySql.Data.MySqlClient;
using WebService.Lib.DataSource;
using WebService.Lib.Department.DataSource;
using WebService.Lib.Profession.DataSource;
using WebService.Lib.WorkDayType.DataSource;
using WebService.Utils;

namespace WebService.Lib.Professional.DataSource;

public class ProfessionalDataSource
{
    readonly MySqlConnection _connection;

    public ProfessionalDataSource()
    {
        _connection = new MySqlDataSourceLink().getConnection();
    }

    public async Task<PFProfessional?> Get(string id)
    {
        const string query = "SELECT * FROM Professional WHERE IdP = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        List<PFProfessional> result =
            (await _connection.QueryAsync<PFProfessional>(query, dynamicParameters)).ToList();

        // Fill up nested objects
        if (!result.Any())
            return null;

        return await FillUp(result.First());
    }

    public async Task<IEnumerable<PFProfessional>> List()
    {
        const string query = "SELECT * FROM Professional;";

        var result = (await _connection.QueryAsync<PFProfessional>(query)).ToList();

        if (!result.Any()) return result.ToList();

        // Fill nested objects
        var filledList = new List<PFProfessional>();
        foreach (var professional in result)
        {
            filledList.Add(await FillUp(professional));
        }

        return filledList;
    }

    private static async Task<PFProfessional> FillUp(PFProfessional unfilled)
    {
        if (!string.IsNullOrEmpty(unfilled.IdPFS1))
            unfilled.Profession = await new ProfessionDataSource().Get(unfilled.IdPFS1);
        if (!string.IsNullOrEmpty(unfilled.IdDP1))
            unfilled.Department = await new DepartmentDataSource().Get(unfilled.IdDP1);
        if (!string.IsNullOrEmpty(unfilled.IdWDT1))
            unfilled.WorkDayType = await new WorkDayTypeDataSource().Get(unfilled.IdWDT1);

        return unfilled;
    }

    private static async Task<bool> FillDown(PFProfessional unfilled)
    {
        return true;
    }

    public async Task<bool> Create(PFProfessional professional)
    {
        const string query =
            "INSERT INTO Professional VALUES(@Id,@Name,@DateBirth,@Email,@Password, @Active, @Sex, @Dui, @Afp, @Isss, @ZipCode, @Salary, @HiringDate, @Picture, @Curriculum, @Profession, @Department, @WorkDayType);";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = await Nanoid.Nanoid.GenerateAsync(),
            ["Name"] = professional.NameP,
            ["DateBirth"] = professional.DateBirthP,
            ["Email"] = professional.EmailP,
            ["Password"] = SHAPassword.ShaThisPassword(professional.PasswordP!),
            ["Active"] = professional.ActiveP,
            ["Sex"] = professional.SexP,
            ["Dui"] = professional.DUIP,
            ["Afp"] = professional.AFPP,
            ["Isss"] = professional.ISSSP,
            ["ZipCode"] = professional.ZipCodeP,
            ["Salary"] = professional.SalaryP,
            ["HiringDate"] = professional.HiringDateP,
            ["Picture"] = professional.PictureP,
            ["Curriculum"] = professional.Curriculum,
            ["Profession"] = professional.Profession.IdPFS,
            ["Department"] = professional.Department.IdDP,
            ["WorkDayType"] = professional.WorkDayType.IdWDT,
        });
        var result = (await _connection.ExecuteAsync(query, dynamicParameters) > 0);

        if (result == false) return false;

        return await FillDown(professional);
    }

    public async Task<bool> Update(string id, PFProfessional professional)
    {
        const string query = "UPDATE Professional SET NameP = @Name, DateBirthP = @DateBirth, "
                             + "EmailP = @Email, PasswordP = @Password, ActiveP = @Active, IdCU1 = @Curriculum WHERE IdP = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = professional.IdCU1,
            ["Name"] = professional.NameP,
            ["DateBirth"] = professional.DateBirthP,
            ["Email"] = professional.EmailP,
            ["Password"] = SHAPassword.ShaThisPassword(professional.PasswordP!),
            ["Active"] = professional.ActiveP,
            ["Sex"] = professional.SexP,
            ["Dui"] = professional.DUIP,
            ["Afp"] = professional.AFPP,
            ["Isss"] = professional.ISSSP,
            ["ZipCode"] = professional.ZipCodeP,
            ["Salary"] = professional.SalaryP,
            ["HiringDate"] = professional.HiringDateP,
            ["Picture"] = professional.PictureP,
            ["Curriculum"] = professional.IdCU1,
            ["Profession"] = professional.Profession.IdPFS,
            ["Department"] = professional.Department.IdDP
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters) > 0);
    }

    public async Task<bool> Delete(string id)
    {
        const string query = "DELETE FROM Professional WHERE IdP = @Id;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Id"] = id
        });

        return (await _connection.ExecuteAsync(query, dynamicParameters)) > 0;
    }

    public async Task<(bool, PFProfessional)> Login(string email, string password)
    {
        const string query = "SELECT * FROM Professional "
                             + "WHERE EmailP = @Email AND PasswordP = @Password;";

        DynamicParameters dynamicParameters = new DynamicParameters();

        dynamicParameters.AddDynamicParams(new Dictionary<string, object>()
        {
            ["Email"] = email,
            ["Password"] = SHAPassword.ShaThisPassword(password)
        });

        var result = (await _connection.QueryAsync<PFProfessional>(query, dynamicParameters)).ToList();
        // Fill up nested objects
        if (!result.Any())
            return (result.Any(), null);

        return (result.Any(), await FillUp(result.First()));
    }
}