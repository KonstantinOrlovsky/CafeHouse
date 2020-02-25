using System;

using Decorator.Drink;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            DrinkBase blackTea = new BlackTea();
            PrintDrink(blackTea);
            DrinkBase BlackTeaWithSugar = new SugarIngredient(new BlackTea());
            PrintDrink(BlackTeaWithSugar);
            DrinkBase latteCofee = new MilkIngredient(new SugarIngredient(new Espresso()));
            PrintDrink(latteCofee);
            DrinkBase BlackTeaWithDoubleSugar = new SugarIngredient(new SugarIngredient(new BlackTea()));
            PrintDrink(BlackTeaWithDoubleSugar);
            DrinkBase greenTeaWhithSugarSmallSize = new SugarIngredient(new SmallSize(new GreenTea()));
            PrintDrink(greenTeaWhithSugarSmallSize);
            DrinkBase hotChololate = new SugarIngredient(new MilkIngredient(new ChocolateIngredient(new NewDrink())));
            PrintDrink(hotChololate);


            Console.Read();
        }
        static void PrintDrink( DrinkBase drinkBase)
        {
            Console.WriteLine($"Drink:{drinkBase.GetDescription()} Price:{drinkBase.GetCost()}");
        }
    }
}
