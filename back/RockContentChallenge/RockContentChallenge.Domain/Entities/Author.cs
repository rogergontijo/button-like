using System.Collections.Generic;

namespace RockContentChallenge.Domain.Entities
{
    public class Author : BaseClass
    {
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public Author()
        {
            Articles = new List<Article>();
        }
    }
}
