﻿using System.Drawing;

namespace PruebaTecnicaRafaelCallata.Models
{
    public class ClimaResponse
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
