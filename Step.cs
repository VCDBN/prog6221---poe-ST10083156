using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPOE
{
    public class Step
    {
        public string RecipeStep { get; set; }
       public static List<Step> steps { get; set; }
        public Step() { steps = new List<Step>(); }
        public Step(string recipeStep)
        {
            RecipeStep = recipeStep;
            steps =  new List<Step>();
        }

        
    }
}
