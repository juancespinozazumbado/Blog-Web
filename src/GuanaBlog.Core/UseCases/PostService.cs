using GuanaBlog.Core.Domain.Entitis;
using GuanaBlog.Core.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanaBlog.Core.UseCases
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IRepository<PostComment> _postComentsRepository;
    }
}
