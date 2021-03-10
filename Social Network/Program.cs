using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class Program
    {
        static void Main(string[] args)
        {
         
                string postText = Console.ReadLine();

                Post post = new Post(postText);
                post.Text = postText;
                post.ShowPost();
            Console.ReadKey();
            
        }

        class Post
        {
            private string text;
            
            //write a constructor here
            public Post(string postText)
            {
                text = postText;
            }


            public void ShowPost()
            {
                Console.WriteLine(text);
            }

            //write a property for member text
            public string Text { get; set; }
        }
    }   
}
