
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6
{
    public delegate void Mydel1();
    
    internal class EventApp
    {

        //creating event

        public event Mydel1 notify;
        public event Mydel1 notifyMail;


        public void RaiseEvent()
        {
            notify();
            notifyMail();
        }

        public void SMSnotify()
        {
            Console.WriteLine("You got 3 new messages");
        }
        public void Emailnotify()
        {
            Console.WriteLine("5 new unread mails");
        }


    }
}
