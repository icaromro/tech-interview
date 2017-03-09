
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model.level3
{
    public class Level3Input:Input
    {
        public List<DeliveryFee> delivery_fees { get; set; }
        public List<Discount> discounts { get; set; }

        public Level3Input()
        {
            delivery_fees = new List<DeliveryFee>();
            discounts = new List<Discount>();
        }

        public static Level3Input ReadJsonFile(string filePath)
        {
            return JsonConvert.DeserializeObject<Level3Input>(File.ReadAllText(filePath));
        }

        public Discount FindArticleDiscount(int article_id)
        {
            foreach (Discount discount in discounts)
            {
                if (discount.article_id == article_id)
                    return discount;
            }
            return new Discount();
        }
    }
}
