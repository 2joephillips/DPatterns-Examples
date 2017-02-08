using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
    public class ChicagoStylePizza : IPizzaStore
    {
        List<String> Pizzas = new List<String>() {"Deep Dish Pizza", "Stuffed Pizza"};
        public IPizza orderPizza(string type)
        {
            if(type == "Deep Dish"){
                return new DeepDishPizza();
            }
            else {
                return new StuffedPizza();
            }
        }

        public void listPizzas()
        {
            Console.WriteLine("The following Chicago Style Pizzas are available" + Environment.NewLine);
            foreach(string pizza in Pizzas){
                System.Console.WriteLine(pizza);
            }
        }
    }
}