using System;

namespace RockContentChallenge.Aplication.Dtos
{
    public class ArticleDto
    {
        public string Guid { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string AuthorGuid { get; set; }
        public int AmountLike { get; set; }
    }
}
