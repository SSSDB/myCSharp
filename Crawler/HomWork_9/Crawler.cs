using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{
    class crawler
    {
        public event Action<crawler> CrawlerStopped;
        public event Action<crawler, string, string> PageDownloaded;
        public List<PageInfo> pageList = new List<PageInfo>();
        //所有已下载和待下载URL，key是URL，value表示是否下载成功
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();
        //待下载队列
        private Queue<string> waitingQueue = new Queue<string>();
        //URL表达式，用于在HTML文本中查找URL
        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";

        public string StartURL;  
        public string Host; //主机
        public string File1; //文件  
        public Encoding HtmlEncoding;
        public int MaxPage;
        public Dictionary<string, bool> DownloadedPages { get => urls; }

        public crawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        //将相对路径转为绝对路径
        static private string FixUrl(string url, string baseUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }

            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }

            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))//上级目录下
            {
                url = url.Substring(3);
                int length1 = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, length1));
            }

            if (url.StartsWith("./"))//当前目录下
            {
                return FixUrl(url.Substring(2), baseUrl);
            }

            int length2 = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, length2) + "/" + url;
        }

        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = urls.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            
            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径

                //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, Host) && Regex.IsMatch(file, File1)
                  && !urls.ContainsKey(linkUrl))
                {
                    waitingQueue.Enqueue(linkUrl);
                    urls.Add(linkUrl, false);                  
                }
            }
        }

       public void start() {
            urls.Clear();
            waitingQueue.Clear();
            waitingQueue.Enqueue(StartURL);
            
            while (urls.Count<MaxPage&&waitingQueue.Count>0) {
                string url = waitingQueue.Dequeue();
                try {
                    
                    urls[url] = true;
                    string html = DownLoad(url);
                    Parse(html, url);
                    PageDownloaded(this, url, "success");
                } catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }
    }
}
