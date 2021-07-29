using DAL.Abstract;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Concret
{
    //here will be part of logic with db
    public class PostRepository : IPostRepository
    {
        // this will create a post in our database
        public void CreatePost(Post post)
        {
            string sql = "INSERT INTO Post (Author, Content) VALUES (@Author, @Content)";
            
            //we create a sql connection and execute a query
            using (var connection = new SqlConnection(DatabaseOptions.DatabaseConnectionString))
            {
                connection.Execute(sql, new { Author = post.Author, Content = post.Content });
            }
        }

        public IList<Post> GetPosts()
        {
            List<Post> posts;
            string sql = "SELECT * FROM Post WHERE Created >= DATEADD(day, -1, GETDATE()) ORDER BY Created DESC";

            using (var connetion = new SqlConnection(DatabaseOptions.DatabaseConnectionString))
            {
                //executam totul la query si mapam totul la post 
                posts = connetion.Query<Post>(sql).ToList();
            }
            return posts;
        } 
    }
}
