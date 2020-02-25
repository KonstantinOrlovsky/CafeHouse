

namespace Decorator.Drink
{
    class GreenTea:DrinkBase
    {
        public GreenTea()
        {
            description = "Green tea";

        }
        public override double GetCost()
        {
            return 100;
        }
    }
}
