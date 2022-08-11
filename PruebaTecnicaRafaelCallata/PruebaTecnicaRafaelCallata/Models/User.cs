using System;
using System.Collections.Generic;

namespace PruebaTecnicaRafaelCallata.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Contra { get; set; } = null!;
    }
}
