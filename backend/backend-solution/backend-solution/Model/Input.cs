using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_solution.Model;

namespace backend_solution.Model
{
    public abstract class Input
    {
        public List<Article> articles { get; set; }
        public List<InputCart> carts { get; set; }     

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
