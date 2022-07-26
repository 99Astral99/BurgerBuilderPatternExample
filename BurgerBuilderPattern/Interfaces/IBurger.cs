namespace BurgerBuilderPattern
{
    public interface IBurger
    {
        IBurger AddCotlet();
        IBurger AddCucumber();
        IBurger AddSalad();
        IBurger AddBacon();
        IBurger AddCheeze();
        IBurger AddTomato();

        Burger GetBurger();
    }
}
