function myCars()
{
    const cars=["bmw","ford","kia","volvo","benz"];
    var len=cars.length;
    var result ="";
    var i=0;
    
    alert("Array length is "+len);

   /* for(var i=0;i<len;i++)
    {
       result+=cars[i] + "<br>";
    }*/

   /* while(cars[i])
    {
        result +=cars[i] +"<br>"
        i++;
    }*/

    do
    {
        result +=cars[i] +"<br>"
        i++;
    }while(cars[i]);


    document.write(result);

    document.write("sorted array here : "+cars.sort() +"<br>");
    document.write("Reverse array here : "+cars.reverse() +"<br>");
    

}

myCars();