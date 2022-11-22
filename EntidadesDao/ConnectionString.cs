using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDao
{
    public static class ConnectionString
    {
        private static string connectionString;
        static ConnectionString()
        {
            connectionString = @"Data Source=.;Initial Catalog=PARCIAL_2;Integrated Security=True";
        }
        public static string String{
            get { return connectionString; }
        }
    }
}
