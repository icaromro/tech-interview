using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_solution.Model.level1
{
    public class Level1Input:Input
    {
        public static Level1Input ReadJsonFile(string filePath)
        {
            //In my experience it is easier to work with objects than with pieces of an file
            //and because of that I decided to deserialize the json file.
            return JsonConvert.DeserializeObject<Level1Input>(File.ReadAllText(filePath));
        }
    }
}
