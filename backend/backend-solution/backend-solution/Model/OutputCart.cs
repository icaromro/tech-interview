using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model
{
    public class OutputCart
    {
        public int id { get; set; }
        public int total { get; set; }

        public OutputCart(int id, int total)
        {
            this.id = id;
            this.total = total;
        }
    }
}
