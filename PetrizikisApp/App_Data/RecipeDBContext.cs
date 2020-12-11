using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetrizikisApp.Models
{
    public class RecipeDBContext : DbContext
    {

        public DbSet<Ingredient> IngedientsDBContext { get; set; }

        public System.Data.Entity.DbSet<PetrizikisApp.Models.Recipe> Recipes { get; set; }
    }
}