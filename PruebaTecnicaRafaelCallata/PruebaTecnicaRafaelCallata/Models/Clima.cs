namespace PruebaTecnicaRafaelCallata.Models
{
    public class Clima
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Temp { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public double Temp_maxi { get; set; }
        public double Temp_min { get; set; }
        public double Feels_like { get; set; }
        public double Humidity { get; set; }
        public double Speed { get; set; }
    }
}
