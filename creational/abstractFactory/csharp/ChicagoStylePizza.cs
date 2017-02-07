using System;

namespace AbstractFactoryPattern {
    public class ChicagoStylePizza : IPizzaStore
    {
        public IPizza orderPizza(string type)
        {
            if(type == "cheese"){
                return new ChicagoStyleCheesePizza();
            }
            else {
                return new ChicagoStyleCheesePizza();
            }
        }

        public void listPizzas()
        {
            Console.WriteLine("The following Chicago Style Pizzas are available" + Environment.NewLine);
        }
    }
}