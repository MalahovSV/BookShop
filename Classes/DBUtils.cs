using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes
{
    static class DBUtils
    {
        private static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        async static public ValueTask<DataTable> loadDataTable(string CommandSQL)
        {
            using(SqlConnection connection = new SqlConnection(ReadSetting("DefaultConnection")))
            {
                await Task.Delay(100);
                await connection.OpenAsync();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CommandSQL, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }

        static public DataTable loadDataTableAuthorization(string CommandSQL, SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CommandSQL, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        static public void ExecuteNonQuerySqlCommand (string CommandSQL, SqlConnection Connection)
        {
            SqlCommand sqlCommand = new SqlCommand(CommandSQL, Connection);
            sqlCommand.ExecuteNonQuery();
        }


        static public DataTable loadDataTable1(string CommandSql)
        {
            SqlConnection connection = new SqlConnection();
            var task = Classes.DBUtils.setupConnection();
            LoaderForm ld = new LoaderForm(task.AsTask());
            ld.ShowDialog();
            connection = task.Result;
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CommandSql, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Close();
            return dt;
        }


        /// <summary>
        /// Установка соединения
        /// </summary>
        /// <returns>Асинхронный поток с открытым соединением</returns>
        async static public ValueTask<SqlConnection> setupConnection()
        {
            //SqlConnection connection = new SqlConnection(ReadSetting("DefaultConnection")); 
            SqlConnection connection = new SqlConnection(ReadSetting("DefaultConnection"));
            await connection.OpenAsync();
            return connection;
        }
        
        /// <summary>
        /// Чтение записи из кофигуратора
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        static public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
               Console.WriteLine("Error reading app settings");
                return null;
            }
        }

        /// <summary>
        /// Добавление записи в конфигуратор
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        /// <param name="value">Значение</param>
        static public void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                Console.WriteLine("Успешно");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}