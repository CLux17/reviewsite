using reviewsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace reviewsite.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        //public Dictionary<int, object> productDictionary = new Dictionary<int, object>();

        //public ProductRepository()
        //{
        //    productDictionary.Add(1, new Product(1001, "Nike Air Max 90's OFF-WHITE edition", "Shoes", "AirMax Based off the original Air Max 90," +
        //        " designer Virgil Abloh, decrostructed the design of the upper portion of the shoe. Seude & synthtic" +
        //        " material's make the upper portion. While the OFF-WHITE branding can be seen on the medial sides of the " +
        //        "shoe. Last but not least, is the famous tag located on the upper eyelet. This shoe is presented in the" +
        //        " colorway of, Desert Ore/Hyper Jade/Bright Mango.", "The shoe is the last one of Virgil's Off-White collab " +
        //        "for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to" +
        //        " run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they" +
        //        " really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of" +
        //        " Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't " +
        //        "recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark."));
        //    productDictionary.Add(2, new Product(1002, "High Heels Jimmy Choo", "Shoes", "Aveline in black. Exquisite, extravagant and the epitome" +
        //        " of elegance, this special occasion style hosts oversized bold crinoline bows to offer a 'same but" +
        //        " different' look on each pump. The bows are intricately woven, hand tied and sewn on for a dramatic " +
        //        "finish ", "The shoe is as beautiful as it looks on the site. It's does run small so, " +
        //        "I would recommend a 1/2 size up. As long as you're used to wearing heels they are " +
        //        "good for an all night wear. Perfect for a dramatic night on the town " +
        //        "or an elegant night out. Would I recommend this shoe? Absolutely!"));
        //    productDictionary.Add(3, new Product(1003, "Cold Brew Coffee", "Drinks", "Coffee was first brought to the country of Brazil, by a man " +
        //        "named Francisco de Melo Palheta, in 1727. He planted the first coffee tree in the state of Para and it " +
        //        "thrived and made a easy transition to Rio de Janeiro by 1770. There are two types of beans that are used" +
        //        " for production in Brazil. The first bean is called the robusta bean, the second is called the arabica bean." +
        //        " The majority of the coffee grown in Brazil is located in the southern portion of the country. Arabica is" +
        //        " known to be the better tasting bean of the two types, and is also the majority in annual production at " +
        //        "80%. Brazil as a country has a annual production rate of 7.9 billion pounds, as of 2018 records. America" +
        //        " is the leading country of coffee consumption at 400 million cup's per day. At this rate, coffee is not " +
        //        "going anywhere but up, in the United States anytime soon.", "Coffee? yes. Iced or Cold brew coffee? " +
        //        "Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this."));
        //    productDictionary.Add(4, new Product(1004, "Shock Energy Drink", "Drinks", "It's known as one of the best tasting energy drinks on " +
        //        "the market, with a unique flavor unlike any of its competitors. Contains 260 mg of caffeine per can, " +
        //        "higher than the caffeine content in a Red Bull, Rockstar, or Monster. Also offered in a variety of a" +
        //        " few flavors including citrus, grape, and loaded cherry", "Feel it withing 15 minutes of drinkning it, " +
        //        "fantastic for body building and tastes GREAT!!!!"));
        //}

        public List<Product> productList;

        public ProductRepository()
        {
            productList = new List<Product>()
            {
                new Product(1, "Nike Air Max 90's OFF-WHITE edition", "Shoes", "AirMax Based off the original Air Max 90," +
                " designer Virgil Abloh, decrostructed the design of the upper portion of the shoe. Seude & synthtic" +
                " material's make the upper portion. While the OFF-WHITE branding can be seen on the medial sides of the " +
                "shoe. Last but not least, is the famous tag located on the upper eyelet. This shoe is presented in the" +
                " colorway of, Desert Ore/Hyper Jade/Bright Mango.", "The shoe is the last one of Virgil's Off-White collab " +
                "for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to" +
                " run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they" +
                " really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of" +
                " Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't " +
                "recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark."),
                new Product(2, "High Heels Jimmy Choo", "Shoes", "Aveline in black. Exquisite, extravagant and the epitome" +
                " of elegance, this special occasion style hosts oversized bold crinoline bows to offer a 'same but" +
                " different' look on each pump. The bows are intricately woven, hand tied and sewn on for a dramatic " +
                "finish ", "The shoe is as beautiful as it looks on the site. It's does run small so, " +
                "I would recommend a 1/2 size up. As long as you're used to wearing heels they are " +
                "good for an all night wear. Perfect for a dramatic night on the town " +
                "or an elegant night out. Would I recommend this shoe? Absolutely!"),
                new Product(3, "Cold Brew Coffee", "Drinks", "Coffee was first brought to the country of Brazil, by a man " +
                "named Francisco de Melo Palheta, in 1727. He planted the first coffee tree in the state of Para and it " +
                "thrived and made a easy transition to Rio de Janeiro by 1770. There are two types of beans that are used" +
                " for production in Brazil. The first bean is called the robusta bean, the second is called the arabica bean." +
                " The majority of the coffee grown in Brazil is located in the southern portion of the country. Arabica is" +
                " known to be the better tasting bean of the two types, and is also the majority in annual production at " +
                "80%. Brazil as a country has a annual production rate of 7.9 billion pounds, as of 2018 records. America" +
                " is the leading country of coffee consumption at 400 million cup's per day. At this rate, coffee is not " +
                "going anywhere but up, in the United States anytime soon.", "Coffee? yes. Iced or Cold brew coffee? " +
                "Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this."),
                new Product(4, "Shock Energy Drink", "Drinks", "It's known as one of the best tasting energy drinks on " +
                "the market, with a unique flavor unlike any of its competitors. Contains 260 mg of caffeine per can, " +
                "higher than the caffeine content in a Red Bull, Rockstar, or Monster. Also offered in a variety of a" +
                " few flavors including citrus, grape, and loaded cherry", "Feel it withing 15 minutes of drinkning it, " +
                "fantastic for body building and tastes GREAT!!!!")
            };
        }

        //public IEnumerable<Product> GetAll()
        //{
        //    return productDictionary.ToDictionary();
        //}

        public IEnumerable<Product> GetAll()
        {
            return productList.ToList();
        }

        public Product GetById(int id)
        {
            return productList.Single(c => c.Id == id);
        }

        //public Product GetById(int id)
        //{
        //    return ;
        //}
    }
}
