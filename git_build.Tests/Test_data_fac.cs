using git_build.Data;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace git_build.Tests
{
    public static class Test_data_fac
    {
        public static Elibrary_data CreateEmpty()
        {
            return new Library_data();
        }

        public static Elibrary_data CreateWithOneBook()
        {
            var data = new Library_data();

            data.Catalog.Add("123", new Books_in_store
            {
                ISBN = "123",
                Title = "Test Book"
            });

            data.Users.Add(new Lib_user
            {
                Id = "user1",
                Name = "Test User"
            });

            return data;
        }
    }
}
