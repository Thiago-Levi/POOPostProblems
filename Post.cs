using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PostProblems
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public int Likes { get; set; }

        public List<Comment> ListOfComments = new List<Comment>();
       

       public Post(string title, string content, int likes)
        { 
            Moment = DateTime.Now;
            Title = title;
            Content = content;
            Likes = likes;
         
        }
        
        
        public void AddCommentInPost(Comment theComment)
        {
            ListOfComments.Add(theComment);
        }

        public string ShowComments()
        {
         
            StringBuilder allComments = new StringBuilder();
            foreach (var comment in ListOfComments)
            {
             
                allComments.Append(comment.Text + "\n");
                
            }

            string outputComments = $"Comments:\n{Convert.ToString(allComments)}";
            string outputPost = $"{Title}\n{Likes} Likes - {Moment}";
            string showPostAndComments = $"{outputPost}\n{outputComments}";

            return showPostAndComments;
        }


            
    }
}
