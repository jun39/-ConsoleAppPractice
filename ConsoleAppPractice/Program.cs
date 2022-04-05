using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    //metaverse系の投稿をredditから取得していろいろやるアプリを作る
    //ctrl +k+cでコメントアウト　ctrl +shift + lで削除


    //C#の構文の動画やって、Redditのやつちょっと作って
    //ARECを作るの再開
    //並行して、ドキュメント読むか、unity learnのスクリプトのチュートリアルをやる
    //チュートリアルをやりながら教育系メタバースアプリに使えるとこ
    //を積極的に探して、
    //チュートリアルをそのまま教育アプリを作るように改造する
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random dice = new Random();
            //int roll = dice.Next(1, 10);


            //Book book1 = new Book("john","junjun",roll);
            //Console.WriteLine(book1.pages);
            //try catchも書く

            Reddit sampleReddit = new Reddit();
            sampleReddit.Url = "https://hello";
            Console.WriteLine(sampleReddit.Url);



        }
    }

}
