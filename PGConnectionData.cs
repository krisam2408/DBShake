namespace DBShake;

public sealed class PGConnectionData : IDBConnectionData
{
    public const ConnectionTypeName TypeName = ConnectionTypeName.PG;
    public string ConnectionType { get; set; }

    public string Server { get; set; }
    public int? Port { get; set; }
    public string Database { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }

    public string ConnectionString
    {
        get
        {
            string port = "";
            if (Port is not null)
                port = $"Port={Port};";

            return $"Server={Server};{port}Database={Database};User Id={UserId};Password={Password};";
        }
    }
}
