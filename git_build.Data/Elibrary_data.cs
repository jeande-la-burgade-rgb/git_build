using System.Collections.Generic;

namespace git_build.Data
{
    public interface Elibrary_data
    {
        List<Lib_user> Users { get; }
        Dictionary<string, Books_in_store> Catalog { get; }
        List<Lib_event> Events { get; }
        Current_state State { get; }
    }
}
