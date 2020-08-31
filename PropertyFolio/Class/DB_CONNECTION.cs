using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PropertyFolio.Class
{
    class DB_CONNECTION
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=PropertyFolio;database=PropertyFolio;");

        // get connection
        public MySqlConnection getConnection()
        {
            getConnection{
                return connection;
            }
        }

        // open connection
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // close connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
