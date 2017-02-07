using System;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            IPizzaStore store = new ChicagoStylePizza();
            store.listPizzas();
            var pizza = store.orderPizza("cheese");
            pizza.createPizza();


            
        }
    }
}
