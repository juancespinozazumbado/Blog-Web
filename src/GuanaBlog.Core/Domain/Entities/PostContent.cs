

using System.Runtime.CompilerServices;

namespace GuanaBlog.Core.Domain.Entities;

    internal class PostContent : BaseEntity
    {
        
        public string Headder { get; set; } 
        public string Title { get; set; }   
        public string Body { get; set; }
        public string footer { get; set; } 
        public List<Image> Images { get; set; } 
    }

