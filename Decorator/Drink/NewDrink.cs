

namespace Decorator.Drink
{
    class NewDrink:DrinkBase
    {
        public NewDrink()
        {
            description = "New Drink";

        }
        public override double GetCost()
        {
            return 0;
        }
    }
}
