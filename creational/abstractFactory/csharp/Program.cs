using System;
using AbstractFactoryPattern.Contracts;
using AbstractFactoryPattern.Services;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            IPizzaStore store = new ChicagoStylePizza();
            System.Console.WriteLine("What type of Chicago Style pizzas' do you have?");
            store.listPizzas();
            Console.WriteLine("Order Deep Dish Pizza.");
            IPizza pizza = store.orderPizza("DeepDish");
            pizza.createPizza();
            
            
        }
    }
}
