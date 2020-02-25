using Decorator.Drink;

namespace Decorator.Decorator
{
    class MilkIngredient : IngredientDecorator
    {
        private DrinkBase _drinkBase;

        public MilkIngredient(DrinkBase drinkBase)
        {
            _drinkBase = drinkBase;
            description = _drinkBase.GetDescription() + "+milk";
        }
        
        public override double GetCost()
        {
            return _drinkBase.GetCost()+30;
        }
    }
}
