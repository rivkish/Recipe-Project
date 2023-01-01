using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class User
    {
        private static int idForAll;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        //קשרי גומלין
        public virtual List<Recipe> Recipes { get; set; }
    }
}
