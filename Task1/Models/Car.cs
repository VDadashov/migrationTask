namespace Task1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public int Year { get; set; }
        public int ModellId { get; set; }
        public Modell Modell { get; set; }
    }
}
