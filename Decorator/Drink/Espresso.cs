


namespace Decorator.Drink
{
    class Espresso : DrinkBase
    {
        public Espresso()
        {
            description = "Coffe espresso";
        }
        public override double GetCost()
        {
            return 100;
        }

        
    }
}
