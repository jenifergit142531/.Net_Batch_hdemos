
//creating class

class Pizza
{


    //constructor - Intialize the values
   
    constructor(base,ingredient)
    {
        this.base=base;
        this.ingredient=ingredient;
    }

    
    getPizza()
    {
        return (`Pizza is made of ${this.base} and ${this.ingredient}`);
    }
   
}

//Creating object
 let vegpizza=new Pizza('wheat','broccoli and mushroom');
 let nonvegpizza=new Pizza('maize','chicken and mushroom');

 
//Function call

console.log(vegpizza.getPizza());
console.log(nonvegpizza.getPizza());

