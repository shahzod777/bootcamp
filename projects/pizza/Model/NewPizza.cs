using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pizza.Model
{
    public class NewPizza
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        public string ShortName { get; set; }
        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EPizzaStockStatus? StockStatus { get; set; }
        [Required]
        [MaxLength(1024)]
        public List<string> Ingredients { get; set; }
        [Required]
        [Range(0, 1000)]
        public double Price { get; set; }
    }
}