
using System;
using AbstractFactoryPattern.Contracts;
namespace AbstractFactoryPattern.Services {
    public class DeepDishPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Deep Dish Pizza");
        }
    }
}