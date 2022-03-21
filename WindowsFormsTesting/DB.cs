using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTesting
{
    public class DB
    {

        //
        MySqlConnection cnctn = new MySqlConnection("Server=localhost;Database=costumers;Port=3306;Userid=root;Password=root");
        public void OpenConnection()
        {
            if(cnctn.State == System.Data.ConnectionState.Closed)
            {
                cnctn.Open();
            }
            
        }
        public void CloseConnection()
        {
            if (cnctn.State == System.Data.ConnectionState.Open)
            {
                cnctn.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return cnctn;
        }
    }
}
