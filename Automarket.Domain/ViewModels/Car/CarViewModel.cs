using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime DateCreate { get; set; }
        public string TypeCar { get; set; }
    }
}