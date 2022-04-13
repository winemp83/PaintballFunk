using EngineWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;

namespace EngineWPF.Service
{
    public class PMR466DB : DBBase<PMR466Model>
    {
        #region Private Members
        private string _Query;
        #endregion
        #region Constructor
        public PMR466DB()
        {
            TableName = "PMR466";
            if (!File.Exists(DBPath+DBName))
                Create();
            else
                Get();
        }
        #endregion
        #region Public Methods
        public override void Create()
        {
            _Query = @"CREATE TABLE "+TableName+" ("+
                      "ID    INTEGER NOT NULL,"+
                      "Channel  TEXT NOT NULL,"+
                      "Frequenz TEXT NOT NULL,"+
                      "Description   TEXT,"+
                      "PRIMARY KEY(ID AUTOINCREMENT));";
            ExecuteWrite(_Query);
        }
        public override void Delete()
        {
            _Query = "DELETE FROM "+TableName+" WHERE ID = @iD";
            Args = new Dictionary<string, object>
            {
                {"@iD", Value.ID }
            };
            ExecuteWrite(_Query);
            Args.Clear();
        }
        public override void Get()
        {
            _Query = "SELECT * FROM "+TableName;
            DataTable result = ExecuteRead(_Query);
            if(result == null || result.Rows.Count == 0)
            {
                ErrorLogger.LogActivity(String.Format("Query : {0} \r\n Ohne Ergebniss ausgeführt!", _Query), "OK");
                Args.Clear();
                return;
            }
            Values = new ObservableCollection<PMR466Model>();
            foreach (DataRow row in result.Rows)
                Values.Add(new PMR466Model
                {
                    ID = Convert.ToString(row["ID"]),
                    Channel = Convert.ToString(row["Channel"]),
                    Frequenz = Convert.ToString(row["Frequenz"]),
                    Anmerkung = Convert.ToString(row["Description"])
                });
        }
        public override void GetOne(string key)
        {
            _Query = "SELECT * FROM "+TableName+" WHERE ID = @id";
            Args = new Dictionary<string, object>
            {
                {"@id", key }
            };
            DataTable result = ExecuteRead(_Query);
            if (result == null || result.Rows.Count == 0)
            {
                ErrorLogger.LogActivity(String.Format("Query : {0} \r\n Ohne Ergebniss ausgeführt!", _Query), "OK");
                Args.Clear();
                return;
            }
            Value = new PMR466Model
            {
                ID = Convert.ToString(result.Rows[0]["ID"]),
                Channel = Convert.ToString(result.Rows[0]["Channel"]),
                Frequenz = Convert.ToString(result.Rows[0]["Frequenz"]),
                Anmerkung = Convert.ToString(result.Rows[0]["Description"])
            };
            Args.Clear();
        }
        public override void Insert()
        {
            _Query = "INSERT INTO "+TableName+"(Channel, Frequenz, Description) VALUES(@channel, @frequenz, @description)";
            PrepareAndExecuteArgs();
        }
        public override void Update()
        {
            _Query = "UPDATE PMR466 SET Channel = @channel, Frequenz = @frequenz, Description = @description WHERE ID = @iD";
            PrepareAndExecuteArgs();
        }
        #endregion
        #region Private Methods
        private void PrepareAndExecuteArgs()
        {
            Args = new Dictionary<string, object>
            {
                {"@iD", Value.ID},
                {"@channel", Value.Channel },
                {"@frequenz", Value.Frequenz },
                {"@description", Value.Anmerkung }
            };
            ExecuteWrite(_Query);
            Args.Clear();
        }
        #endregion
    }
}
