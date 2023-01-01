using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }


        //קשרי גומלין
        public virtual List<Recipe> Recipes { get; set; }

    }
}
