
using System;

namespace AbstractFactoryPattern {
    public class DeepDishPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Deep Dish Pizza");
        }
    }
}