using Decorator.Drink;

namespace Decorator.Decorator
{
    class SmallSize : IngredientDecorator
    {
        private DrinkBase _drinkBase;
        public SmallSize(DrinkBase drinkBase)
        {
            _drinkBase = drinkBase;
            description = _drinkBase.GetDescription() + "+small size";
        }
        public override double GetCost()
        {
            return _drinkBase.GetCost()*0.8;
        }
    }
}
