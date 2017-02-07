namespace AbstractFactoryPattern {
    interface IPizzaStore{
        void listPizzas();
        IPizza orderPizza(string type);
    }
}