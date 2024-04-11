using SQLite;

namespace MauiAppShellMvvm.Models
{
    public class ExampleTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Counter { get; set; }
    }
}
