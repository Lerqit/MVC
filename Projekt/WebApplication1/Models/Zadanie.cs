namespace ZadaniaDomowe.Models
{
    public class Zadanie
    {
        public int Id { get; set; }
        public string Opis { get; set; } = string.Empty;
        public DateTime Termin { get; set; }
        public bool Wykonane { get; set; }
    }
}