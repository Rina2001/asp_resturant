using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Resteraunt.Models.Entities
{
   [Table("tbl_user", Schema = "public")]
    public class User
    {
       [Key]
       [Column("user_id")]
        public int user_id { get; set; }
       [Column("username")]
       public String username { get; set; }
       [Column("email")] 
       public String email {get;set;}
       [Column("img_url")]
       public String img_url { get; set; }
       [Column("password")] 
       public String password { get; set; }
       [Column("gender")]
        public String gender { get; set; }
       [Column("address")] 
       public String address { get; set; }
        [Column("active")]
       public int active { get; set; }
    }
   public class UserDbContext : DbContext
   {
       public UserDbContext() : base(nameOrConnectionString: "restaurantConnection") { }
       public DbSet<User> users { get; set; }
   }
  
}