namespace DBShake;

public interface IDBConnectionData
{
    public static ConnectionTypeName TypeName { get; }
    public string ConnectionType { get; set; }
    public string ConnectionString { get; }
}

public enum ConnectionTypeName
{
    CS,
    PG,
    SQS,
    SQST,
    MS
}
