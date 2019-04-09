using MongoDB.Driver;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FactoryMethodPattern
{
    public static class ConnectionFactory
    {
        public static IDbConnection Db1(bool open = true)
        {
            var db1 = new SqlConnection();
            Console.WriteLine("Connection DB1(MSSQL) initialized");

            if (open)
            {
                //db1.Open();
                Console.WriteLine("Connection DB1(MSSQL) open");
            }

            return db1;
        }

        public static IDbConnection Db2(bool open = true)
        {
            var db2 = new MySqlConnection();
            Console.WriteLine("Connection DB2(MySQL) initialized");

            if (open)
            {
                //db2.Open();
                Console.WriteLine("Connection DB2(MySQL) open");
            }

            return db2;
        }

        public static MongoClient Db3()
        {
            var db3 = new MongoClient();
            Console.WriteLine("Connection DB3(MongoDB) initialized");

            return db3;
        }
    }
}