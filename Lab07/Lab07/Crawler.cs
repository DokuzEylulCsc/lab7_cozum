using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07
{
    class Crawler
    {
        private string html;
        private string url;

        public Crawler(string url)
        {
            this.url = url;
            html = new WebClient().DownloadString(this.url);
        }

        public ArrayList FindInWebSite(String regex)
        {
            ArrayList list = new ArrayList();
            Regex ItemRegex = new Regex(regex, RegexOptions.Compiled);
            if (ItemRegex.Matches(html).Count > 0)
            {
                foreach (Match ItemMatch in ItemRegex.Matches(html))
                {
                    list.Add(ItemMatch.Value);
                }
            }
            else
            {
                throw new RegexNotFoundException($"Aranan string ifadesi {url}' sitesinde bulunamadı.");
            }

            return list;
        }  
      
       
    }
}
