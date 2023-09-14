
using System.Reflection.Metadata;

namespace GuanaBlog.Core.Domain.Entitis
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public ContentType ContentType { get; set; }  
        public DateTime CreatedAtDate { get; set; } 
        public IList<PostComment> Comments { get; set; }
        public IList<Tag> Tags { get; set; }

        public IList<RateVote> RatesVotes { get; set; }

        public Guid UserId { get; set; }
        public PostUser User { get; set; }  
        public double Rate;

    }
}
