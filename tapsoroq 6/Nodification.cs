using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsoroq_6
{
    class Nodification
    {
        public Nodification(int id, string text, string datetime, User.User user)
        {
            this.id = id;
            this.text = text;
            this.datetime = datetime;
            this.user = user;
        }

        public int id { get; set; }
        public string text { get; set; }
        public string datetime { get; set; }
        public User.User  user { get; set; }
    }
}
