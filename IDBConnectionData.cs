using Microsoft.EntityFrameworkCore;

namespace DBShake;

public interface IDBConnectionData
{
    public static ConnectionTypeName TypeName { get; }
    public string ConnectionType { get; set; }
    public string ConnectionString { get; }

    public void CreateConnection(DbContextOptionsBuilder options);
}

public enum ConnectionTypeName
{
    CS,
    PG,
    SQS,
    SQST,
    MS
}
