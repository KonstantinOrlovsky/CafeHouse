

namespace Decorator.Drink
{
    class BlackTea:DrinkBase
    {
        

        public BlackTea()
        {
            description = "Black tea";
            
        }
        public override double GetCost()
        {
            return 100;
        }
    }

       
}
