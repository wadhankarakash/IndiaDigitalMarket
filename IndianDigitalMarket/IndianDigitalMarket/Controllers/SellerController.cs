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

        public void RegisterShop()
        { }

        public void EditShop()
        { }


        public void AddproductToShop()
        { }

        public void AddServicePincodes()
        { }


        public void ViewOrder()
        { }

        public void AcceptOrder()
        { }

        public void AssignOrder()
        { }

        public void ViewWallet()
        { }

    }
}