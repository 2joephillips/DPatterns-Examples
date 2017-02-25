using System;
using AbstractFactoryPattern.Contracts;
using AbstractFactoryPattern.Services;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome." + Environment.NewLine);
            IPizzaStore store = new ChicagoStylePizza();
            
            store.listPizzas();

            System.Console.WriteLine("What type of Chicago Style pizzas' do you have?"+ Environment.NewLine);

            Console.WriteLine("Can I order Deep Dish Pizza."+ Environment.NewLine);  
            IPizza pizza = store.orderPizza("Deep Dish");
            pizza.createPizza();
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Welcome."+ Environment.NewLine);
            IPizzaStore store1 = new NewYorkStylePizza();
            
            store.listPizzas();

            System.Console.WriteLine("What type of New York Style pizzas' do you have?"+ Environment.NewLine);
            
            Console.WriteLine("Can I order Deep Hand Tossed."+ Environment.NewLine);
            IPizza pizza2 = store.orderPizza("HandTossed");
            pizza.createPizza();
        }
    }
}
