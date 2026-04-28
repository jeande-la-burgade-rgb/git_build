using System.Collections.Generic;

namespace git_build.Data
{
    public class Library_data : Elibrary_data
    {
        public List<Lib_user> Users { get; } = new List<Lib_user>();
        public Dictionary<string, Books_in_store> Catalog { get; } = new Dictionary<string, Books_in_store>();
        public List<Lib_event> Events { get; } = new List<Lib_event>();
        public Current_state State { get; } = new Current_state();
    }
}
