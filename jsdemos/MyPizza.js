
//creating function
function Ingredients(pizza_base,veggies,non_veggies,cheese)
{
    this.pizza_base = pizza_base;
    this.veggies=veggies;
    this.non_veggies=non_veggies;
    this.cheese=cheese;
}

//Creating object

let vegpizza=new Ingredients('wheat','corn & mushroom','none','cheddar');
let nonvegpizza=new Ingredients('maize','none','pepperoni','cheddar');

// Print the values on console

console.log(`${vegpizza.veggies} ${vegpizza.cheese}`);
console.log(`${nonvegpizza.non_veggies} ${nonvegpizza.cheese}`);

// Print the values on html document

document.write(vegpizza.veggies +"<br>");
document.write(nonvegpizza.non_veggies);
