using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    // model from database
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
