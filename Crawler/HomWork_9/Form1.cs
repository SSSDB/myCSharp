using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        crawler crawler = new crawler();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();          
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
            dgvResult.DataSource = resultBindingSource;
        }

        private void Crawler_CrawlerStopped(crawler obj)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(crawler crawler, string url, string status)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = status };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = txtUrl.Text;

            Match match = Regex.Match(crawler.StartURL, crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.Host = "^" + host + "$";
            crawler.File1 = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.start);
            thread.Start();
            lblInfo.Text = "爬虫已启动....";
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
