using System;

namespace ListAdvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var advertScraper = new AdvertScraper();

            //Call GetAdverts Method for Posting
            var adverts = advertScraper.GetAdverts();

            //If advert exists write the value
            foreach(var advert in adverts)
            {
                Console.WriteLine($"Advert:{advert.Advert}");
            }
        }
    }
}
