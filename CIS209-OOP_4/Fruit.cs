namespace CIS209_OOP_4
{
    abstract class Fruit : IEdible
    {
        public abstract string HowToEat();  
    }

    class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple: Make apple cider";
        }
    }

    class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange: Make orange juice";
        }
    }
}
