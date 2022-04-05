using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class Reddit
    {
        private string url;

        //try catchでクエリーが文字列ではないときの例外を書く


        public Reddit()
        {
            url = "https://api.pushshift.io/reddit/search/comment/?q=";
        }

        //public string GetComment(string query,string duration)
        //{

        //}

        public string Url
        {
            get{
                return url;
            }

            set{
                if(value is string)
                {
                    url = value;
                }
            }
        }
    }
}
