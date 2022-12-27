function find()
{
    var day;
   switch(new Date().getDay())
   {
    case 0:
        day="sunday";
        break;
        case 1:
        day="Monday";
        break;
        case 2:
        day="Tuesday";
        break;
        case 3:
        day="Wednesday";
        break;
        case 4:
        day="Thursday";
        break;
        case 5:
            day="Friday";
            break;
            case 6:
                day="Saturday";
                break;

   }
   document.write("Today's day is :"+day);
}


find()