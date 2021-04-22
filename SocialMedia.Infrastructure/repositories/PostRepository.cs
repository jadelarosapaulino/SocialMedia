using SocialMedia.Core.entities;
using SocialMedia.Core.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.repositories
{
    public class PostRepository: IPostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var post = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https:misapis.com/{x}",
                UserId = x * 2
            });

            return post;
        }
    }
}
