using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model
{
    public class DeliveryFee
    {
        public EligibleTransactionVolume eligible_transaction_volume { get; set; }
        public int price { get; set; }
    }
}
