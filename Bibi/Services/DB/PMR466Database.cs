using Bibi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace Bibi.Services.DB
{
    public class PMR466Database : BaseDatabase<PMR466Model>
    {
        public override void Add(PMR466Model value)
        {
            const string query = "INSERT INTO PMR466(Frequenz, Anmerkung) VALUES(@frequenz, @anmerkung)";
            Args = new Dictionary<string, object>
            {
                {"@frequenz", value.Frequenz },
                {"@anmerkung", value.Anmerkung }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public override void Delete(PMR466Model value)
        {
            const string query = "DELETE from PMR466 WHERE ID =@id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public override PMR466Model Get(string key)
        {
            const string query = "SELECT * FROM PMR466 WHERE ID = @id";
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
            PMR466Model model = new PMR466Model
            {
                ID = Convert.ToString(dt.Rows[0]["ID"]),
                Frequenz = Convert.ToString(dt.Rows[0]["Frequenz"]),
                Anmerkung = Convert.ToString(dt.Rows[0]["Anmerkung"])
            };
            Args.Clear();
            return model;
        }

        public override ObservableCollection<PMR466Model> Get()
        {
            const string query = "SELECT * FROM PMR466";
            DataTable dt = Execute(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                Args.Clear();
                return null;
            }
            ObservableCollection<PMR466Model> result = new ObservableCollection<PMR466Model>();
            foreach (DataRow rw in dt.Rows)
            {
                result.Add(new PMR466Model
                {
                    ID = Convert.ToString(rw["ID"]),
                    Frequenz = Convert.ToString(rw["Frequenz"]),
                    Anmerkung = Convert.ToString(rw["Anmerkung"])
                });
            }
            return result;
        }

        public override void Update(PMR466Model value)
        {
            const string query = "UPDATE PMR466 SET Frequenz = @frequenz, Anmerkung = @anmerkung WHERE ID = @id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID },
                {"@frequenz", value.Frequenz },
                {"@anmerkung", value.Anmerkung }
            };
            ExecuteWrite(query);
            Args.Clear();
        }
    }
}
