using System;
using System.Collections.Generic;
using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Services {
    public class NewYorkStylePizza : IPizzaStore
    {
        List<String> Pizzas = new List<String>() {"Hand-tossed Pizza", "Thin-crust Pizza"};
        public IPizza orderPizza(string type)
        {
            if(type == "HandTossed"){
                return new HandTossedPizza();
            }
            else {
                return new ThinCrustPizza();
            }
        }

        public void listPizzas()
        {
            Console.WriteLine("The following Chicago Style Pizzas are available" );
            foreach(string pizza in Pizzas){
                Console.WriteLine(pizza);
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}