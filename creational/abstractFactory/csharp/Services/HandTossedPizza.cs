using System;
using AbstractFactoryPattern.Contracts;
namespace AbstractFactoryPattern.Services {
    public class HandTossedPizza : IPizza{
        public void createPizza(){
            Console.WriteLine("Hand-tossed Pizza");
        }
    }
}