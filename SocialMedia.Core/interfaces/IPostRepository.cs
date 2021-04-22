using SocialMedia.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
    }
}
