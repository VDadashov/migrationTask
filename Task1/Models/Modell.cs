namespace Task1.Models
{
    public class Modell
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int  MarkaId { get; set; }
        public Marka Marka { get; set; }
    }
}
