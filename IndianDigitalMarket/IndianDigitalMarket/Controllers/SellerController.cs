using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;


namespace IndianDigitalMarket.Controllers
{
    public class SellerController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET")]
        public string[] RegisterSeller()
        {
            return new string[] { "value1", "value2" };
        }

        //Creates shop for seller
        public void RegisterShop()
        { }

        //Modify shop for seller
        public void ModifyShop()
        { }

        //View shops owned by me
        public void ViewMyShop()
        { }

        //View Products in My Shop
        public void ViewMyProducts()
        { }

        //Add the product you want to sell
        public void AddproductToShop()
        { }

        //Add the service pincodes to products
        public void AddServicePincodesToProduct()
        { }

        //View Orders posted by customers
        public void ViewOrder()
        { }

        //Verify order from customer  
        public void VerifyOrderDetails()
        { }

        //Accept orders - (Orders Staging to Order Master)
        public void AcceptOrder()
        { }

        //Assign order to Shop Employees to full fill
        public void AssignOrder()
        { }

        //CompleteOrder - debit order amount from buyer wallet and add to seller wallet
        public void CompleteOrder()
        { }

        //Send Bill Monthly
        public void SendMonthlyBill()
        { }

        //Record Cash Payment - Make the recorder debit and credit entry to wallet null and void
        public void RecordCashPayment()
        { }        

        //View all the Buys and Sells - Earning - Number of Cash Payments/Pending Payments/Full filled payments
        public void ViewMonthlyReport()
        { }



    }
}