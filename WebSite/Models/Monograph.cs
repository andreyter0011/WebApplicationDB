using System.Collections.Generic;

namespace WebSite.Models
{
    public class Monograph
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publish { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public Monograph()
        {
            Teachers = new List<Teacher>();
        }
    }
}
