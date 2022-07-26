using BurgerBuilderPattern;


var burger = new Burger();
var builder = new BurgerBuilder(burger);

builder
    .AddCotlet()
    .AddCotlet()
    .AddCucumber()
    .AddSalad()
    .AddTomato();

Console.WriteLine(burger);