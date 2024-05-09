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
    internal class BaseModel
    {
        public string _table;

        public int Id { get; set; }

        public BaseModel() {
            _table = this.GetType().Name;
        }

        public void Write()
        {
            string query = "INSERT INTO " + _table + " (";

            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                query += property.Name;

                if (property != properties.Last())
                {
                    query += ", ";
                }
            }

            query += ") VALUES (";

            foreach (PropertyInfo property in properties)
            {
                query += "@" + property.Name;

                if (property != properties.Last())
                {
                    query += ", ";
                }
            }

            query += ")";

            Console.WriteLine(query);

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            foreach (PropertyInfo property in properties)
            {
                command.Parameters.AddWithValue("@" + property.Name, property.GetValue(this));
            }

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Refresh();
        }

        public void Delete()
        {
            string query = "DELETE FROM " + _table + " WHERE id = " + Id;

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update()
        {
            string query = "UPDATE " + _table + " SET ";

            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                query += property.Name + " = @" + property.Name;

                if (property != properties.Last())
                {
                    query += ", ";
                }
            }

            query += " WHERE Id = " + Id;

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            foreach (PropertyInfo property in properties)
            {
                command.Parameters.AddWithValue("@" + property.Name, property.GetValue(this));
            }

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save()
        {
            if (Id == 0)
            {
                Write();
            }
            else
            {
                Update();
            }
        }

        public void Refresh()
        {
            BaseModel res = Get<BaseModel>(Id);

            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                property.SetValue(this, property.GetValue(res));
            }
        }

        public static BaseModel New<X>() where X : BaseModel, new()
        {
            string _table;
            if (!string.IsNullOrEmpty(manualTableOverride))
            {
                _table = typeof(X).Name;
            }
            else
            {
                _table = manualTableOverride;
            }
            string query = "SELECT MAX(Id) FROM " + _table;

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int id = command.ExecuteScalar() as int? ?? 0;
            connection.Close();

            X res = new X
            {
                Id = id + 1
            };

            PropertyInfo[] properties = typeof(X).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                property.SetValue(res, null);
                }

            return res;
        }

        public static BaseModel Get<X>(int id) where X : BaseModel, new()
        {
            string _table = typeof(X).Name;

            string query = "SELECT * FROM " + _table + " WHERE Id = " + id;

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                X res = new X();

                PropertyInfo[] properties = typeof(X).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType == typeof(int))
                    {
                        property.SetValue(res, reader[property.Name] as int? ?? 0);
                    }
                    else if (property.PropertyType == typeof(string))
                    {
                        property.SetValue(res, reader[property.Name] as string);
                    }
                    else if (property.PropertyType == typeof(double))
                    {
                        property.SetValue(res, reader[property.Name] as double? ?? 0);
                    }
                    else if (property.PropertyType == typeof(DateTime))
                    {
                        property.SetValue(res, reader[property.Name] as DateTime? ?? DateTime.Now);
                    }
                }

                return res;
            }

            connection.Close();

            throw new Exception("No data found");
        }

        public static BaseModel Find<X, Y>(string attribute, Y value) where X : BaseModel, new()
        {
            string _table = typeof(X).Name;

            string query = "SELECT * FROM " + _table + " WHERE " + attribute + " = '" + value.ToString() + "'";

            SqlConnection connection = new SqlConnection(Config.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                X res = new X();

                PropertyInfo[] properties = typeof(X).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType == typeof(int))
                    {
                        property.SetValue(res, reader[property.Name] as int? ?? 0);
                    }
                    else if (property.PropertyType == typeof(string))
                    {
                        property.SetValue(res, reader[property.Name] as string);
                    }
                    else if (property.PropertyType == typeof(double))
                    {
                        property.SetValue(res, reader[property.Name] as double? ?? 0);
                    }
                    else if (property.PropertyType == typeof(DateTime))
                    {
                        property.SetValue(res, reader[property.Name] as DateTime? ?? DateTime.Now);
                    }   
                }

                return res;
            }

            connection.Close();

            throw new Exception("No data found");
        }
    }
}
