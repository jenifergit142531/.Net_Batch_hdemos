
function display(some)
{
   console.log(some);
}
let mypromise=new Promise(function(success,failure)
{
   let x=34;
   if(x==0)
   {
    success("OK");
   }
   else
   {
    failure("Error")
   }
   
});
mypromise.then(
    function(value){display(value);},
    function(error){display(error);}
);