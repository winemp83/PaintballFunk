using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;

namespace Bibi.Services.DB
{
    public abstract class BaseDatabase
    {
        public Dictionary<string, object> Args { get; set; }
        public string DBName { get; set; }
        public string DBConnectionString { get => DBPfad + DBName;}
        public string DBPfad { get => AppDomain.CurrentDomain.BaseDirectory;}
        public DataTable Execute(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                Args.Clear();
                return null;
            }

            using (var con = new SQLiteConnection("Data Source="+DBConnectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                {
                    if (Args.Count > 0)
                    {
                        foreach (KeyValuePair<string, object> entry in Args)
                        {
                            cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                        }
                    }
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    Args.Clear();
                    return dt;
                }
            }
        }
        public void ExecuteWrite(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                Args.Clear();
                return;
            }

            using (var con = new SQLiteConnection("Data Source="+DBConnectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                {
                    if (Args.Count > 0)
                    {
                        foreach (var pairs in Args)
                        {
                            cmd.Parameters.AddWithValue(pairs.Key, pairs.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                Args.Clear();
            }
        }
    }
    public abstract class BaseDatabase<T> : BaseDatabase
    {

        public abstract void Add(T value);
        public abstract void Delete(T value);
        public abstract T Get(string key);
        public abstract ObservableCollection<T> Get();
        public abstract void Update(T value);
    }
}
