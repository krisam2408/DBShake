namespace DBShake;

public sealed class CSConnectionData : IDBConnectionData
{
    public const ConnectionTypeName TypeName = ConnectionTypeName.CS;
    public string ConnectionType { get; set; }

    public string ConnectionString { get; set; }
}
