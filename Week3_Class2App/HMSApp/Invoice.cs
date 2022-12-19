using HMSApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApp
{
    interface PaymentInterface
    {
        void AddInvoice();
        void DeleteInvoice();

    }

    interface CashInterface
    {
        void Cash_Card();
    }
     
    interface HealthInterface
    {
        void InsurancePayment();
    }
      interface HospitalEmployee
    {
        void MemberCoupons();
    }
       

    }

    class Cashpayment : PaymentInterface, CashInterface
{
    public void AddInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void DeleteInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void Cash_Card()
    {
        Console.WriteLine("You need to do the code here");
    }
}

    class HealthInsurance : PaymentInterface , HealthInterface
{
    public void AddInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void DeleteInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void InsurancePayment()
    {
        Console.WriteLine("You need to do the code here");
    }
}

    class InternalEmployee : PaymentInterface , HospitalEmployee
{
    public void AddInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void DeleteInvoice()
    {
        Console.WriteLine("You need to do the code here");
    }
    public void MemberCoupons()
    {
        Console.WriteLine("You need to do the code here");
    }
}
    internal class Invoice
    {
        public static void Payment()
        {
            Console.WriteLine("You need to do the code here");
        }
    }
}
