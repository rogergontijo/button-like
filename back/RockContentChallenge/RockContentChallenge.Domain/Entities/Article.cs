namespace RockContentChallenge.Domain.Entities
{
    public class Article : BaseClass
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public int AmountLike { get; set; }
    }
}
