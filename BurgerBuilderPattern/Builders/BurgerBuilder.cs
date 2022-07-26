using BurgerBuilderPattern;

namespace BurgerBuilderPattern
{
    public class BurgerBuilder : IBurger
    {
        private Burger _burger;

        public BurgerBuilder(Burger burger)
        {
            _burger = burger;
        }

        public IBurger AddBacon()
        {
            _burger.Bacon = true;
            _burger.Total += 1.75m;
            return this;
        }

        public IBurger AddCheeze()
        {
            _burger.Cheeze = true;
            _burger.Total += 1.65m;
            return this;
        }

        public IBurger AddCotlet()
        {
            _burger.Cotlet = true;
            _burger.Total += 2;
            return this;
        }

        public IBurger AddCucumber()
        {
            _burger.Cucumber = true;
            _burger.Total += 1.5m;
            return this;
        }

        public IBurger AddSalad()
        {
            _burger.Salad = true;
            _burger.Total += 0.75m;
            return this;
        }

        public IBurger AddTomato()
        {
            _burger.Tomato = true;
            _burger.Total += 1.25m;
            return this;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;
            _burger = new();
            return burger;
        }
    }
}
