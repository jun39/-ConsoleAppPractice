using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    //metaverse系の投稿をredditから取得していろいろやるアプリを作る
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 10);
            

            Book book1 = new Book();
            book1.title = "harry";
            book1.author = "jke";
            book1.pages = roll;
            Console.WriteLine(book1.pages);



        }
    }

}
