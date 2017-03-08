using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using backend_solution.Model;
using Newtonsoft.Json;

namespace backend_solution.Model
{
    public class Input
    {
        public List<Article> articles { get; set; }
        public List<InputCart> carts { get; set; }

        public static Input ReadJsonFile(string filePath)
        {            
            return JsonConvert.DeserializeObject<Input>(File.ReadAllText(filePath));
        }

        public int FindArticlePrice(int article_id)
        {
            foreach (Article article in articles)
            {
                if (article.id == article_id)
                    return article.price;
            }
            return 0;
        }
    }
}
