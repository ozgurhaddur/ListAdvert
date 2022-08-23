using System;
using System.Collections.Generic;
using System.Text;

namespace ListAdvert
{
    public class AdvertModel
    {
        //Constructor for AdvertModel
        public AdvertModel(string advert /*string price*/)
        {
            Advert = advert;
            //Price = price;
        }

        //Values of Advert and Price
        public string Advert { get; set; }

        //public string Price { get; set; }

    }
}
