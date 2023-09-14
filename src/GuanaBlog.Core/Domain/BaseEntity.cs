using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanaBlog.Core.Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateOnly CreateDate { get; set; }
        public DateTime UpdateDate { get; set;}
    }
}
