using Microsoft.EntityFrameworkCore;

namespace DBShake;

public sealed class CSConnectionData : IDBConnectionData
{
    public const ConnectionTypeName TypeName = ConnectionTypeName.CS;
    public string ConnectionType { get; set; }

    public string ConnectionString { get; set; }

    /// <summary>
    /// This method does not work with a full connectionstring
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    [Obsolete("This method does not work with a full connectionstring")]
    public void CreateConnection(DbContextOptionsBuilder options)
    {
        throw new NotImplementedException();
    }
}
