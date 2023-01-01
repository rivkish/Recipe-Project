using System;
using System.Collections.Generic;

namespace DAL
{
    public class Recipe
    {
         
        public int Id { get; set; }
        public string Name { get; set; }      
        public int PreparationTimeInMinute { get; set; }
        public int Level { get; set; }
        public DateTime AddDate { get; set; }       
        public string Preparation { get; set; }        
        public string Image { get; set; }
        public bool IsDisplay { get; set; }

        //מפה זה הקשרי גומלין

        public virtual List<Layer> Layers { get; set; }

        public int UserId { get; set; }//מפתח זר
        public virtual User User { get; set; }

      public int CategoryId { get; set; }//מפתח זר
        public virtual Category Category { get; set; }
    }
}
