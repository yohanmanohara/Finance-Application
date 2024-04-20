using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace Finance_APP.Core.Database.Models
{
    internal class BaseDataType
    {
        public int Id;

        public BaseDataType(int id)
        {
            Id = id;
        }
    }

    internal class BaseModel<DataType> where DataType : BaseDataType
    {
        private string _table;
        private SqlConnection _connection;

        public DataType data;

        public BaseModel(string Table, bool LoadDataOnInit = true) {
            _table = Table;
            _connection = new SqlConnection(Config.CONNECTION_STRING);

            if (LoadDataOnInit) { Load(); };
        }

        public void Load()
        {
            string query = "SELECT * FROM [@Table] WHERE Id=@Id;";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@Table", _table);
            command.Parameters.AddWithValue("@Id", data.Id);

            try
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string fieldName = reader.GetName(i);
                        object value = reader[fieldName];
                        typeof(DataType).GetProperty(fieldName)?.SetValue(data, value, null);
                    }
                }
                else
                {
                    Console.WriteLine("No data found for the given primary key.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Update()
        {
            string query = $"UPDATE {_table} SET ";

            PropertyInfo[] properties = typeof(DataType).GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                query += $"{property.Name}=@{property.Name}";

                if (i < properties.Length - 1)
                {
                    query += ", ";
                }
            }

            query += $" WHERE Id=@Id;";

            SqlCommand command = new SqlCommand(query, _connection);

            foreach (PropertyInfo property in properties)
            {
                command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(data));
            }

            command.Parameters.AddWithValue("@Id", data.Id);

            try
            {
                _connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }
        }

        public static BaseModel<DataType> Get(int Id)
        {
            BaseModel<DataType> model = new BaseModel<DataType>("", false);
            model.data.Id = Id;
            model.Load();

            return model;
        }
    }
}
