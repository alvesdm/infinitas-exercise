using System.Data;

namespace Infinitas.Data
{
    public interface IAmDBConnectable
    {
        IDbConnection CreateConnection();
    }
}
