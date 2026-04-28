using System;
using git_build.Data;
using git_build.Logic;

namespace git_build
{
    class Program
    {
        static void Main(string[] args)
        {
            Elibrary_data data = new Library_data();

            data.Catalog.Add("123", new Books_in_store
            {
                ISBN = "123",
                Title = "Solaris"
            });

            data.Users.Add(new Lib_user
            {
                Id = "user1",
                Name = "Stanislas"
            });

            Elibrary_logic logic = new Library_logic(data);

            logic.BorrowBook("user1", "123");

            Console.WriteLine("Book borrowed successfully!");
        }
    }
}
