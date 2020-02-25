using Decorator.Drink;

namespace Decorator.Decorator
{
    class ChocolateIngredient:IngredientDecorator
    {
        private DrinkBase _drinkBase;
        public ChocolateIngredient(DrinkBase drinkBase)
        {
            _drinkBase = drinkBase;
            description = _drinkBase.GetDescription() + "+chocolate";
        }
        public override double GetCost()
        {
            return _drinkBase.GetCost()+50;
        }
    }
}
