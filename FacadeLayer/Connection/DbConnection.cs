using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer.Connection
{
    class DbConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4EVNNNJ;Initial Catalog=DbFilmDizi;integrated Security=True");
    }
}
