using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model
{
    public class Discount
    {
        public int article_id { get; set; }
        public string type { get; set; }
        public int value { get; set; }
    }
}
