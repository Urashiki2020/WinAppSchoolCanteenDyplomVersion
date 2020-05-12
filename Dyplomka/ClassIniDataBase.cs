using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Поставщик данных платформы .NET для SQL Server
using System.Data.Odbc;//Протокол используемый для подключения базы данных Microsoft SQL Server

namespace Dyplomka
{
    class ClassIniDataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVLAIMU\SQLEXPRESS;Initial Catalog=SchoolCanteen;Integrated Security=True");//Строка подключения базы данных

        public void OpenConnection()//Если мы не подключены к базе данных то эта функция позволит нам открыть, то есть начать работу с базой данных 
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()//Если мы подключены к базе данных то эта функция позволит нам закрыть, то есть завершить работу с базой данных
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()//Данная функция возвращает соединение с базой данных
        {
            return connection;
        }
    }
}
