using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;

namespace EngineWPF.Service
{
    public abstract class DBBase
    {
        #region Private Members
        private string _dbName;
        private string _tableName;
        private string _lastError;
        private Dictionary<string, object> _data;
        #endregion
        #region Puplic Members
        public string DBName
        {
            get
            {
                if (string.IsNullOrEmpty(_dbName))
                    return Resource1.DBName+".sql";
                return _dbName;
            }
            private set => _dbName = value;
        }
        public string DBPath
        {
            get => AppDomain.CurrentDomain.BaseDirectory;
        }
        public string TableName
        {
            get => _tableName;
            set => _tableName = value;
        }
        public string LastError
        {
            get => _lastError;
            protected set => _lastError = value;
        }
        public Dictionary<string, object> Args
        {
            get => _data;
            set => _data = value;
        }
        #endregion
        #region Public Methods
        public void ExecuteWrite(string query)
        {
            string DB = DBPath+DBName;
            try
            {
                if (string.IsNullOrEmpty(query.Trim()))
                    throw new Exception("Query ist Leer!");

                using var con = new SQLiteConnection("Data Source="+DB);
                con.Open();
                using var cmd = new SQLiteCommand(query, con);
                if (Args.Count > 0)
                {
                    foreach (var pair in Args)
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                LastError = Ex.Message;
                ErrorLogger.LogActivity(LastError, "Fail");
            }
        }
        public DataTable ExecuteRead(string query)
        {
            try
            {
                if (string.IsNullOrEmpty(query.Trim()))
                    throw new Exception("Query ist Leer!");

                using var con = new SQLiteConnection("Data Source=test.db");
                con.Open();
                using var cmd = new SQLiteCommand(query, con);
                if (Args.Count > 0)
                    foreach (KeyValuePair<string, object> entry in Args)
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);

                var da = new SQLiteDataAdapter(cmd);

                var dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
            catch (Exception Ex)
            {
                LastError = Ex.Message;
                ErrorLogger.LogActivity(LastError, "Fail");
            }
            return null;
        }
        #endregion
        #region Public abstract Methods
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract void Get();
        public abstract void GetOne(string key);
        public abstract void Create();
        #endregion
    }
    public abstract class DBBase<T> : DBBase
    {
        #region Private Members
        private T _Value;
        private ObservableCollection<T> _Values;
        #endregion
        #region Public Members
        public T Value {
            get => _Value;
            set => _Value = value;
        }
        public ObservableCollection<T> Values {
            get => _Values;
            set => _Values = value;
        }
        #endregion
        #region public Methods
        
        #endregion
    }
}
