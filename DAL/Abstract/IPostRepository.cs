
using Domain;
using System.Collections.Generic;

namespace DAL.Abstract
{
    
    public interface IPostRepository
    {
        // we make get for all posts
        IList<Post> GetPosts();

        // create a post
        void CreatePost(Post post);

    }
}
