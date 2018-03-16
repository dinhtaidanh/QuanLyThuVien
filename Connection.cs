using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data;

namespace ManHinhChinh
{
    public class Connection
    {
        public string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\ThuVien.mdb";
        public OleDbConnection connection;
        public Connection() {
            connection = new OleDbConnection(connectionString);   //tạo lớp kết nối vào .mbd
        }
        public void openConnection()
        {
            if(connection.State== ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if(connection.State== ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public OleDbCommand GetDbCommand(string queryString)
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            openConnection();
            return command;
            
        }
    }
}
