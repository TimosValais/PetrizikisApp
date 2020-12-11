using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetrizikisApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Display(Name = "Recipe Name")]
        
        public string RecipeName { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan Duration { get; set; }


    }
}