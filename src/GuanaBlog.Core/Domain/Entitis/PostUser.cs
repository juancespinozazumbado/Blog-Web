using Microsoft.AspNetCore.Identity;

namespace GuanaBlog.Core.Domain.Entitis
{
    public class PostUser : IdentityUser
    {
        public string  UserName {  get; set; }  
    }
}