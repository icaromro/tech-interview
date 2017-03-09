using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model.level2
{
    public class Level2Input:Input
    {
        public List<DeliveryFee> delivery_fees { get; set; }

        public Level2Input()
        {
            delivery_fees = new List<DeliveryFee>();
        }

        public static Level2Input ReadJsonFile(string filePath)
        {
            return JsonConvert.DeserializeObject<Level2Input>(File.ReadAllText(filePath));
        }
    }
}
