using System;

namespace git_build.Data
{
    public class Lib_event
    {
        public string Type { get; set; } // Borrow / Return
        public string BookISBN { get; set; }
        public string UserId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
