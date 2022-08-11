using System;
using System.Collections.Generic;

namespace PruebaTecnicaRafaelCallata.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public string Autor { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string UrlImage { get; set; } = null!;
        public DateTime PublishetAt { get; set; }
        public string Content { get; set; } = null!;
    }
}
