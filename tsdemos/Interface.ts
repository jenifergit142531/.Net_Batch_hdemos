interface Movies
{
    getBollywood():string;
    getHollywood():string;
}
interface Booking
{
    getPlace():string;
    getTime():string;
}
interface Payment
{
    cash():void;
    cards():void;
}

class HindiAudience implements Movies
{
   getBollywood(): string {
       return "Cirkus";
   }
   getHollywood(): string {
       return "not interested";
   }
}

class EnglishAudience implements Movies,Booking{
    getBollywood(): string {
        return "not interested";
    }
    getHollywood(): string {
        return "Avatar 2";
    }
    getPlace(): string {
        return "PVR";
    }
    getTime(): string {
        return "Night show 10:45 PM IST";
    }

}


//create object

let ba=new HindiAudience();
let ha=new EnglishAudience();
console.log("Bollywood Movie Details" ,ba.getBollywood());
console.log(`Hollywood movie details 
Movie Name : ${ha.getHollywood()}
Location:${ha.getPlace()}
Show Time : ${ha.getTime()}`);