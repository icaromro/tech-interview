using backend_solution.Model.level1;
using backend_solution.Model.level2;
using backend_solution.Model.level3;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model
{
    public class Output
    {
        public List<OutputCart> carts { get; set; }

        #region Constructors

        public Output(){ }

        public Output(Level1Input input)
        {            
            this.carts = new List<OutputCart>();
            foreach (InputCart cart in input.carts)
            {
                int total = 0;
                foreach (Item item in cart.items)
                {
                    total += item.quantity * input.FindArticlePrice(item.article_id);
                }                
                
                this.carts.Add(new OutputCart(cart.id, total));
            }            
        }

        public Output(Level2Input input)
        {
            this.carts = new List<OutputCart>();
            foreach (InputCart cart in input.carts)
            {
                int total = 0;

                foreach (Item item in cart.items)
                {
                    total += item.quantity * input.FindArticlePrice(item.article_id);
                }

                foreach (DeliveryFee deliveryFee in input.delivery_fees)
                {
                    EligibleTransactionVolume eligibleTransactionVolume = deliveryFee.eligible_transaction_volume;
                    if ((eligibleTransactionVolume.min_price <= total || eligibleTransactionVolume.min_price == null) 
                       && ((eligibleTransactionVolume.max_price == null) || total < eligibleTransactionVolume.max_price))
                    {
                        total += deliveryFee.price;
                        break;
                    }
                }

                this.carts.Add(new OutputCart(cart.id, total));
            }
        }

        public Output(Level3Input input)
        {
            this.carts = new List<OutputCart>();
            foreach (InputCart cart in input.carts)
            {
                int total = 0;

                foreach (Item item in cart.items)
                {
                    int itemPrice = input.FindArticlePrice(item.article_id);
                    Discount discount = input.FindArticleDiscount(item.article_id);

                    int itemTotal = 0;                   
                    switch (discount.type)
                    {
                        case "amount":
                            itemTotal = item.quantity * (itemPrice - discount.value);
                            break;
                        case "percentage":
                            int discountTotal = (itemPrice % 100) != 0 ? 
                                (itemPrice * discount.value / 100) + 1 : (itemPrice * discount.value / 100);
                            itemTotal = item.quantity * (itemPrice - discountTotal);
                            break;
                        default:
                            itemTotal = item.quantity * itemPrice;
                            break;
                    }
                    total += itemTotal ;
                }

                foreach (DeliveryFee deliveryFee in input.delivery_fees)
                {
                    EligibleTransactionVolume eligibleTransactionVolume = deliveryFee.eligible_transaction_volume;
                    if ((eligibleTransactionVolume.min_price <= total || eligibleTransactionVolume.min_price == null)
                       && ((eligibleTransactionVolume.max_price == null) || total < eligibleTransactionVolume.max_price))
                    {
                        total += deliveryFee.price;
                        break;
                    }
                }

                this.carts.Add(new OutputCart(cart.id, total));
            }
        }
        #endregion

        #region Obtain Output
        public static Output ObtainOutput(string filePath, int levelSelected)
        {            
            Output output = new Output();

            switch (levelSelected)
            {
                case 0:
                    Level1Input level1Input = Level1Input.ReadJsonFile(filePath);
                    output = new Output(level1Input);
                    break;
                case 1:
                    Level2Input level2Input = Level2Input.ReadJsonFile(filePath);
                    output = new Output(level2Input);
                    break;
                case 2:
                    Level3Input level3Input = Level3Input.ReadJsonFile(filePath);
                    output = new Output(level3Input);
                    break;
            }
            return output;
        }
        #endregion

        #region Testing 

        public static Output ReadJsonFile(string filePath)
        {            
            return JsonConvert.DeserializeObject<Output>(File.ReadAllText(filePath));
        }

        public bool Compare(Output outputToCompare)
        {
            if(this.carts.Count == outputToCompare.carts.Count)
            {
                foreach (OutputCart cart in this.carts)
                {
                    foreach (OutputCart cartToCompare in outputToCompare.carts)
                    {
                        if (cart.id == cartToCompare.id)
                            if (cart.total == cartToCompare.total)
                            {
                                outputToCompare.carts.Remove(cartToCompare);
                                break;
                            }
                    }
                }
                if (outputToCompare.carts.Count == 0)
                    return true;                
            }
            return false;
        }

        #endregion

    }    
}
