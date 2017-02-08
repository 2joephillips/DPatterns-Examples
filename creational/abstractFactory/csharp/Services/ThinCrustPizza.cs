
using System;
using AbstractFactoryPattern.Contracts;
namespace AbstractFactoryPattern.Services {
    public class ThinCrustPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Thin-crust Pizza");
        }
    }
}