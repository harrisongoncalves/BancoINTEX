using System.Data.SqlClient;

namespace BancoINTEX.Model
{
    public class SQL
    {
        SqlConnection sql = new SqlConnection();
        public SQL()
        {
            sql.ConnectionString = @"Data Source=harrisong.database.windows.net;Initial Catalog=escolajuraci;Persist Security Info=True;User ID=juraciteles;Password=Escolajuraci1@";
        }
        public SqlConnection Conectar()
        {
            if (sql.State == System.Data.ConnectionState.Closed)
            {
                sql.Open();
            }
            return sql;
        }

        public void Desconectar()
        {
            if (sql.State == System.Data.ConnectionState.Open)
            {
                sql.Close();
            }
        }
    }
}
