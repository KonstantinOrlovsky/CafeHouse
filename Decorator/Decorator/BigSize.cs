using Decorator.Drink;

namespace Decorator.Decorator
{
    class BigSize:DrinkBase
    {
    private DrinkBase _drinkBase;
    public BigSize(DrinkBase drinkBase)
    {
        _drinkBase = drinkBase;
        description = _drinkBase.GetDescription() + "+big size";
    }
    public override double GetCost()
    {
        return _drinkBase.GetCost() * 1.2;
    }
}
}
