
//Abstraction 
    function getpizza(base1,ingredient1)  
    {
        let base= base1;
        let ingredient=ingredient1;


        // hiding the details
     let getPizza1_noaccess = function()
    {
        return (`Pizza is made of ${base} and ${ingredient}`);
    }

    //providing the details
    this.getPizza_access = function()
    {
        return (`Pizza is made of ${base} and ${ingredient}`);
    }
    }
      
//function call
let pizza1=new getpizza('wheat','paneer');
console.log(pizza1.getPizza1_noaccess);  // implementing abstraction here - 'undefined' output on screen
console.log(pizza1.getPizza_access());