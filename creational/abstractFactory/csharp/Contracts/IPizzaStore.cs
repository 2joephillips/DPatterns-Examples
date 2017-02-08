namespace AbstractFactoryPattern.Contracts {
    interface IPizzaStore{
        void listPizzas();
        IPizza orderPizza(string type);
    }
}