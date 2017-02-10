using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resteraunt.Models.Entities
{
    [Table("tbl_food",Schema="public")]
    public class Food
    {
        [Key]
        [Column("food_id")]
        public int food_id{set;get;}
        
        [Column("food")]
        public String food { set; get; }
        
        [Column("food_image")]
        public String food_image { set; get; }
     
        [Column("price")]
        public decimal price { set; get; }

        [Column("description")]
        public String description { set; get; }

        [Column("menu_id")]
        public int menu_id { set; get; }

        [Column("created")]
        public DateTime created { set; get; }

        [Column("active")]
        public int active{ set; get; }
            
    }

    public class FoodDbContext : DbContext
    {
        public FoodDbContext() : base(nameOrConnectionString: "restaurantConnection") { }
        public DbSet<Food> foods { get; set; }
    }

}