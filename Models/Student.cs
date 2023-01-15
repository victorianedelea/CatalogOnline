namespace CatalogOnline.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string NumeStudent { get; set; } = string.Empty;

        public string Facultate { get; set; } = string.Empty;

        public decimal An { get; set; }
    }
}
