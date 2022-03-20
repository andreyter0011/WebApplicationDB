namespace WebSite.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public string Degree { get; set; }
        public string Title { get; set; }
        public int Exp { get; set; }
        public int? MonographId { get; set; }
        public Monograph Monograph { get; set; }
    }
}
