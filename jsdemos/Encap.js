
//Create class

class Pizza
{


    //constructor - Intialize the values
   
    constructor(base,ingredient)
    {
        this.base=base;
        this.ingredient=ingredient;
    }

    //Create a encapsulation- wrapping the data and function in single unit
    // variable 'address' is wrapped inside the method 'delivery_address()'
    delivery_address(address)
    {
        this.address=address;
    }

    
    getPizza()
    {
        console.log (`Pizza is made of ${this.base} and ${this.ingredient}
         and delivered to ${this.address}`);

    }
   
}

//Creating object
 let vegpizza=new Pizza('wheat','broccoli and mushroom');
 let nonvegpizza=new Pizza('maize','chicken and mushroom');
 vegpizza.delivery_address('chennai');
 nonvegpizza.delivery_address('kadapa');

 //function call

 vegpizza.getPizza();
 nonvegpizza.getPizza();

 
