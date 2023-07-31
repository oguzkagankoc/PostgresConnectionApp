using System;
using Npgsql;

namespace PostgresConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Veritabanı bağlantı bilgileri
            string host = "localhost";
            int port = 5432;
            string database = "case";
            string username = "postgres";
            string password = "122333";

            // Veritabanı bağlantı dizesini oluşturma
            string connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";

            // Veritabanı bağlantısını oluşturma
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("PostgreSQL veritabanına başarıyla bağlandınız!");

                    // Veritabanı işlemlerini burada gerçekleştirebilirsiniz.

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı bağlantısı sırasında hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
