using System;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            IPizzaStore store = new ChicagoStylePizza();
            store.listPizzas();
            var pizza = store.orderPizza("cheese");
            pizza.createPizza();

            //example of abstract factory
            //AmericanBreadFactory vAmericanBread = new AmericanBreadFactory();
            //Bread vBread = vAmericanBread.GetBread(BreadBase.VeggieBase);
            //vBread.Bake();

            //lets bak indian punjabi tadka bread
            //IndianBreadFactory vIndianBreadFactory = new IndianBreadFactory();
            //Bread vIndianBread = vIndianBreadFactory.GetBread(BreadBase.PunjabiTadkaBase);
            //vIndianBread.Bake();
            
        }
    }
}
