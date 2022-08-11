namespace PruebaTecnicaRafaelCallata.Models
{
    public class NoticiasResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
}
