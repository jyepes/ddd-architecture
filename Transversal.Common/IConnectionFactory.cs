using System;
using System.Data;

namespace Transversal.Common
{
    public class IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
