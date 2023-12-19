﻿using System.ComponentModel.DataAnnotations;

namespace aspproj.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        //Relationships
        public List<Movie> Movies { get; set; } = null!;

    }
}
