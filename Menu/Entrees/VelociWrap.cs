using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool bun = true;
        private bool onions = true;
        private bool peppers = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                if (bun) ingredients.Add("whole-wheat bun");
                if (onions) ingredients.Add("Onions");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }
    }
}
