using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LayerDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public List<string> Components { get; set; }


        public int RecipeId { get; set; }//מפתח זר
    }
}
