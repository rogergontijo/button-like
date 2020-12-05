using System;

namespace RockContentChallenge.Domain.Entities
{
    public class Article : BaseClass
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Guid AuthorGuid { get; set; }
        public int AmountLike { get; set; }

        public virtual Author Author { get; set; }
    }
}
