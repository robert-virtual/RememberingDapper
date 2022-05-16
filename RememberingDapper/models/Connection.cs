using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RememberingDapper.models
{
    public class Connection
    {
        protected MySqlConnection holaConnection { get; set; } = 
         new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlconn"].ConnectionString);
    }
}
