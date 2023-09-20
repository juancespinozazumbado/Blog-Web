

using System.Runtime.CompilerServices;

namespace GuanaBlog.Core.Domain.Entitis
{
    internal class PostContent
    {
        public Guid PostId { get; set; }
        public string Headder { get; set; } 
        public string Title { get; set; }   
        public string Body { get; set; }
        public string footer { get; set; } 
        public List<Image> Images { get; set; } 
    }
}
