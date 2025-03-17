namespace DBShake;

public sealed class SQSConnectionData : IDBConnectionData
{
    public const ConnectionTypeName TypeName = ConnectionTypeName.SQS;
    public string ConnectionType { get; set; }
    public string Server { get; set; }
    public int? Port { get; set; }
    public string Database { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
    public bool Security { get; set; }
    public int Timeout { get; set; }
    public bool Encrypt { get; set; }
    public bool TrustCertificate { get; set; }
    public string Intent { get; set; }
    public bool Failover { get; set; }

    public string ConnectionString
    {
        get
        {
            string port = "";
            if (Port is not null)
                port = $":{Port}";

            string security = "False";
            if (Security)
                security = "True";

            string encrypt = "False";
            if (Encrypt)
                encrypt = "True";

            string trust = "False";
            if (TrustCertificate)
                trust = "True";

            string failover = "False";
            if (Failover)
                failover = "True";

            return $"Data Source={Server}{port};Initial Catalog={Database};User Id={UserId};Password={Password};Integrated Security={security};Connect Timeout={Timeout};Encrypt={encrypt};TrustServerCertificate={trust};ApplicationIntent={Intent};MultiSubnetFailover={failover}";
        }
    }
}
