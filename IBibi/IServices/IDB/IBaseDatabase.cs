using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace IBibi.IServices.IDB
{
    public interface IBaseDatabase
    {
        Dictionary<string, object> Args { get; set; }
        string DBName { get; set; }
        string DBConnectionString { get; }
        string DBPfad { get; }

        DataTable Execute(string query);
        void ExecuteWrite(string query);
    }
    public interface IBaseDatabase<T>
    {
        void Add(T value);
        void Delete(T value);
        T Get(string key);
        ObservableCollection<T> Get();
        void Update(T value);
    }
}
