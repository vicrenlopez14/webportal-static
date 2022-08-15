using MySql.Data.MySqlClient;

namespace WebService.Lib.DataSource;

public interface IDataSourceLink
{
    public MySqlConnection getConnection();
}