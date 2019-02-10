using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace shorten_link
{
    public class link
    {
     public string basic(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "http://shurl.ir/api.php?url=" + url;
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.shorturl;
                return link;

            }
            
        }
        public string custom(string url , string coustomlink)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "http://shurl.ir/api.php?url=" + url + "&cust=" + coustomlink;
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.shorturl;
                return link;

            }
        }

        public string pass(string url , string pass)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "http://shurl.ir/api.php?url=" + url + "&pass=" + pass;
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.shorturl;
                return link;

            }
        }
        
        public string u_c_p(string url , string custom , string pass)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "http://shurl.ir/api.php?url=" + url + "&cust=" + custom + "&pass=" + pass; 
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.shorturl;
                return link;

            }
        }
    }
}
