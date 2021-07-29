using DataContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IPostService
    {
        //return an IList of Dto
        IList<PostDto> GetPost();

        // create a method that take all posting from our database
        // this method get a PostDto
        void CreatePost(PostDto dto);
    }
}
