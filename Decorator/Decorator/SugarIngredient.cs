using Decorator.Drink;

namespace Decorator.Decorator
{
    class SugarIngredient : IngredientDecorator
    {
        private DrinkBase _drinkBase;
        public SugarIngredient(DrinkBase drinkBase)
        {
            _drinkBase = drinkBase;
            description = _drinkBase.GetDescription() + "+sugar";
        }
        public override double GetCost()
        {
            return _drinkBase.GetCost() + 10;
        }
    }
}
