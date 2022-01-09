using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsoroq_6
{
    namespace Post
    {
        public class Post
        {
            public Post(int id, string content, string creationdatetime, int likecount = 0, int viewcount = 0)
            {
                this.id = id;
                this.content = content;
                this.creationdatetime = creationdatetime;
                this.likecount = likecount;
                this.viewcount = viewcount;
            }

            public int id { get; set; }
            public string content { get; set; }
            public string creationdatetime { get; set; }
            public int likecount { get; set; }
            public int viewcount { get; set; }
            public void Show()
            {
                Console.WriteLine("id------" + id);
                Console.WriteLine("content------" + content);
                Console.WriteLine("creationdatetime------" + creationdatetime);
                Console.WriteLine("likecount------" + likecount);
                Console.WriteLine("viewcount------" + viewcount);
                viewcount++;
            }
        }
    }
    
}
