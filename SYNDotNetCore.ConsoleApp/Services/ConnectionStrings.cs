using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYNDotNetCore.ConsoleApp.Services
{
    internal static class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-SM8F9VJ",//server name
            InitialCatalog = "DotNetTrainingBatch4",//db name
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,

        };
    }
}
