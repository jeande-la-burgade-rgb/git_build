using git_build.Data;
using System.Collections.Generic;
using System.Linq;

namespace git_build.Tests
{
    public class FakeLibraryData : Elibrary_data
    {
        public Dictionary<string, Books_in_store> Catalog { get; set; } = new();
        public List<Lib_user> Users { get; set; } = new();
        public List<Lib_event> Events { get; set; } = new();
        public Current_state State { get; set; } = new();
        public IEnumerable<Books_in_store> GetBooks()
        {
            return Catalog.Values;
        }
    }
}