using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int nuggetCount = 6;
        //private bool additionalNugget = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" , "Chicken Nugget", "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" };
                //if (additionalNugget) AddNugget();
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            nuggetCount++;
            this.Ingredients.Add("Chicken Nugget");
            this.Price = 0.25* nuggetCount;
            this.Calories = (uint)(59 * nuggetCount);
        }
    }
}
