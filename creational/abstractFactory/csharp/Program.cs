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
            Console.WriteLine("Order Deep Dish Pizza.");
            IPizza pizza = store.orderPizza("DeepDish");
            pizza.createPizza();
  
        }
    }
}
