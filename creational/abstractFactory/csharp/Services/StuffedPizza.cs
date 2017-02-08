using System;
using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Services {
    public class StuffedPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Chicago Style Cheese Pizza");
        }
    }
}