using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tapsoroq_6;

namespace tapsoroq_6
{
    namespace Admin
    {
        class Admin
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public Post.Post[] posts = new Post.Post[] { };
            public Nodification[] nodifications = new Nodification[] { };

            public Admin(int id, string username, string password )
            {
                this.id = id;
                this.username = username;
                this.password = password;

            }

            public void Add(Post.Post c)
            {
                Array.Resize(ref posts, posts.Length + 1);
                posts[posts.Length - 1] = c;
            }
            public void AddNotications(Nodification c)
            {
                Array.Resize(ref nodifications, nodifications.Length + 1);
                nodifications[nodifications.Length - 1] = c;
            }

            public void PostShow()
            {
                for (int i = 0; i < posts.Length; i++)
                {
                    Console.WriteLine("===========================");
                    posts[i].Show();
                    Console.WriteLine("===========================");
                }
            }
            public void PostName()
            {
                for (int i = 0; i < posts.Length; i++)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine(i+1+"----"+posts[i].content);
                    Console.WriteLine("===========================");
                }
            }

            public void ShowNodification()
            {
                for (int i = 0; i < nodifications.Length; i++)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("Id-----" + nodifications[i].id);
                    Console.WriteLine("Text-----" + nodifications[i].text);
                    Console.WriteLine("Datatime-----" + nodifications[i].datetime);
                    Console.WriteLine("Username-----" + nodifications[i].user.name);
                }
             
            }
        }
    }
    
}
