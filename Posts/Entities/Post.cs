using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Entities
{
    internal class Post
    {
        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments = new List<Comment> ();

        public Post () { }
        public Post (DateTime momment, string title, string content, int likes)
        {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }


        public void PublicPost ()
        {
            Console.WriteLine($"{Momment}\n{Title}\n{Content}\n{Likes}\nComments:");
            foreach (Comment comment in Comments)
            {
                Console.WriteLine(comment.Text);
            }
        }

        public override string ToString ()
        {
            StringBuilder stringBuilder = new StringBuilder ();
            stringBuilder.AppendLine(Momment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(Title);
            stringBuilder.AppendLine(Content);
            stringBuilder.Append(Likes);
            stringBuilder.AppendLine(" - Likes");
            stringBuilder.AppendLine("Commments:");

            foreach (Comment comment in Comments)
            {
                stringBuilder.AppendLine(comment.Text);
            }
            return stringBuilder.ToString();

        }

    }
}
