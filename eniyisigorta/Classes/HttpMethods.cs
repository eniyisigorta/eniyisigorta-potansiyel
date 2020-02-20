using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Classes
{
    class HttpMethods
    {
        public static string Get(string url, string referer, CookieContainer cookies)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.CookieContainer = cookies;
            req.UserAgent = "";
            req.Referer = referer;

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);

            string pageSrc;
            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                pageSrc = sr.ReadToEnd();
            }

            return pageSrc;
        }

        public static bool Post(string url, string postData, string referer, CookieContainer cookies)
        {
            string key = "Kullanıcı adı veya şifre hatalı!";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.CookieContainer = cookies;
            req.UserAgent = "";
            req.Referer = referer;
            req.ContentType = "";
            req.Accept = "";

            Stream postStream = req.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);

            postStream.Write(postBytes, 0, postBytes.Length);
            postStream.Dispose();

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string pageSrc = sr.ReadToEnd();
            sr.Dispose();

            return (!pageSrc.Contains(key));
        }
    }
}
