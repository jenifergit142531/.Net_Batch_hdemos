
//base class

class Pizza
{
  constructor(pizzabase)
  {
    this.pizzabase=pizzabase;
  }
  toString()
  {
    return (`Base is made up of ${this.pizzabase}`);
  }
}

//Child class - extends keyword is used for inheritance  

class VegPizza extends Pizza
{
   constructor(pizzabase,ingredient)
   {
     super(pizzabase);  // super() - inheriting from the base class
     this.ingredient=ingredient;
   }
   toString()
   {
    return (`${super.toString()} and ${this.ingredient}`);
   }
}

//create object

var order1=new VegPizza('wheat','Capsicum');
console.log(order1.toString());