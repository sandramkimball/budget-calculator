using System;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace PropertyFolio.Class
{
    class FUNC
    {
        DB_CONNECTION connection = new DB_CONNECTION();
        // get
        public DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // insert
        // update
        // delete
    }
}
