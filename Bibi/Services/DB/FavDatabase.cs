using Bibi.Model;
using IBibi.IServices.IDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace Bibi.Services.DB
{
    public class FavDatabase : BaseDatabase<FavModel>, IBaseDatabase<FavModel>
    {
        public void Add(FavModel value)
        {
            const string query = "INSERT INTO Voreinstellungen(Name, PID, CID, Anmerkung) VALUES(@name, @pID, @cId, @anmerkung)";
            Args = new Dictionary<string, object>
            {
                {"@name", value.Name },
                {"@pID", value.PID },
                {"@cID", value.CID },
                {"@anmerkung", value.Anmerkung }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public void Delete(FavModel value)
        {
            const string query = "DELETE from Voreinstellungen WHERE ID =@id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID }
            };
            ExecuteWrite(query);
            Args.Clear();
        }

        public FavModel Get(string key)
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
            FavModel model = new FavModel
            {
                ID = Convert.ToString(dt.Rows[0]["ID"]),
                Name = Convert.ToString(dt.Rows[0]["Name"]),
                PID = Convert.ToString(dt.Rows[0]["PID"]),
                CID = Convert.ToString(dt.Rows[0]["CID"]),
                Anmerkung = Convert.ToString(dt.Rows[0]["Anmerkung"])
            };
            Args.Clear();
            return model;
        }

        public ObservableCollection<FavModel> Get()
        {
            const string query = "SELECT * FROM Voreinstellungen";
            DataTable dt = Execute(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                Args.Clear();
                return null;
            }
            ObservableCollection<FavModel> result = new ObservableCollection<FavModel>();
            foreach(DataRow rw in dt.Rows)
            {
                result.Add(new FavModel { 
                    ID = Convert.ToString(rw["ID"]),
                    Name = Convert.ToString(rw["Name"]),
                    PID = Convert.ToString(rw["PID"]),
                    CID = Convert.ToString(rw["CID"]),
                    Anmerkung = Convert.ToString(rw["Anmerkung"])
                });
            }
            return result;
        }

        public void Update(FavModel value)
        {
            const string query = "UPDATE Voreinstellungen SET Name = @name, PID = @pID, CID = @cID, Anmerkung = @anmerkung WHERE ID = @id";
            Args = new Dictionary<string, object>
            {
                {"@id", value.ID },
                {"@name", value.Name },
                {"@pID", value.PID },
                {"@cID", value.CID },
                {"@anmerkung", value.Anmerkung }
            };
            ExecuteWrite(query);
            Args.Clear();
        }
    }
}
