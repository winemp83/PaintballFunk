using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using Bibi.Model;

namespace Bibi.Services.DB
{
    public class CTSSDatabase : BaseDatabase<CTSSModel>
    {
        public override void Add(CTSSModel value)
        {
            const string query = "INSERT INTO CTSS(Ton, StandartChannel VALUES(@ton, @standartChannel)";
            Args = new Dictionary<string, object>
            {
                {"@ton", value.Ton },
                {"@standartChannel", value.SC }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public override void Delete(CTSSModel value)
        {
            const string query = "DELETE from CTSS WHERE ID =@id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public override CTSSModel Get(string key)
        {
            const string query = "SELECT * FROM CTSS WHERE ID = @id";
            Args = new Dictionary<string, object>
            {
                {"@id", key }
            };
            DataTable dt = Execute(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                Args.Clear();
                return null;
            }
            CTSSModel model = new CTSSModel
            {
                ID = Convert.ToString(dt.Rows[0]["ID"]),
                Ton = Convert.ToString(dt.Rows[0]["Ton"]),
                SC = Convert.ToString(dt.Rows[0]["StandartChannel"])
            };
            Args.Clear();
            return model;
        }

        public override ObservableCollection<CTSSModel> Get()
        {
            const string query = "SELECT * FROM CTSS";
            DataTable dt = Execute(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                Args.Clear();
                return null;
            }
            ObservableCollection<CTSSModel> result = new ObservableCollection<CTSSModel>();
            foreach(DataRow rw in dt.Rows)
            {
                result.Add(new CTSSModel { 
                    ID = Convert.ToString(rw["ID"]),
                    Ton = Convert.ToString(rw["Ton"]),
                    SC = Convert.ToString(rw["StandartChannel"])
                });
            }
            return result;
        }

        public override void Update(CTSSModel value)
        {
            const string query = "UPDATE CTSS SET Ton = @ton, StandartChannel = @standartChannel WHERE ID = @id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID },
                {"@ton", value.Ton },
                {"@standartChannel", value.SC }
            };
            ExecuteWrite(query);
            Args.Clear();
        }
    }
}
