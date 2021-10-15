using System;

namespace OpsMoi.Models
{
    public struct Timeline
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string Title { get; set; }
        public string Mission { get; set; }
        public string DueTo { get; set; }
        public string Category { get; set; }
    }
}
