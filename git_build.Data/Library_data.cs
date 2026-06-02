using System.Collections.Generic;
using System.Linq;
using git_build.Data.Database;

namespace git_build.Data
{
    public class Library_data : Elibrary_data
    {
        public List<Lib_user> Users { get; } = new List<Lib_user>();
        public Dictionary<string, Books_in_store> Catalog { get; } = new Dictionary<string, Books_in_store>();
        public List<Lib_event> Events { get; } = new List<Lib_event>();
        public Current_state State { get; } = new Current_state();
        public IEnumerable<Books_in_store> GetBooks()
        {
            return GetBooksMethodSyntax();
        }
        public IEnumerable<Books_in_store> GetBooksMethodSyntax()
        {
            using var db = new LibDbContext();

            return db.Books
                     .Where(b => !string.IsNullOrEmpty(b.Title))
                     .OrderBy(b => b.Title)
                     .ToList();
        }
        public IEnumerable<Books_in_store> GetBooksQuerySyntax()
        {
            using var db = new LibDbContext();

            var books =
                from b in db.Books
                orderby b.Title
                select b;

            return books.ToList();
        }
    }
}
