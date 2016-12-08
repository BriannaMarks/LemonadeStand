using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeRecipie
    {
        int recipeLemon;
        int recipeSugar;
        int recipeIce;
        int lemonadePotency;

        public void ChangeLemonadeRecipe()
        {
            SetRecipeLemon();
            SetRecipeSugar();
            SetRecipeIce();
            GetRecipeIce();
            GetRecipeSugar();
            GetRecipeLemon();
            LemonadePotency();
        }
        private int GetRecipeLemon()
        {
            Console.WriteLine("You will use {0} lemons in your recipe.", recipeLemon);
            return recipeLemon;
        }
        private int GetRecipeSugar()
        {
            Console.WriteLine("You will use {0} cups of sugar in your recipe.", recipeSugar);
            return recipeSugar;
        }
        private int GetRecipeIce()
        {
            Console.WriteLine("You will use {0} ice cubes in your recipe.", recipeIce);
            return recipeIce;
        }
        private void SetRecipeLemon()
        {
            Console.WriteLine("How many lemons would you like to use?");
            try
            {
                 recipeLemon = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
                SetRecipeLemon();
            }
        }
        private void SetRecipeSugar()
        {
            Console.WriteLine("How much sugar would you like to use?");
            try
            {
                recipeSugar = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
                SetRecipeSugar();
            }
        }
        private void SetRecipeIce()
        {
            Console.WriteLine("How much ice would you like to use?");
            try
            {
                recipeIce = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
                SetRecipeIce();
            }
        }
        public int LemonadePotency()
        {
            int i = 2;
            lemonadePotency = (((recipeLemon * (recipeIce - i)) * recipeSugar) + i);

            return lemonadePotency;
        }
    }
}
