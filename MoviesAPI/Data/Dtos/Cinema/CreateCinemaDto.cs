﻿using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos.Cinema
{
    public class CreateCinemaDto
    {

        [Required(ErrorMessage = "The Name field is required")]
        public string Name { get; set; }

        public int LocationFk { get; set; }

        public int ManegerFK { get; set; }
    }
}