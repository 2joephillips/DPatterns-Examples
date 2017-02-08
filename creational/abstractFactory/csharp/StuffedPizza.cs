using System;

namespace AbstractFactoryPattern {
    public class StuffedPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Chicago Style Cheese Pizza");
        }
    }
}