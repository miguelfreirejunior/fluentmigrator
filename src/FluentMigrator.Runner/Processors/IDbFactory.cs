namespace FluentMigrator.Runner.Processors
{
    using System.Data;
    using System.Data.Common;

    public interface IDbFactory
    {
        DbConnection CreateConnection(string connectionString);
        IDbCommand CreateCommand(string commandText, IDbConnection connection, IDbTransaction transaction);
        IDbDataAdapter CreateDataAdapter(IDbCommand command);
        IDbCommand CreateCommand(string commandText, IDbConnection connection);
    }
}