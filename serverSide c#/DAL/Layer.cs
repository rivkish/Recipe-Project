using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Layer
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Components { get; set; }


        //קשרי גומלין
        public int RecipeId { get; set; }//מפתח זר
        public virtual Recipe Recipe { get; set; }
    }
}
