using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace IPD
{
    public class Conexion
    {
        public SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
