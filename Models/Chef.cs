using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Display(Name="Chef's First Name")]
        [Required(ErrorMessage="Chef's First Name is required")]
        public string FristName {get; set;}

        [Display(Name="Chef's First Name")]
        [Required(ErrorMessage="Chef's Last Name is required")]
        public string LastName {get; set;}

        [Display(Name="Date of Birth")]
        [Required(ErrorMessage="Chef's date of birth is required")]
        [DataType(DataType.DateTime)]
        public DateTime DOB {get; set;}

        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}