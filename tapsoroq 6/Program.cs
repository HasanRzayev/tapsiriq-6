using System;
using System.Text;
using System.Threading;
using tapsoroq_6;
using tapsoroq_6.Admin;
using tapsoroq_6.Post;
using tapsoroq_6.User;

string Date()
{
    return Convert.ToString(DateTime.Now);
}
Console.OutputEncoding = System.Text.Encoding.UTF8;

Encoding unicode = Encoding.Unicode;

Post post1 = new(1, "good", Date());
Post post2 = new(1, "funny", Date());
Post post3 = new(1, "sad", Date());
Post post4 = new(1, "bad", Date());

Admin admin = new(1,"hasan","1234");
admin.Add(post1);
admin.Add(post2);
admin.Add(post3);
admin.Add(post4);

/// //////////////////////////////////////////////////////////
User user = new(1, "huseyn", "rzayev", 15, "dfdfdfd", "1234");
User user_2 = new(2, "atilla", "musayev", 15, "dfdfdfd", "1234");
User user_3 = new(3, "teo", "musayev", 15, "dfdfdfd", "1234");
Database database = new();

database.AddAdmin(admin);
database.AddUser(user);
database.AddUser(user_2);
database.AddUser(user_3);
var choose = 0;
while (true)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine("Hansi formada daxil olacaginizi daxil edin...");
    Console.WriteLine("User");
    Console.WriteLine("Admin");
    choose = Convert.ToInt32(Console.ReadLine());
    if (choose == 1)
    {
        string name;
        string password;
        Console.WriteLine("Name daxil edin");
        name = Console.ReadLine();
        Console.WriteLine("Password daxil edin");
        password = Console.ReadLine();
        if (database.CheckUser(name, password) == -1)
        {
            Console.WriteLine("Duzgun daxil edin  !!!");
            Thread.Sleep(1000);
            continue;

        }
        
 
        while (true)
        {
            Console.WriteLine("\u263A"+ " Xos gelmisiniz"+" \u263A" );
      
            admin.PostName();
            Console.WriteLine("Istedinizi secin  ( Daxil oldugunuzda baxis artacaq )");
            Console.WriteLine("Geri qayitmaq ucun sifir  basin ");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose > 4 || choose < -1)
            {
                Console.WriteLine("Duzgun daxil edin  !!!");
                Thread.Sleep(1000);
                continue;
            }
            else if (choose == 0) break;
            Console.Clear();
            admin.posts[choose - 1].Show();
            Console.WriteLine("LIKE et (Like etmek ucun ENTER basin)");
            Console.WriteLine("Geri qayitmaq ucun Backspace  basin ");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Like olundu");
                Thread.Sleep(1000);
                admin.posts[choose - 1].likecount++;
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                break;

            }
            else
            {
                Console.WriteLine("Like olunmadi");
                Thread.Sleep(1000);
            }
  
    
            admin.AddNotications(new Nodification(1, "like etdi", Date(), database.users[database.CheckUser(name, password)]));
        }
        
        
    }
    else if (choose == 2)
    {

        string name;
        string password;
        Console.WriteLine("UserName daxil edin");
        name = Console.ReadLine();
        Console.WriteLine("Password daxil edin");
        password = Console.ReadLine();
        if (database.CheckAdmin(name, password) == false)
        {
            Console.WriteLine("Duzgun daxil edin  !!!");
            Thread.Sleep(1000);
            continue;

        }
        Console.WriteLine("\u263A" + " Xos gelmisiniz" + " \u263A");
        Console.WriteLine("Gelen bildirisler......");
        admin.ShowNodification();
        Console.WriteLine("Devam etmek ucun her hansi bir yere bas.....");
        var key = Console.ReadKey();
        Thread.Sleep(1000);
    }

}