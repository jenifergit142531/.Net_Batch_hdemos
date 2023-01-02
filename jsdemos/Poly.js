// base class

class Car 
{
    constructor(name,color)
    {
        this.name=name;
        this.color=color;
    }
}
class Kia extends Car
{
    constructor(name,color,variant)
    {
        super(name,color);
        this.variant=variant;
    }
    
   showInfo()
   {
      console.log("This is " +this.name + " and the variant is " + this.variant +
      " with the colour " + this.color );
   }
}
class Ford extends Car
{
    constructor(name,color,variant)
    {
        super(name,color);
        this.variant=variant;
    }
    showInfo()
    {
        console.log("This is " +this.name + " and the variant is " + this.variant +
        " with the colour " + this.color );
    }
}
class Benz extends Car
{
    constructor(name,color,variant)
    {
        super(name,color);
        this.variant=variant;
    }
    showInfo()
    {
        console.log("This is " +this.name + " and the variant is " + this.variant +
        " with the colour " + this.color );
    }
}

// create object

var kia1=new Kia("Kia","white","Carens Luxury plus");
var ford1=new Ford("Ford","brown","Ecosport");
var benz1=new Benz("Benz","Blue","GLB");

/*kia1.showInfo();
ford1.showInfo();
benz1.showInfo();*/

var obj=[kia1,ford1,benz1]
obj.forEach(function(show)
{
   show.showInfo();
});


