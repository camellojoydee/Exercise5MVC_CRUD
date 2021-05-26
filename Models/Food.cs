using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exercise4MVC.Models
{
    public class Food
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Food Name")]
        public string FoodName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Food Description")]
        public string FoodDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }
    }
}
