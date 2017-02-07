
using System;

namespace AbstractFactoryPattern {
    public class ChicagoStyleCheesePizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Chicago Style Cheese Pizza");
        }
    }
}