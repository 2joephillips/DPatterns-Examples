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

var NewYorkStylePizzaHandTossed = function(){
    return {
        type: 'Hand Tossed'
    }
}

var NewYorkStylePizzaThinCrust = function(){
    return {
        type: 'Thin Crust'
    }
}

var ChicagoPizzaDeepDish = function(){
    return {
        type: 'Deep Dish'
    }
}

var ChicagoPizzaStuffedPizza = function(){
    return {
        type: 'Stuffed Pizza'
    }
}

var shop = new NewYorkStylePizza();
var pizza = shop.sellPizza('HandTossed');
console.log(pizza.type);

shop = new ChicagoPizza();
pizza = shop.sellPizza('DeepDish');
console.log(pizza.type);

