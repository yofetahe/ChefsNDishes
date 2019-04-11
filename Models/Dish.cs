using System.ComponentModel.DataAnnotations;
using System;

namespace ChefNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}

        [Display(Name="Name of Dish")]
        [Required(ErrorMessage="Dish Name is required")]
        public string Name {get; set;}

        [Display(Name="Tastiness")]
        [Required(ErrorMessage="Tastiness is required")]
        [Range(1, 5, ErrorMessage="Tastiness must be between 1 and 5")]
        public int Tastiness {get; set;}

        [Display(Name="# of Calories")]
        [Required(ErrorMessage="Calories is required")]
        [Range(1, 2000, ErrorMessage="Calories must be greater than 1")]
        public int Calories {get; set;}

        [Display(Name="Description")]
        [Required(ErrorMessage="Description is required")]
        public string Description {get; set;}

        [Display(Name="Chef's Name")]
        public int ChefId { get; set; }

        public Chef PreparedBy { get; set; }

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}