function purchase()
{
   var name=prompt("Enter your name");
   var amount=prompt("Enter the purchase amount");
   amount=parseInt(amount);
   if(amount>5000)
   {
    alert("You get 50 % discount");
   }
   else if(amount < 5000 && amount > 2500)
   {
    alert ("You get 25% discount");
   }
   else if(amount < 2500 && amount > 0)
   {
    alert("You get 10% discount");
   }
   else
   {
    alert("No discount coupons available");
   }
}

purchase()