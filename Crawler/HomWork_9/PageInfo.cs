using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class PageInfo
    {
        public string index { get; set; }
        public string url { get; set; }
        public string status { get; set; }
        public PageInfo() { }
        public PageInfo(string index, string url,string status) {
            this.index = index;
            this.url = url;
            this.status = status;
        }
    }
}