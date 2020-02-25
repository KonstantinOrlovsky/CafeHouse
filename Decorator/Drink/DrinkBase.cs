

namespace Decorator.Drink
{
    abstract class DrinkBase
    {
       
        protected string description = "";
        public string GetDescription()
        {
            return description;
        }
        public virtual double GetCost()
        {
            
            return 0.0;
        }
     


    }
}
