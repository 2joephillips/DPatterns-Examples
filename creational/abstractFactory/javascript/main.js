"use strict";


var fromPrototype = function(prototype, object) {
    var newObject = Object.create(prototype);
    for (var prop in object) {
        if (object.hasOwnProperty(prop)) {
            newObject[prop] = object[prop];
        }
    }
  return newObject;
};


// Define our `Ingredients` base object
var Pizza = {
    createDough: function() {
        return 'generic dough';
    },
    createSauce: function() {
        return 'generic sauce';
    },
    createCrust: function() {
        return 'generic crust';
    }
};

// Extend `Ingredients` with concrete implementations
Pizza.createChicagoStyle = function() {
    return fromPrototype(Pizza, {
        createDough: function() {
            return 'thick, heavy dough';
        },
        createSauce: function() {
            return 'rich marinara';
        },
        createCrust: function() {
            return 'deep-dish';
        }
    });
};

Pizza.createCaliforniaStyle = function() {
    return fromPrototype(Pizza, {
        createDough: function() {
            return 'light, fluffy dough';
        },
        createSauce: function() {
            return 'tangy red sauce';
        },
        createCrust: function() {
            return 'thin and crispy';
        }
    });
};

// Try it out!
var californiaIngredients = Pizza.createCaliforniaStyle();
console.log(californiaIngredients.createCrust()); 

var chicagoStyle = Pizza.createChicagoStyle();
console.log(chicagoStyle.createCrust());