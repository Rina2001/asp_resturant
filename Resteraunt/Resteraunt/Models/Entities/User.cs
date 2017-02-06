using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resteraunt.Models.Entities
{
    public class User
    {
        public int user_id { get; set; }
        public String username { get; set; }
        public String email {get;set;}
        public String img_url { get; set; }
        public String password { get; set; }
        public String gender { get; set; }
        public String addresss { get; set; }
        public int active { get; set; }
    }
}