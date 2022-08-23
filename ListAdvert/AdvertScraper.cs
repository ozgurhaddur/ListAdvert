using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListAdvert
{
    class AdvertScraper
    {
        //Input the URL Link
        private const string BaseUrl = "https://www.sahibinden.com/anasayfa-vitrin";

        //Get Adverts Method
        public IEnumerable<AdvertModel> GetAdverts()
        {
            
            var web = new HtmlWeb();
            //Loading Existing URL Link
            var document = web.Load(BaseUrl);

            //Get data by QuerySelectorAll
            var header = document.QuerySelectorAll("div").Skip(1);

            //If data exists get query values
            foreach (var head in header)
            {
                var hdr = head.QuerySelectorAll(".searchGalleryBorder");


                var advert = hdr[0].InnerText;
                //var price = hdr[1].InnerText;

                //return external defined AdvertModel
                yield return new AdvertModel(advert);
            }

        }
    }
}
