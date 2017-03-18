"use strict";
var PizzaShop = function(){};

PizzaShop.prototype = {
    sellPizza: function(type){
        var pizza = this.createPizza(type);
        return pizza;
    },
    createPizza: function(type) {
        throw new Error("createPizza must be implemented by subclass");
    }
}

var ChicagoPizza = function(){};
ChicagoPizza.prototype = new PizzaShop();
ChicagoPizza.prototype.createPizza = function(type){
    var pizza;

    switch(type) {
        case 'DeepDish':
            pizza = new ChicagoPizzaDeepDish();
            break;
        case 'StuffedPizza':
            pizza = new ChicagoPizzaStuffedPizza();
            break;
    }

    return pizza;
}

var NewYorkStylePizza = function(){};
NewYorkStylePizza.prototype = new PizzaShop();
NewYorkStylePizza.prototype.createPizza = function(type){
    var pizza;

    switch(type) {
        case 'HandTossed':
            pizza = new NewYorkStylePizzaHandTossed();
            break;
        case 'ThinCrust':
            pizza = new NewYorkStylePizzaThinCrust();
            break;
    }
    return pizza;
}
