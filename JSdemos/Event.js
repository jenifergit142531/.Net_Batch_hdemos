
function message()
{
    document.write("Welcome to events");
}



function changeColor()
{
    document.write("Change color");
    //bt1.style.color="red";
    //bt1.style.background="yellow";
}

//EVENT LISTENER
var btn=document.getElementById("bt1");
btn.addEventListener("click",changeColor);

// Arrow function

hello = () =>{
    alert ("hello all");
}