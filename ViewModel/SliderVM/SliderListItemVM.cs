﻿using System.ComponentModel.DataAnnotations;

namespace Pustok2.ViewModel.SliderVM
{
    public class SliderListItemVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Sekil daxil edin")]
        public string ImageUrl { get; set; }
        [Required, MinLength(3), MaxLength(64), DataType("nvarchar")]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(128), DataType("varchar")]
        public string Text { get; set; }
        public bool? IsLeft { get; set; }

        public sbyte Position { get; set; }
    }
}
