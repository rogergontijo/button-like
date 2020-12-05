using System;

namespace RockContentChallenge.Domain.Entities
{
    public class BaseClass
    {
        public Guid Guid { get; set; }
        public DateTime CreateDate { get; set; }

        public BaseClass()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}
