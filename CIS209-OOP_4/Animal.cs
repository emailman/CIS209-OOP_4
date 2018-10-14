namespace CIS209_OOP_4
{
    abstract class Animal
    {
        public abstract string Sound();
    }


    class Chicken : Animal, IEdible
    {
        public override string Sound()
        {
            return "Chicken: Cock-a-doodle-doo";
        }

        public string HowToEat()
        {
            return "Chicken: Fry it";
        }
    }

    class Tiger : Animal
    {
        public override string Sound()
        {
            return "Tiger: ROOAARR";
        }
    }
}
