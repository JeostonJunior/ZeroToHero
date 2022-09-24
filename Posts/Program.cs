using Posts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts
{
    internal class Program
    {
        static void Main (string[] args)
        {
            DateTime momment = new DateTime(2018, 06, 21, 13, 05, 44);
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wondergul country!";
            int likes = 12;
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(momment, title, content, likes);

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Console.WriteLine(post1);


        }
    }
}
